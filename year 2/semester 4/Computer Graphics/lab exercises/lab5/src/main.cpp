#include <OpenGLPrj.hpp>

#include <GLFW/glfw3.h>

#include <Shader.hpp>

#include <iostream>
#include <string>
#include <vector>

const std::string program_name = ("PACMAN");

void framebuffer_size_callback(GLFWwindow *window, int width, int height);

void processInput(GLFWwindow *window);

// settings
const unsigned int SCR_WIDTH = 800;
const unsigned int SCR_HEIGHT = 800;
float scale = 0.25;
glm::mat4 transform = glm::scale(glm::mat4(1.0f), glm::vec3(scale, scale, scale));
float cordX = 0, cordY = 0;
float const HALF_PI = glm::half_pi<float>();


int main() {
    // glfw: initialize and configure
    // ------------------------------
    glfwInit();
    glfwWindowHint(GLFW_CONTEXT_VERSION_MAJOR, 3);
    glfwWindowHint(GLFW_CONTEXT_VERSION_MINOR, 3);
    glfwWindowHint(GLFW_OPENGL_PROFILE, GLFW_OPENGL_CORE_PROFILE);

#ifdef __APPLE__
    glfwWindowHint(
        GLFW_OPENGL_FORWARD_COMPAT,
        GL_TRUE); // uncomment this statement to fix compilation on OS X
#endif

    // glfw window creation
    // --------------------
    GLFWwindow *window = glfwCreateWindow(SCR_WIDTH, SCR_HEIGHT,
                                          program_name.c_str(), nullptr, nullptr);
    if (window == nullptr) {
        std::cout << "Failed to create GLFW window" << std::endl;
        glfwTerminate();
        return -1;
    }
    glfwMakeContextCurrent(window);
    glfwSetFramebufferSizeCallback(window, framebuffer_size_callback);

    // glad: load all OpenGL function pointers
    // ---------------------------------------
    if (!gladLoadGLLoader(reinterpret_cast<GLADloadproc>(glfwGetProcAddress))) {
        std::cout << "Failed to initialize GLAD" << std::endl;
        return -1;
    }

    // build and compile our shader program
    // ------------------------------------

    std::string shader_location("../res/shaders/");

    std::string used_shaders("shader");

    Shader ourShader(shader_location + used_shaders + std::string(".vert"),
                     shader_location + used_shaders + std::string(".frag"));


    std::vector<float> vertices;

    float const TWO_PI = glm::two_pi<float>();

    // Starting angle is not 0, but PI/8
    float angle = TWO_PI / 16;
    int const NUMBER_OF_ANGLES = 31;
    float radius = 1.0f;
    float angle_increment = (TWO_PI - TWO_PI / 8) / NUMBER_OF_ANGLES;

    for (auto i = 0; i < 3; ++i)
        vertices.push_back(0.0f);

    for (auto i = 0; i <= NUMBER_OF_ANGLES; ++i) {
        vertices.push_back(radius * glm::cos(angle));
        vertices.push_back(radius * glm::sin(angle));
        vertices.push_back(0.0f);
        angle += angle_increment;
    }

    unsigned int VBO, VAO;
    glGenVertexArrays(1, &VAO);
    glGenBuffers(1, &VBO);

    glBindVertexArray(VAO);

    glBindBuffer(GL_ARRAY_BUFFER, VBO);
    glBufferData(GL_ARRAY_BUFFER, vertices.size() * sizeof(float), &vertices[0], GL_STATIC_DRAW);

    glVertexAttribPointer(0, 3, GL_FLOAT, GL_FALSE, 3 * sizeof(float), nullptr);
    glEnableVertexAttribArray(0);

    // texture coord attribute
    glBindBuffer(GL_ARRAY_BUFFER, 0);
    glBindVertexArray(0);


    ourShader.use(); // don't forget to activate/use the shader before setting

    // render loop
    // -----------
    while (!glfwWindowShouldClose(window)) {
        // input
        // -----
        processInput(window);

        // render
        // ------
        glClearColor(0.2f, 0.3f, 0.3f, 1.0f);
        glClear(GL_COLOR_BUFFER_BIT);


        ourShader.use();

        unsigned int transformLoc = glGetUniformLocation(ourShader.ID, "transform");
        glUniformMatrix4fv(transformLoc, 1, GL_FALSE, glm::value_ptr(transform));

        // render container
        glBindVertexArray(VAO);
        glDrawArrays(GL_TRIANGLE_FAN, 0, vertices.size());


        // glfw: swap buffers and poll IO events (keys pressed/released, mouse moved
        // etc.)
        // -------------------------------------------------------------------------------
        glfwSwapBuffers(window);
        glfwPollEvents();
    }

    // optional: de-allocate all resources once they've outlived their purpose:
    // ------------------------------------------------------------------------
    glDeleteVertexArrays(1, &VAO);
    glDeleteBuffers(1, &VBO);

    // glfw: terminate, clearing all previously allocated GLFW resources.
    // ------------------------------------------------------------------
    glfwTerminate();
    return 0;
}

// process all input: query GLFW whether relevant keys are pressed/released this
// frame and react accordingly
// ---------------------------------------------------------------------------------------------------------
void processInput(GLFWwindow *window) {
    if (glfwGetKey(window, GLFW_KEY_ESCAPE) == GLFW_PRESS)
        glfwSetWindowShouldClose(window, true);
    if (glfwGetKey(window, GLFW_KEY_UP) == GLFW_PRESS) {
        cordY += 0.001f;
        transform = glm::mat4(1.0f);
        transform = glm::scale(transform, glm::vec3(scale, scale, scale));
        transform = glm::translate(transform, glm::vec3(cordX, cordY, 0.0f));
        transform = glm::rotate(transform, HALF_PI, glm::vec3(0.0f, 0.0f, 1.0f));
    }
    if (glfwGetKey(window, GLFW_KEY_DOWN) == GLFW_PRESS) {
        cordY -= 0.001f;
        transform = glm::mat4(1.0f);
        transform = glm::scale(transform, glm::vec3(scale, scale, scale));
        transform = glm::translate(transform, glm::vec3(cordX, cordY, 0.0f));
        transform = glm::rotate(transform, HALF_PI * 3, glm::vec3(0.0f, 0.0f, 1.0f));
    }
    if (glfwGetKey(window, GLFW_KEY_RIGHT) == GLFW_PRESS) {
        cordX += 0.001f;
        transform = glm::mat4(1.0f);
        transform = glm::scale(transform, glm::vec3(scale, scale, scale));
        transform = glm::translate(transform, glm::vec3(cordX, cordY, 0.0f));
    }
    if (glfwGetKey(window, GLFW_KEY_LEFT) == GLFW_PRESS) {
        cordX -= 0.001f;
        transform = glm::mat4(1.0f);
        transform = glm::scale(transform, glm::vec3(scale, scale, scale));
        transform = glm::translate(transform, glm::vec3(cordX, cordY, 0.0f));
        transform = glm::rotate(transform, HALF_PI * 2, glm::vec3(0.0f, 0.0f, 1.0f));
    }
    if (glfwGetKey(window, GLFW_KEY_1) == GLFW_PRESS) {
        scale = 0.1f;
    }
    if (glfwGetKey(window, GLFW_KEY_2) == GLFW_PRESS) {
        scale = 0.25f;
    }
    if (glfwGetKey(window, GLFW_KEY_3) == GLFW_PRESS) {
        scale = 0.40f;
    }
    if (glfwGetKey(window, GLFW_KEY_4) == GLFW_PRESS) {
        scale = 0.70f;
    }
}

// glfw: whenever the window size changed (by OS or user resize) this callback
// function executes
// ---------------------------------------------------------------------------------------------
void framebuffer_size_callback(GLFWwindow *window, int width, int height) {
    // make sure the viewport matches the new window dimensions; note that width
    // and height will be significantly larger than specified on retina displays.
    glViewport(0, 0, width, height);
}

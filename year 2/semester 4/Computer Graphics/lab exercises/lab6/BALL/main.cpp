#include <OpenGLPrj.hpp>

#include <GLFW/glfw3.h>

#include <Shader.hpp>

#include <iostream>
#include <string>
#include <vector>

const std::string program_name = ("FINKI 3D");

void framebuffer_size_callback(GLFWwindow *window, int width, int height);

void processInput(GLFWwindow *window);

// settings
const unsigned int SCR_WIDTH = 800;
const unsigned int SCR_HEIGHT = 800;

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

    // set up vertex data (and buffer(s)) and configure vertex attributes
    // ------------------------------------------------------------------
    std::vector<float> vertices;

    float const TWO_PI = glm::two_pi<float>();
    float const PI = glm::pi<float>();
    float const HALF_PI = glm::half_pi<float>();

    float radius = 0.7f;


    int const NUMBER_OF_PHI_ANGLES = 32;
    int const NUMBER_OF_THETA_ANGLES = 32;
    float phi = 0.0f;
    float theta = -HALF_PI;

    float phi_increment = TWO_PI / NUMBER_OF_PHI_ANGLES;
    float theta_increment =  PI / NUMBER_OF_THETA_ANGLES;

    //front
    for (auto i = 0; i < NUMBER_OF_THETA_ANGLES; ++i) {
        phi = 0.0f;
        for (int j = 0; j < NUMBER_OF_PHI_ANGLES; j++) {
            vertices.push_back(radius * glm::cos(theta) * glm::cos(phi));
            vertices.push_back(radius * glm::cos(theta) * glm::sin(phi));
            vertices.push_back(radius * glm::sin(theta));

            vertices.push_back(radius * glm::cos(theta + theta_increment) * glm::cos(phi));
            vertices.push_back(radius * glm::cos(theta + theta_increment) * glm::sin(phi));
            vertices.push_back(radius * glm::sin(theta + theta_increment));

            phi += phi_increment;
        }
        theta += theta_increment;
    }


////   I
////        x        y           z
//    vertices.push_back(-0.9f);vertices.push_back(-0.7f);vertices.push_back(-0.1f); //000
//    vertices.push_back(-0.9f);vertices.push_back(-0.7f);vertices.push_back(0.1f); //001
//    vertices.push_back(-0.6f);vertices.push_back(-0.7f);vertices.push_back(-0.1f); //100
//    vertices.push_back(-0.6f);vertices.push_back(-0.7f);vertices.push_back(0.1f); //101
//    vertices.push_back(-0.6f);vertices.push_back(0.7f);vertices.push_back(0.1f); //111
//    vertices.push_back(-0.9f);vertices.push_back(-0.7f);vertices.push_back(0.1f); //001
//    vertices.push_back(-0.9f);vertices.push_back(0.7f);vertices.push_back(0.1f); //011
//    vertices.push_back(-0.9f);vertices.push_back(-0.7f);vertices.push_back(-0.1f); //000
//    vertices.push_back(-0.9f);vertices.push_back(0.7f);vertices.push_back(-0.1f); //010
//    vertices.push_back(-0.6f);vertices.push_back(-0.7f);vertices.push_back(-0.1f); //100
//    vertices.push_back(-0.6f);vertices.push_back(0.7f);vertices.push_back(-0.1f); //110
//    vertices.push_back(-0.6f);vertices.push_back(0.7f);vertices.push_back(0.1f); //111
//    vertices.push_back(-0.9f);vertices.push_back(0.7f);vertices.push_back(-0.1f); //010
//    vertices.push_back(-0.9f);vertices.push_back(0.7f);vertices.push_back(0.1f); //011

    unsigned int VBO, VAO, EBO;
    glGenVertexArrays(1, &VAO);
    glGenBuffers(1, &VBO);

    glBindVertexArray(VAO);

    glBindBuffer(GL_ARRAY_BUFFER, VBO);
//    glBufferData(GL_ARRAY_BUFFER, sizeof(vertices), vertices, GL_STATIC_DRAW);
    glBufferData(GL_ARRAY_BUFFER, vertices.size() * sizeof(float), &vertices[0], GL_STATIC_DRAW);

    // position attribute
    glVertexAttribPointer(0, 3, GL_FLOAT, GL_FALSE, 3 * sizeof(float), static_cast<void *>(nullptr));
    glEnableVertexAttribArray(0);

    ourShader.use(); // don't forget to activate/use the shader before setting

    glEnable(GL_DEPTH_TEST);

    // render loop
    // -----------
    while (!glfwWindowShouldClose(window)) {
        processInput(window);
        // render
        // ------
        glClearColor(0.2f, 0.3f, 0.3f, 1.0f);
        glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);

        // activate shader
        ourShader.use();

        // create transformations
        glm::mat4 model = glm::mat4(1.0f);
        glm::mat4 view = glm::mat4(1.0f);
        glm::mat4 projection = glm::mat4(1.0f);
        model = model =
                glm::rotate(model, (float) glfwGetTime() * glm::radians(50.0f),
                            glm::vec3(0.5f, 1.0f, 0.0f));
        view = glm::translate(view, glm::vec3(0.0f, 0.0f, -3.0f));
        projection =
                glm::perspective(glm::radians(45.0f),
                                 (float) SCR_WIDTH / (float) SCR_HEIGHT, 0.1f, 100.0f);
        // retrieve the matrix uniform locations
        unsigned int modelLoc = glGetUniformLocation(ourShader.ID, "model");
        unsigned int viewLoc = glGetUniformLocation(ourShader.ID, "view");
        unsigned int colorLoc = glGetUniformLocation(ourShader.ID, "ourColor");
        // pass them to the shaders (3 different ways)
        glUniformMatrix4fv(modelLoc, 1, GL_FALSE, glm::value_ptr(model));
        glUniformMatrix4fv(viewLoc, 1, GL_FALSE, &view[0][0]);
        // note: currently we set the projection matrix each frame, but since the
        // projection matrix rarely changes it's often best practice to set it
        // outside the main loop only once.
        ourShader.setMat4("projection", projection);

        // render container
        glBindVertexArray(VAO);
        glUniform4f(colorLoc, 0.2f, 0.6f, 0.8f, 1.0f);
        glDrawArrays(GL_TRIANGLE_STRIP, 0, (2*NUMBER_OF_THETA_ANGLES*NUMBER_OF_PHI_ANGLES));
//        glDrawArrays(GL_TRIANGLE_STRIP, 0, (1150));




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
    glDeleteBuffers(1, &EBO);

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
}

// glfw: whenever the window size changed (by OS or user resize) this callback
// function executes
// ---------------------------------------------------------------------------------------------
void framebuffer_size_callback(GLFWwindow *window, int width, int height) {
    // make sure the viewport matches the new window dimensions; note that width
    // and height will be significantly larger than specified on retina displays.
    glViewport(0, 0, width, height);
}

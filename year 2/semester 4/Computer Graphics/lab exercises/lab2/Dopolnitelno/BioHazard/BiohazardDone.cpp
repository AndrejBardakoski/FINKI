#include <glad/glad.h>
#include <GLFW/glfw3.h>
#include <glm/gtc/constants.hpp>
#include <glm/trigonometric.hpp>
#include <vector>
#include <iostream>


void framebuffer_size_callback(GLFWwindow *window, int width, int height);

void processInput(GLFWwindow *window);

// settings
const unsigned int SCR_WIDTH = 600;
const unsigned int SCR_HEIGHT = 600;

static const char *vertexShaderSource = "#version 330 core\n"
                                        "layout (location = 0) in vec3 aPos;\n"
                                        "void main()\n"
                                        "{\n"
                                        "   gl_Position = vec4(aPos.x, aPos.y, aPos.z, 1.0);\n"
                                        "}\0";
static const char *fragmentShaderSource = "#version 330 core\n"
                                          "out vec4 FragColor;\n"
                                          "void main()\n"
                                          "{\n"
                                          "   FragColor = vec4(0.0f, 0.0f, 0.0f, 1.0f);\n"
                                          "}\n\0";
static const char *fragmentShaderSource2 = "#version 330 core\n"
                                           "out vec4 FragColor;\n"
                                           "void main()\n"
                                           "{\n"
                                           "   FragColor = vec4(0.9f, 0.75f, 0.15f, 1.0f);\n"
                                           "}\n\0";

int main() {
    // glfw: initialize and configure
    // ------------------------------
    glfwInit();
    glfwWindowHint(GLFW_CONTEXT_VERSION_MAJOR, 3);
    glfwWindowHint(GLFW_CONTEXT_VERSION_MINOR, 3);
    glfwWindowHint(GLFW_OPENGL_PROFILE, GLFW_OPENGL_CORE_PROFILE);

#ifdef __APPLE__
    glfwWindowHint(GLFW_OPENGL_FORWARD_COMPAT, GL_TRUE); // uncomment this statement to fix compilation on OS X
#endif

    // glfw window creation
    // --------------------
    GLFWwindow *window = glfwCreateWindow(SCR_WIDTH, SCR_HEIGHT, "LearnOpenGL", nullptr, nullptr);
    if (window == nullptr) {
        std::cout << "Failed to create GLFW window" << std::endl;
        glfwTerminate();
        return -1;
    }
    glfwMakeContextCurrent(window);
    glfwSetFramebufferSizeCallback(window, framebuffer_size_callback);

    // glad: load all OpenGL function pointers
    // ---------------------------------------
    if (!gladLoadGLLoader(GLADloadproc(glfwGetProcAddress))) {
        std::cout << "Failed to initialize GLAD" << std::endl;
        return -1;
    }


    // build and compile our shader program
    // ------------------------------------
    // vertex shader
    GLuint vertexShader = glCreateShader(GL_VERTEX_SHADER);
    glShaderSource(vertexShader, 1, &vertexShaderSource, nullptr);
    glCompileShader(vertexShader);
    // check for shader compile errors
    int success;
    char infoLog[512];
    glGetShaderiv(vertexShader, GL_COMPILE_STATUS, &success);
    if (!success) {
        glGetShaderInfoLog(vertexShader, 512, nullptr, infoLog);
        std::cout << "ERROR::SHADER::VERTEX::COMPILATION_FAILED\n" << infoLog << std::endl;
    }
    // fragment shader
    GLuint fragmentShader = glCreateShader(GL_FRAGMENT_SHADER);
    glShaderSource(fragmentShader, 1, &fragmentShaderSource, nullptr);
    glCompileShader(fragmentShader);
    // check for shader compile errors
    glGetShaderiv(fragmentShader, GL_COMPILE_STATUS, &success);
    if (!success) {
        glGetShaderInfoLog(fragmentShader, 512, nullptr, infoLog);
        std::cout << "ERROR::SHADER::FRAGMENT::COMPILATION_FAILED\n" << infoLog << std::endl;
    }
    GLuint fragmentShader2 = glCreateShader(GL_FRAGMENT_SHADER);
    glShaderSource(fragmentShader2, 1, &fragmentShaderSource2, nullptr);
    glCompileShader(fragmentShader2);
    // check for shader compile errors
    glGetShaderiv(fragmentShader2, GL_COMPILE_STATUS, &success);
    if (!success) {
        glGetShaderInfoLog(fragmentShader2, 512, nullptr, infoLog);
        std::cout << "ERROR::SHADER::FRAGMENT::COMPILATION_FAILED\n" << infoLog << std::endl;
    }
    // link shaders
    GLuint shaderProgram = glCreateProgram();
    glAttachShader(shaderProgram, vertexShader);
    glAttachShader(shaderProgram, fragmentShader);
    glLinkProgram(shaderProgram);
    GLuint shaderProgram2 = glCreateProgram();
    glAttachShader(shaderProgram2, vertexShader);
    glAttachShader(shaderProgram2, fragmentShader2);
    glLinkProgram(shaderProgram2);
    // check for linking errors
    glGetProgramiv(shaderProgram2, GL_LINK_STATUS, &success);
    if (!success) {
        glGetProgramInfoLog(shaderProgram2, 512, nullptr, infoLog);
        std::cout << "ERROR::SHADER::PROGRAM::LINKING_FAILED\n" << infoLog << std::endl;
    }
    glDeleteShader(vertexShader);
    glDeleteShader(fragmentShader);
    glDeleteShader(fragmentShader2);

    // set up vertex data (and buffer(s)) and configure vertex attributes
    // ------------------------------------------------------------------

    std::vector<float> vertices;

    float const TWO_PI = glm::two_pi<float>();


    int const NUMBER_OF_ANGLES = 100;
    float angle = 0.0f;
    float radius_Big = 0.45f;
    float radius_Medium = radius_Big * 0.8;
    float radius_arc = 2 * radius_Big / 3;
    float radius_Small = radius_Medium / 3;
    float angle_increment = TWO_PI / NUMBER_OF_ANGLES;
//   CircleTopBlack
    //centerTop
    float xc, yc;
    xc = radius_Big * glm::cos(TWO_PI / 4);
    yc = radius_Big * glm::sin(TWO_PI / 4);
    vertices.push_back(xc);
    vertices.push_back(yc);
    vertices.push_back(0.0f);
    //RadiusVertices
    for (int i = 0; i <= NUMBER_OF_ANGLES; ++i) {
        vertices.push_back(xc + radius_Big * glm::cos(angle));
        vertices.push_back(yc + radius_Big * glm::sin(angle));
        vertices.push_back(0.0f);
        angle += angle_increment;
    }
//    CircleRightBlack
    angle = 0.0f;
    //centerRight
    xc = radius_Big * glm::cos(TWO_PI - TWO_PI / 12);
    yc = radius_Big * glm::sin(TWO_PI - TWO_PI / 12);
    vertices.push_back(xc);
    vertices.push_back(yc);
    vertices.push_back(0.0f);
    //RadiusVertices
    for (int i = 0; i <= NUMBER_OF_ANGLES; ++i) {
        vertices.push_back(xc + radius_Big * glm::cos(angle));
        vertices.push_back(yc + radius_Big * glm::sin(angle));
        vertices.push_back(0.0f);
        angle += angle_increment;
    }
//    CircleLeftBlack
    angle = 0.0f;
    //centerLeft
    xc = radius_Big * glm::cos(TWO_PI / 2 + TWO_PI / 12);
    yc = radius_Big * glm::sin(TWO_PI / 2 + TWO_PI / 12);
    vertices.push_back(xc);
    vertices.push_back(yc);
    vertices.push_back(0.0f);
    //RadiusVertices
    for (int i = 0; i <= NUMBER_OF_ANGLES; ++i) {
        vertices.push_back(xc + radius_Big * glm::cos(angle));
        vertices.push_back(yc + radius_Big * glm::sin(angle));
        vertices.push_back(0.0f);
        angle += angle_increment;
    }
//    CircleTopYellow
    angle = 0.0f;
    //centerTop
    xc = radius_Big * glm::cos(TWO_PI / 4) * radius_Big / radius_Medium;
    yc = radius_Big * glm::sin(TWO_PI / 4) * radius_Big / radius_Medium;
//    xc=0.0f;
//    yc=0.54f;
    vertices.push_back(xc);
    vertices.push_back(yc);
    vertices.push_back(0.0f);
    //RadiusVertices
    for (int i = 0; i <= NUMBER_OF_ANGLES; ++i) {
        vertices.push_back(xc + radius_Medium * glm::cos(angle));
        vertices.push_back(yc + radius_Medium * glm::sin(angle));
        vertices.push_back(0.0f);
        angle += angle_increment;
    }
//    CircleRightYellow
    angle = 0.0f;
    //centerRight
    xc = radius_Big * glm::cos(TWO_PI - TWO_PI / 12) * radius_Big / radius_Medium;
    yc = radius_Big * glm::sin(TWO_PI - TWO_PI / 12) * radius_Big / radius_Medium;
//    xc=0.4676f;
//    yc=-0.27f;
    vertices.push_back(xc);
    vertices.push_back(yc);
    vertices.push_back(0.0f);
    //RadiusVertices
    for (int i = 0; i <= NUMBER_OF_ANGLES; ++i) {
        vertices.push_back(xc + radius_Medium * glm::cos(angle));
        vertices.push_back(yc + radius_Medium * glm::sin(angle));
        vertices.push_back(0.0f);
        angle += angle_increment;
    }
//    CircleLeftYellow
    angle = 0.0f;
    //centerLeft
    xc = radius_Big * glm::cos(TWO_PI / 2 + TWO_PI / 12) * radius_Big / radius_Medium;
    yc = radius_Big * glm::sin(TWO_PI / 2 + TWO_PI / 12) * radius_Big / radius_Medium;
//    xc=-0.4676f;
//    yc=-0.27f;
    vertices.push_back(xc);
    vertices.push_back(yc);
    vertices.push_back(0.0f);
    //RadiusVertices
    for (int i = 0; i <= NUMBER_OF_ANGLES; ++i) {
        vertices.push_back(xc + radius_Medium * glm::cos(angle));
        vertices.push_back(yc + radius_Medium * glm::sin(angle));
        vertices.push_back(0.0f);
        angle += angle_increment;
    }
//    ArcMiddleBlack
    angle = 0.0f;
    for (int i = 0; i <= NUMBER_OF_ANGLES; ++i) {
        vertices.push_back(radius_Medium * glm::cos(angle));
        vertices.push_back(radius_Medium * glm::sin(angle));
        vertices.push_back(0.0f);

        vertices.push_back(radius_arc * glm::cos(angle));
        vertices.push_back(radius_arc * glm::sin(angle));
        vertices.push_back(0.0f);
        angle += angle_increment;
    }
//  middleCircleYellow
    angle = 0.0;
    xc = yc = 0.0f;
    vertices.push_back(xc);
    vertices.push_back(yc);
    vertices.push_back(0.0f);
    for (int i = 0; i <= NUMBER_OF_ANGLES; ++i) {
        vertices.push_back(radius_Small * glm::cos(angle));
        vertices.push_back(radius_Small * glm::sin(angle));
        vertices.push_back(0.0f);
        angle += angle_increment;
    }
//  rectangle Top
    vertices.push_back(0.05f);
    vertices.push_back(0.25f);
    vertices.push_back(0.0f);

    vertices.push_back(-0.05f);
    vertices.push_back(0.25f);
    vertices.push_back(0.0f);

    vertices.push_back(-0.05f);
    vertices.push_back(0.0f);
    vertices.push_back(0.0f);

    vertices.push_back(0.05f);
    vertices.push_back(0.0f);
    vertices.push_back(0.0f);

//  rectangle Right
    vertices.push_back(0.0366f);
    vertices.push_back(0.05f);
    vertices.push_back(0.0f);

    vertices.push_back(0.0366f);
    vertices.push_back(-0.05f);
    vertices.push_back(0.0f);

    vertices.push_back(0.206f);
    vertices.push_back(-0.15f);
    vertices.push_back(0.0f);

    vertices.push_back(0.206f);
    vertices.push_back(-0.05f);
    vertices.push_back(0.0f);


//   rectangle Left
    vertices.push_back(-0.206f);
    vertices.push_back(-0.05f);
    vertices.push_back(0.0f);

    vertices.push_back(-0.206f);
    vertices.push_back(-0.15f);
    vertices.push_back(0.0f);

    vertices.push_back(-0.0366f);
    vertices.push_back(-0.05f);
    vertices.push_back(0.0f);

    vertices.push_back(-0.0366f);
    vertices.push_back(0.05f);
    vertices.push_back(0.0f);

    unsigned int VBO, VAO;
    glGenVertexArrays(1, &VAO);
    glGenBuffers(1, &VBO);
    // bind the Vertex Array Object first, then bind and set vertex buffer(s), and then configure vertex attributes(s).
    glBindVertexArray(VAO);

    glBindBuffer(GL_ARRAY_BUFFER, VBO);
    glBufferData(GL_ARRAY_BUFFER, vertices.size() * sizeof(float), &vertices[0], GL_STATIC_DRAW);
    //glBufferData(GL_ARRAY_BUFFER, sizeof(vertices_a), vertices_a, GL_STATIC_DRAW);

    glVertexAttribPointer(0, 3, GL_FLOAT, GL_FALSE, 3 * sizeof(float), nullptr);
    glEnableVertexAttribArray(0);

    // note that this is allowed, the call to glVertexAttribPointer registered VBO as the vertex attribute's bound vertex buffer object so afterwards we can safely unbind
    glBindBuffer(GL_ARRAY_BUFFER, 0);

    // You can unbind the VAO afterwards so other VAO calls won't accidentally modify this VAO, but this rarely happens. Modifying other
    // VAOs requires a call to glBindVertexArray anyways so we generally don't unbind VAOs (nor VBOs) when it's not directly necessary.
    glBindVertexArray(0);


    // uncomment this call to draw in wireframe polygons.
    //glPolygonMode(GL_FRONT_AND_BACK, GL_LINE);

    // render loop
    // -----------
    while (!glfwWindowShouldClose(window)) {
        // input
        // -----
        processInput(window);

        // render
        // ------
        glClearColor(0.9f, 0.75f, 0.15f, 1.0f);
        glClear(GL_COLOR_BUFFER_BIT);


        glUseProgram(shaderProgram);
        glBindVertexArray(
                VAO); // seeing as we only have a single VAO there's no need to bind it every time, but we'll do so to keep things a bit more organized
        for (int i = 0; i < 3; i++) {
            glDrawArrays(GL_TRIANGLE_FAN, i * (NUMBER_OF_ANGLES + 2), NUMBER_OF_ANGLES + 2);

        }
        glUseProgram(shaderProgram2);
        for (int i = 3; i < 6; i++) {
            glDrawArrays(GL_TRIANGLE_FAN, i * (NUMBER_OF_ANGLES + 2), NUMBER_OF_ANGLES + 2);
        }
        glUseProgram(shaderProgram);
        glDrawArrays(GL_TRIANGLE_STRIP, 6 * (NUMBER_OF_ANGLES + 2), 2 * NUMBER_OF_ANGLES + 2);

        glUseProgram(shaderProgram2);
        glDrawArrays(GL_TRIANGLE_FAN, 8 * (NUMBER_OF_ANGLES + 2) - 2, NUMBER_OF_ANGLES + 2);

        glDrawArrays(GL_TRIANGLE_FAN, 9 * (NUMBER_OF_ANGLES + 2) - 2, 4);
        glDrawArrays(GL_TRIANGLE_FAN, 9 * (NUMBER_OF_ANGLES + 2) + 2, 4);
        glDrawArrays(GL_TRIANGLE_FAN, 9 * (NUMBER_OF_ANGLES + 2) + 6, 4);

        // glBindVertexArray(0); // no need to unbind it every time

        // glfw: swap buffers and poll IO events (keys pressed/released, mouse moved etc.)
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

// process all input: query GLFW whether relevant keys are pressed/released this frame and react accordingly
// ---------------------------------------------------------------------------------------------------------
void processInput(GLFWwindow *window) {
    if (glfwGetKey(window, GLFW_KEY_ESCAPE) == GLFW_PRESS)
        glfwSetWindowShouldClose(window, true);
}

// glfw: whenever the window size changed (by OS or user resize) this callback function executes
// ---------------------------------------------------------------------------------------------
void framebuffer_size_callback(GLFWwindow *window, int width, int height) {
    // make sure the viewport matches the new window dimensions; note that width and
    // height will be significantly larger than specified on retina displays.
    glViewport(0, 0, width, height);
}


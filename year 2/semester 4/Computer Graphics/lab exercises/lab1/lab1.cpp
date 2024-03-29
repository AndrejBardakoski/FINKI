#include <glad/glad.h>
#include <GLFW/glfw3.h>

#include <iostream>

void framebuffer_size_callback(GLFWwindow *window, int width, int height);

void processInput(GLFWwindow *window);

// settings
const unsigned int SCR_WIDTH = 800;
const unsigned int SCR_HEIGHT = 600;

static const char *vertexShaderSource = "#version 330 core\n"
                                        "layout (location = 0) in vec3 aPos;\n"
                                        "void main()\n"
                                        "{\n"
                                        "   gl_Position = vec4(aPos.x, aPos.y, aPos.z, 1.0);\n"
                                        "}\0";
static const char *fragmentShaderSourceBase = "#version 330 core\n"
                                              "out vec4 FragColor;\n"
                                              "void main()\n"
                                              "{\n"
                                              "   FragColor = vec4(0.3f, 0.5f, 0.1f, 1.0f);\n"
                                              "}\n\0";
static const char *fragmentShaderSourceRoof = "#version 330 core\n"
                                              "out vec4 FragColor;\n"
                                              "void main()\n"
                                              "{\n"
                                              "   FragColor = vec4(1.0f, 0.2f, 0.3f, 1.0f);\n"
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
    // fragment shader base
    GLuint fragmentShaderBase = glCreateShader(GL_FRAGMENT_SHADER);
    glShaderSource(fragmentShaderBase, 1, &fragmentShaderSourceBase, nullptr);
    glCompileShader(fragmentShaderBase);
    // check for shader compile errors
    glGetShaderiv(fragmentShaderBase, GL_COMPILE_STATUS, &success);
    if (!success) {
        glGetShaderInfoLog(fragmentShaderBase, 512, nullptr, infoLog);
        std::cout << "ERROR::SHADER::FRAGMENT::COMPILATION_FAILED\n" << infoLog << std::endl;
    }

// fragment shader roof
    GLuint fragmentShaderRoof = glCreateShader(GL_FRAGMENT_SHADER);
    glShaderSource(fragmentShaderRoof, 1, &fragmentShaderSourceRoof, nullptr);
    glCompileShader(fragmentShaderRoof);
    // check for shader compile errors
    glGetShaderiv(fragmentShaderRoof, GL_COMPILE_STATUS, &success);
    if (!success) {
        glGetShaderInfoLog(fragmentShaderRoof, 512, nullptr, infoLog);
        std::cout << "ERROR::SHADER::FRAGMENT::COMPILATION_FAILED\n" << infoLog << std::endl;
    }
    // link shaders
    GLuint shaderProgram = glCreateProgram();
    glAttachShader(shaderProgram, vertexShader);
    glAttachShader(shaderProgram, fragmentShaderBase);
    glLinkProgram(shaderProgram);
    // check for linking errors
    glGetProgramiv(shaderProgram, GL_LINK_STATUS, &success);
    if (!success) {
        glGetProgramInfoLog(shaderProgram, 512, nullptr, infoLog);
        std::cout << "ERROR::SHADER::PROGRAM::LINKING_FAILED\n" << infoLog << std::endl;
    }
    glDeleteShader(fragmentShaderBase);

    // link shaders
    GLuint shaderProgramRoof = glCreateProgram();
    glAttachShader(shaderProgramRoof, vertexShader);
    glAttachShader(shaderProgramRoof, fragmentShaderRoof);
    glLinkProgram(shaderProgramRoof);
    // check for linking errors
    glGetProgramiv(shaderProgramRoof, GL_LINK_STATUS, &success);
    if (!success) {
        glGetProgramInfoLog(shaderProgramRoof, 512, nullptr, infoLog);
        std::cout << "ERROR::SHADER::PROGRAM::LINKING_FAILED\n" << infoLog << std::endl;
    }
    glDeleteShader(vertexShader);
    glDeleteShader(fragmentShaderRoof);

    // set up vertex data (and buffer(s)) and configure vertex attributes
    // ------------------------------------------------------------------
//    float vertices[] = {
//            0.0f, 0.0f, 0.0f,  // top cent
//            0.0f, -0.8f, 0.0f,  // bottom cent
//            -0.8f, -0.8f, 0.0f,  // bottom left
//            -0.8f, 0.0f, 0.0f,   // top left
//
//            0.9f, 0.3f, 0.0f,   // top right
//            0.9f, -0.5f, 0.0f,   // bottom right
//
//            -0.4f, 0.3f, 0.0f,//roof top left
//            0.5f, 0.6f, 0.0f//roof top right
//    };
    float vertices[] = {
            0.9f, 0.3f, 0.0f,   // top right
            0.9f, -0.5f, 0.0f,   // bottom right
            0.0f, 0.0f, 0.0f,  // top cent
            0.0f, -0.8f, 0.0f,  // bottom cent
            -0.8f, 0.0f, 0.0f,   // top left
            -0.8f, -0.8f, 0.0f,  // bottom left

            0.0f, 0.0f, 0.0f,  // top cent
            -0.8f, 0.0f, 0.0f,   // top left
            -0.4f, 0.5f, 0.0f,//roof top left
            0.5f, 0.8f, 0.0f,//roof top right
            0.9f, 0.3f, 0.0f   // top right

    };
//    unsigned int indices[] = {  // note that we start from 0!
//            0, 1, 3,  // first Triangle base front
//            1, 2, 3,   // second Triangle base front
//
//            0, 4, 5,  // first Triangle base side
//            5, 1, 0, // second Triangle base side
//
//            0, 3, 6, // Triangle roof front
//
//            0, 6, 7, // first Triangle roof side
//            7, 4, 0 // second Triangle roof side
//    };
    unsigned int VBO, VAO, EBO;
    glGenVertexArrays(1, &VAO);
    glGenBuffers(1, &VBO);
//    glGenBuffers(1, &EBO);
    // bind the Vertex Array Object first, then bind and set vertex buffer(s), and then configure vertex attributes(s).
    glBindVertexArray(VAO);

    glBindBuffer(GL_ARRAY_BUFFER, VBO);
    glBufferData(GL_ARRAY_BUFFER, sizeof(vertices), vertices, GL_STATIC_DRAW);

//    glBindBuffer(GL_ELEMENT_ARRAY_BUFFER, EBO);
//    glBufferData(GL_ELEMENT_ARRAY_BUFFER, sizeof(indices), indices, GL_STATIC_DRAW);

    glVertexAttribPointer(0, 3, GL_FLOAT, GL_FALSE, 3 * sizeof(float), nullptr);
    glEnableVertexAttribArray(0);

    // note that this is allowed, the call to glVertexAttribPointer registered VBO as the vertex attribute's bound vertex buffer object so afterwards we can safely unbind
    glBindBuffer(GL_ARRAY_BUFFER, 0);

    // remember: do NOT unbind the EBO while a VAO is active as the bound element buffer object IS stored in the VAO; keep the EBO bound.
    //glBindBuffer(GL_ELEMENT_ARRAY_BUFFER, 0);

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
        glClearColor(0.2f, 0.3f, 0.3f, 1.0f);
        glClear(GL_COLOR_BUFFER_BIT);

        glUseProgram(shaderProgram);
        glBindVertexArray(VAO);

        glDrawArrays(GL_TRIANGLE_STRIP, 0, 6);
//        glDrawElements(GL_TRIANGLES, 12, GL_UNSIGNED_INT, nullptr);
        // glBindVertexArray(0); // no need to unbind it every time
        glUseProgram(shaderProgramRoof);
        glDrawArrays(GL_TRIANGLE_FAN, 6, 5);
//        glDrawElements(GL_TRIANGLES, 9, GL_UNSIGNED_INT, reinterpret_cast<void*>(12 * sizeof(float)) );

        // glfw: swap buffers and poll IO events (keys pressed/released, mouse moved etc.)
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

// process all input: query GLFW whether relevant keys are pressed/released this frame and react accordingly
// ---------------------------------------------------------------------------------------------------------
void processInput(GLFWwindow *window) {
    if (glfwGetKey(window, GLFW_KEY_ESCAPE) == GLFW_PRESS)
        glfwSetWindowShouldClose(window, true);
    if (glfwGetKey(window, GLFW_KEY_1) == GLFW_PRESS)
        glPolygonMode(GL_FRONT_AND_BACK, GL_POINT);
    if (glfwGetKey(window, GLFW_KEY_2) == GLFW_PRESS)
        glPolygonMode(GL_FRONT_AND_BACK, GL_LINE);
    if (glfwGetKey(window, GLFW_KEY_3) == GLFW_PRESS)
        glPolygonMode(GL_FRONT_AND_BACK, GL_FILL);
    //glfwSetWindowShouldClose(window, true);
}

// glfw: whenever the window size changed (by OS or user resize) this callback function executes
// ---------------------------------------------------------------------------------------------
void framebuffer_size_callback(GLFWwindow *window, int width, int height) {
    // make sure the viewport matches the new window dimensions; note that width and
    // height will be significantly larger than specified on retina displays.
    glViewport(0, 0, width, height);
}

package mk.finki.ukim.mk.lab;

import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.test.context.ActiveProfiles;
import org.springframework.test.web.servlet.MockMvc;
import org.springframework.test.web.servlet.request.MockHttpServletRequestBuilder;
import org.springframework.test.web.servlet.request.MockMvcRequestBuilders;
import org.springframework.test.web.servlet.result.MockMvcResultHandlers;
import org.springframework.test.web.servlet.result.MockMvcResultMatchers;
import org.springframework.test.web.servlet.setup.MockMvcBuilders;
import org.springframework.web.context.WebApplicationContext;

@ActiveProfiles("test")
@SpringBootTest(webEnvironment = SpringBootTest.WebEnvironment.DEFINED_PORT)
class LabApplicationTests {

    MockMvc mockMvc;

//    private static Category c1;
//    private static Manufacturer m1;
//    private static boolean dataInitialized = false;

    @BeforeEach
    public void setup(WebApplicationContext wac) {
        this.mockMvc = MockMvcBuilders.webAppContextSetup(wac).build();
//        initData();
    }

//    private void initData() {
//        if (!dataInitialized) {
//            c1 = categoryService.create("c1", "c1");
//            categoryService.create("c2", "c2");
//
//            m1 = manufacturerService.save("m1", "m1").get();
//            manufacturerService.save("m2", "m2");
//
//            String user = "user";
//            String admin = "admin";
//
//            userService.register(user, user, user, user, user, Role.ROLE_USER);
//            userService.register(admin, admin, admin, admin, admin, Role.ROLE_ADMIN);
//            dataInitialized = true;
//        }
//    }


    @Test
    void contextLoads() {
    }

    @Test
    public void testGetBalloons() throws Exception {
        MockHttpServletRequestBuilder BallonsRequest = MockMvcRequestBuilders.get("/balloons");
        this.mockMvc.perform(BallonsRequest)
                .andDo(MockMvcResultHandlers.print())
                .andExpect(MockMvcResultMatchers.status().isOk())
                .andExpect(MockMvcResultMatchers.model().attributeExists("balloons"))
                .andExpect(MockMvcResultMatchers.view().name("listBalloons"));
    }

}

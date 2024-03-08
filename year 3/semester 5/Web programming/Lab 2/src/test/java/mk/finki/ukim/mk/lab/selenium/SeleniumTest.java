package mk.finki.ukim.mk.lab.selenium;

import mk.finki.ukim.mk.lab.model.Balloon;
import mk.finki.ukim.mk.lab.model.Manufacturer;
import mk.finki.ukim.mk.lab.service.BalloonService;
import mk.finki.ukim.mk.lab.service.ManufacturerService;
import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;
import org.openqa.selenium.htmlunit.HtmlUnitDriver;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.test.context.ActiveProfiles;

@ActiveProfiles("test")
@SpringBootTest(webEnvironment = SpringBootTest.WebEnvironment.DEFINED_PORT)
public class SeleniumTest {

    private HtmlUnitDriver driver;

    @Autowired
    BalloonService balloonService;

    @Autowired
    ManufacturerService manufacturerService;

    private static Balloon b1;
    private static Balloon b2;
    private static Balloon b3;
    private static Manufacturer m1;
    private static Manufacturer m2;

    private static String admin = "admin";

    private static boolean dataInitialized = false;


    @BeforeEach
    private void setup() {
        this.driver = new HtmlUnitDriver(true);
        initData();
    }

    @AfterEach
    public void destroy() {
        if (this.driver != null) {
            this.driver.close();
        }
    }


    private void initData() {
        if (!dataInitialized) {

            m1 = manufacturerService.save("m1", "China","m1m1");
            m2 = manufacturerService.save("m2","USA","m2m2");

            b1 = balloonService.save(1L, "b1","b1b1", m2.getId());
            b2 = balloonService.save(10L, "b2","b22", m1.getId());
            b3 = balloonService.save(3L, "b3","b3b3", m1.getId());
            dataInitialized = true;
        }
    }

    @Test
    public void testScenario() throws Exception {
        BalloonsPage balloonsPage = BalloonsPage.to(this.driver);
        balloonsPage.assertElemts(3, 0, 0, 0);
//        balloonsPage.assertElemts(0, 0, 0, 0);
        LoginPage loginPage = LoginPage.openLogin(this.driver);

        balloonsPage = LoginPage.doLogin(this.driver, loginPage, admin, admin);
//        balloonsPage.assertElemts(0, 0, 0, 1);
        balloonsPage.assertElemts(3, 3, 3, 1);



    }


}

package mk.finki.ukim.mk.lab.selenium;

import lombok.Getter;
import org.junit.Assert;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.FindBy;
import org.openqa.selenium.support.PageFactory;

import java.util.List;

@Getter
public class BalloonsPage extends AbstractPage{

    @FindBy(css = ".balloon-row")
    private List<WebElement> balloons;


    @FindBy(css = ".delete-balloon")
    private List<WebElement> deleteButtons;


    @FindBy(className = "edit-balloon")
    private List<WebElement> editButtons;


    @FindBy(css = ".addButton")
    private List<WebElement> addButton;


    public BalloonsPage(WebDriver driver) {
        super(driver);
    }

    public static BalloonsPage to(WebDriver driver) {
        get(driver, "/balloons");
        System.out.println(driver.getCurrentUrl());
        return PageFactory.initElements(driver, BalloonsPage.class);
    }

    public void assertElemts(int productsNumber, int deleteButtons, int editButtons, int addButton) {
        Assert.assertEquals("rows do not match", productsNumber, this.getBalloons().size());
        Assert.assertEquals("delete do not match", deleteButtons, this.getDeleteButtons().size());
        Assert.assertEquals("edit do not match", editButtons, this.getEditButtons().size());
        Assert.assertEquals("add is visible", addButton, this.getAddButton().size());
    }
}





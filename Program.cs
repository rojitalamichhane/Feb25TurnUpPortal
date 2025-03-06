// See https://aka.ms/new-console-template for more information
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TAProgramme.pages;

public class Program
{
    private static void Main(String[] args)
    {
        // Open Chrome Driver
        IWebDriver driver = new ChromeDriver();

        //login page object initialization and definition

        LoginPage loginPageObj = new LoginPage();
        loginPageObj.LoginActions(driver);
 
        //home page object initialization and definition
         
        HomePage homePageObj = new HomePage();
        homePageObj.NavigateToTMPage(driver);

         //Time and material object initialization and definition

        TMPage TMPageObj = new TMPage();
        TMPageObj.CreateTimeAndRecord(driver);
         
        //Edit Time and material object initialization and defintion
        TMPageObj.EditTimeAndRecord(driver);

         //Delete Time and material object initialization and defintion
        TMPageObj.DeleteTimeAndRecord(driver);

}

}


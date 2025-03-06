using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAProgramme.Utilities;
using TAProgramme.pages;
using OpenQA.Selenium.Chrome;

namespace TAProgramme.Tests
{
    [TestFixture]
    public class TM_Tests:CommonDriver
    {
        [SetUp]
        public void SetUpSteps(){

            driver = new ChromeDriver();

            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);
 
        //home page object initialization and definition
         
            HomePage homePageObj = new HomePage();
            homePageObj.NavigateToTMPage(driver);
        }

        [Test]
        public void CreateTime_Test(){
            TMPage TMPageObj = new TMPage();
            TMPageObj.CreateTimeAndRecord(driver);

        }
        [Test]
        public void EditTime_Test(){
            TMPage TMPageObj = new TMPage();
            TMPageObj.EditTimeAndRecord(driver);


        }

        [Test]

        public void DeleteTim_Test(){
            TMPage TMPageObj = new TMPage();
            TMPageObj.DeleteTimeAndRecord(driver);
        }

        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
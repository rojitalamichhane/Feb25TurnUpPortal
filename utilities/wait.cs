using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;




namespace TAProgramme.Utilities
{
    public class Wait
    {
        //Generic functions to wait for an element to be clickable
        public static void WaitToBeClickable(IWebDriver driver, String locatorType, String locatorValue, int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));

            if (locatorType == "XPath")
            {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
        }
        if (locatorType == "Id")
            {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorValue)));
        }
    }
    
    public static void WaitToBeVisible(IWebDriver driver, String locatorType, String locatorValue, int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));

            if (locatorType == "XPath")
            {
              wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
            }
        if (locatorType == "Id")
            {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorValue)));
        }
    }

    }
}

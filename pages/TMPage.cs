using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAProgramme.Utilities;

namespace TAProgramme.pages{
    public class TMPage
    {
        IWebDriver driver = new ChromeDriver();
        // Functions that allows user to perform Create Time and Record
        public void CreateTimeAndRecord(IWebDriver driver)
        {
         try{
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewButton.Click();
         }
         catch(Exception ex){
            Assert.Fail("create new button has not been found");
         }

        IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
        typeCodeDropdown.Click();
        Thread.Sleep(2000);

        IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
        timeOption.Click();

        //Type code into code text box
        IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
        codeTextBox.SendKeys("TA Programme");

        //Type code into Description text box
        IWebElement descriptionTextBox = driver.FindElement(By.Id("Description"));
        descriptionTextBox.SendKeys("This is a Description");

        //Type price into price textbox
        IWebElement priceTagOverlap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
        priceTagOverlap.Click();

        IWebElement priceTextBox = driver.FindElement(By.Id("Price"));
        priceTextBox.SendKeys("123");

        Wait.WaitToBeClickable(driver, "Id", "SaveButton", 5);

        //click on save button
        IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
        saveButton.Click();
        Thread.Sleep(3000);

        //Identify if time record has created successfully
        IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
        goToLastPageButton.Click();

        IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr/td[1]"));
      
        Assert.That(newCode.Text == "TA Programme", "New Time and Record has not been Created")
      //   if(newCode.Text == "abc")
      //   {
      //   Console.WriteLine("Time Record Created successfully");

      //        }

         }  

         //Edit Time And Record
    public void EditTimeAndRecord(IWebDriver driver)
      {
         Thread.Sleep(4000);
         //Select a record and click edit button
         IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
         lastPageButton.Click();

         IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr/td[5]/a[1]"));
         editButton.Click();

         //Edit Code Text
         IWebElement editCodeTextBox = driver.FindElement(By.Id("Code"));
         editCodeTextBox.Clear();
         editCodeTextBox.SendKeys("Edit TA Programme");

         //Click save
         IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
         saveButton.Click();
         Thread.Sleep(2000);

         //Navigating to the last record page
         IWebElement lastPageicon = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
         lastPageicon.Click();
         Thread.Sleep(2000);

         IWebElement editedCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
                  

         if (editedCode.Text == "Edit TA Programme")
            {
             Console.WriteLine("Time and record edited successfully");

            }
             else{
                 Console.WriteLine("New record and time has not edited");
                     }
                     Thread.Sleep(1500);
                  
                  }
                  
         public void DeleteTimeAndRecord(IWebDriver driver)
         {
            Thread.Sleep(4000);
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastPageButton.Click();
            Thread.Sleep(3000);

            //Delete Time and Record
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr/td[5]/a[2]"));
            deleteButton.Click();

            //click Ok to Delete
            driver.SwitchTo().Alert().Accept();

            Thread.Sleep(3000);

            driver.Navigate().Refresh();

            Thread.Sleep(4000);

            //check if the record is deleted
            IWebElement llastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            llastPageButton.Click();

            IWebElement deletedCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            
            if(deletedCode.Text != "Edit TA Programme")
            {
               Console.WriteLine("Record deleted successfully");
            }
            else
              {
               Console.WriteLine("Record Has not been deleted");
              }
            }
         }
      }
      

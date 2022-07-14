using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    class Demo
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void NavigateLogInGmail()
        {
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.google.co.in/";            
            //FuzzBuzzLogic();
            System.Threading.Thread.Sleep(2000);

            //click on Gmail link
            driver.FindElement(By.XPath("//a[text()='Gmail']")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//a[text()='Sign in']")).Click();
            System.Threading.Thread.Sleep(2000);
            IWebElement nameInput = driver.FindElement(By.XPath("//input[@name='identifier']"));
            if (nameInput.Displayed)
            {
                nameInput.SendKeys("test@gmail.com");
            }

            //click on next button
            driver.FindElement(By.XPath("//span[text()='Next']/..")).Click();
            System.Threading.Thread.Sleep(2000);
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
        public void FuzzBuzzLogic()
        {
            int n = 100;
            int FizzBuzz = 0;
            int Fizz = 0;
            int Buzz = 0;

            for (int i = 1; i <= n; i++)
            {

                if (i % 15 == 0)
                {
                    Console.Write("FizzBuzz" + " ");
                    FizzBuzz++;
                }
                else
                {
                    if (i % 3 == 0)
                    {
                        Console.Write("Fizz" + " ");
                        Fizz++;
                    }
                    else
                    {
                        if (i % 5 == 0)
                        {
                            Console.Write("Buzz");
                            Buzz++;
                        }
                        else
                        {
                            Console.Write("FizzBuzz");
                            FizzBuzz++;
                        }
                    }

                }
            }
            Console.Write("");
            Console.Write("");
            Console.Write("");
            Console.Write("FizzBuzz Printed on " + FizzBuzz + " times,");
            Console.Write("Fizz Printed on " + Fizz + " times,");
            Console.Write("Buzz Printed on " + Buzz + " times,");
            Console.ReadLine();
           // document.write("test");


        }

    }
}

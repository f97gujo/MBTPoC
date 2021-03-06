﻿using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Internal;
using FluentAssertions.Execution;
using System.Threading;
using System.Collections.Generic;
using System.Linq;


namespace NetCleanModel
{
    class Helper
    {
        private static IWebDriver driver;

        /**
        * Timeout time in seconds used for waiting for element(s) to show up.
        */
        static int timeOut = 20;
      
        public static IWebDriver GetWebDriver()
        {
            if (driver == null)
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
            }
            return driver;
        }

        public static string Url() 
        {
                string Url = driver.Url;
                return Url;
               
        }
        public static void Close()
        {
            driver.Close();
        }
        /**
         * Will wait for a specified web element to appear. If not found
         * an assertion will fail.
         *
         * @param by The description of the element
         * @return The matching element if found.
         */
        public static IWebElement WaitForElement(By by)
        {
            for (int second = 0; ; second++)
            {
                if (second >= timeOut)
                {
                    Execute.Assertion.FailWith("Timeout occurred while waiting for: " + by.ToString());
                }
                try
                {
                    return GetWebDriver().FindElement(by);
                }
                catch (Exception)
                {
                    Thread.Sleep(2000);
                }
            }
        }

         /**
         * Will wait for a specified web element(s) to appear. If not found
         * an assertion will fail.
         *
         * @param by The description of the element
         * @return A list of matching element(s) if found.
         */
        public static List<IWebElement> WaitForElements(By by)
        {
            for (int second = 0; ; second++)
            {
                if (second >= timeOut)
                {
                    Execute.Assertion.FailWith("Timeout occurred while waiting for: " + by.ToString());
                }

                try
                {
                    return new List<IWebElement>(GetWebDriver().FindElements(by));
                }
                catch (Exception)
                {
                    Thread.Sleep(2000);
                }
            }
        }
    }
}
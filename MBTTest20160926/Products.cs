using FluentAssertions;
using OpenQA.Selenium;
using System;
using NUnit;

namespace NetCleanModel
{
    public class Products
    {
        public void v_Products()
        {
            Console.WriteLine("NetCleanModel.v_Products");
            Helper.WaitForElement(By.XPath("//*[@id='companies']/div/div[1]/section[2]/div/div[1]/div/section[4]/div/div/div/a/span")).Text.Should().Match("READ MORE");
        }

        public void e_Products()
        {
            Console.WriteLine("NetCleanModel.e_Products");
            Helper.WaitForElement(By.CssSelector("#menu-main-menu-1 > li.menu-item-211")).Click();
        }

        public void v_Solutions()
        {
            Console.WriteLine("NetCleanModel.v_Solutions");
            Helper.WaitForElement(By.TagName("h1")).Text.Should().Match("Protect children from sexual abuse. And your organization against crime.");
        }

        public void e_Solutions()
        {
            Console.WriteLine("NetCleanModel.e_Solutions");
            //Helper.WaitForElement(By.LinkText("READ MORE")).Click();
        }
    }
}
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
            Helper.Url().Should().Match("http://www.netclean.com/solutions/");
            //Helper.WaitForElement(By.XPath("//*[@id='companies']/div/div[2]/section[2]/div[1]/div/section[4]/div/div/a/span")).Text.Should().Match("READ MORE");
        }

        public void e_Products()
        {
            Console.WriteLine("NetCleanModel.e_Products");
            Helper.WaitForElement(By.CssSelector("#menu-main-menu-1 > li.menu-item-211")).Click();
        }

        public void v_Solutions()
        {
            Console.WriteLine("NetCleanModel.v_Solutions");
            Helper.Url().Should().Match("http://www.netclean.com/solutions/solutions-companies-large-small/");
            //Helper.WaitForElement(By.XPath("//*[@id='27597']/section[1]/div/div[2]/section[4]/div[2]/div/section[6]/div/div/p/a[1]/span")).Text.Should().Match("CONTACT");
        }

        public void e_Solutions()
        {
            Console.WriteLine("NetCleanModel.e_Solutions");
            Helper.WaitForElement(By.LinkText("READ MORE")).Click();
        }
    }
}
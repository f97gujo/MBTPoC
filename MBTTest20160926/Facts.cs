using FluentAssertions;
using OpenQA.Selenium;
using System;
using NUnit;

namespace NetCleanModel
{
    public class Facts
    {
        public void v_Facts()
        {
            Console.WriteLine("NetCleanModel.v_Facts");
            Helper.Url().Should().Match("http://www.netclean.com/facts/");
            //Helper.WaitForElement(By.XPath("//*[@id='27589']/section[2]/div/div/section[2]/div/div/section/div/div/h5/strong/a[3]")).Text.Should().Match("THE NETCLEAN REPORT");
        }

        public void e_Facts()
        {
            Console.WriteLine("NetCleanModel.e_Facts");
            Helper.WaitForElement(By.CssSelector("#menu-main-menu-1 > li.menu-item-27696")).Click();
        }

        public void v_FactsFacts()
        {
            Console.WriteLine("NetCleanModel.v_FactsFacts");
            Helper.Url().Should().Match("http://www.netclean.com/facts/#facts");
            //Helper.WaitForElement(By.XPath("//*[@id='facts']/div/div/section[2]/div[2]/div/section/div/div/h2")).Text.Should().Match("More about the problem");
        }

        public void e_FactsFacts()
        {
            Console.WriteLine("NetCleanModel.e_FactsFacts");
            Helper.WaitForElement(By.XPath("//*[@id='27589']/section[2]/div/div/section[2]/div/div/section/div/div/h5/strong/a[1]")).Click();
        }
    }
}
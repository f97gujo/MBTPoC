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
            Helper.WaitForElement(By.XPath("//*[@id='27589']/section[2]/div/div/section[2]/div/div/div/section/div/div/div/h5/strong/a[3]")).Text.Should().Match("THE NETCLEAN REPORT");
        }

        public void e_Facts()
        {
            Console.WriteLine("NetCleanModel.e_Facts");
            Helper.WaitForElement(By.CssSelector("#menu-main-menu-1 > li.menu-item-27696")).Click();
        }

        public void v_Report()
        {
            Console.WriteLine("NetCleanModel.v_Report");
            Helper.WaitForElement(By.TagName("h2")).Text.Should().Match("Eleven unbelievable truths The NetClean Report");
        }

        public void e_Report()
        {
            Console.WriteLine("NetCleanModel.e_Report");
            //Helper.WaitForElement(By.LinkText("THE NETCLEAN REPORT")).Click();
        }
    }
}
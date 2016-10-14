using FluentAssertions;
using OpenQA.Selenium;
using System;
//using NUnit;

namespace NetCleanModel
{
    public class NetCleanModel
    {
        public void v_Homepage()
        {
            Console.WriteLine("NetCleanModel.v_Homepage");
            Helper.Url().Should().Match("http://www.netclean.com/");
            //Helper.WaitForElement(By.XPath("//*[@id='start']/div/div[2]/div/section[4]/div/div/p/a/span")).Text.Should().Match("THE CHANGE BEGINS HERE");
            //Console.WriteLine(Helper.Url());
            
        }

        public void e_Homepage()
        { 
            Console.WriteLine("NetCleanModel.e_Homepage");
            Helper.WaitForElement(By.XPath("//*[@id='logo']")).Click();
        }

        public void v_Products()
        {
            Console.WriteLine("NetCleanModel.v_Products");
            Helper.Url().Should().Match("http://www.netclean.com/solutions/");
            //Helper.WaitForElement(By.XPath("//*[@id='companies']/div/div[2]/section[2]/div[1]/div/section[4]/div/div/a/span")).Text.Should().Match("READ MORE");
            //Console.WriteLine(Helper.Url());
        }

        public void e_Products()
        {
            Console.WriteLine("NetCleanModel.e_Products");
            Helper.WaitForElement(By.CssSelector("#menu-main-menu-1 > li.menu-item-211")).Click();
        }

        public void v_Facts()
        {
            Console.WriteLine("NetCleanModel.v_Facts");
            Helper.Url().Should().Match("http://www.netclean.com/facts/");
            //Helper.WaitForElement(By.XPath("//*[@id='27589']/section[2]/div/div/section[2]/div/div/section/div/div/h5/strong/a[3]")).Text.Should().Match("THE NETCLEAN REPORT");
            //Console.WriteLine(Helper.Url());
        }

        public void e_Facts()
        {
            Console.WriteLine("NetCleanModel.e_Facts");
            Helper.WaitForElement(By.CssSelector("#menu-main-menu-1 > li.menu-item-27696")).Click();
        }

        public void v_OurFriends()
        {
            Console.WriteLine("NetCleanModel.v_OurFriends");
            Helper.Url().Should().Match("http://www.netclean.com/our-friends/");
            //Helper.WaitForElement(By.XPath("//*[@id='resellers']/div/div/div/section[2]/div[2]/div/p/a/span")).Text.Should().Match("VIEW ALL RESELLERS");
            //Console.WriteLine(Helper.Url());
        }

        public void e_OurFriends()
        {
            Console.WriteLine("NetCleanModel.e_OurFriends");
            Helper.WaitForElement(By.CssSelector("#menu-main-menu-1 > li.menu-item-27505")).Click();
        }

        public void e_StartBrowser()
        {
            Console.WriteLine("NetCleanModel.e_StartBrowser");
            Helper.GetWebDriver().Navigate().GoToUrl("http://www.netclean.com");
        }
    }
}
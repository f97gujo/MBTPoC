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
            Helper.WaitForElement(By.XPath("//*[@id='start']/div/div[2]/div/section[4]/div/div/p/a/span")).Text.Should().Match("THE CHANGE BEGINS HERE");
        }

        public void e_Homepage()
        { 
            Console.WriteLine("NetCleanModel.e_Homepage");
            Helper.WaitForElement(By.XPath("//*[@id='logo']")).Click();
        }

        public void v_Products()
        {
            Console.WriteLine("NetCleanModel.v_Products");
            Helper.WaitForElement(By.XPath("//*[@id='companies']/div/div[2]/section[2]/div[1]/div/section[4]/div/div/a/span")).Text.Should().Match("READ MORE");
        }

        public void e_Products()
        {
            Console.WriteLine("NetCleanModel.e_Products");
            Helper.WaitForElement(By.CssSelector("#menu-main-menu-1 > li.menu-item-211")).Click();
        }

        public void v_Facts()
        {
            Console.WriteLine("NetCleanModel.v_Facts");
            Helper.WaitForElement(By.XPath("//*[@id='27589']/section[2]/div/div/section[2]/div/div/section/div/div/h5/strong/a[3]")).Text.Should().Match("THE NETCLEAN REPORT");
        }

        public void e_Facts()
        {
            Console.WriteLine("NetCleanModel.e_Facts");
            Helper.WaitForElement(By.CssSelector("#menu-main-menu-1 > li.menu-item-27696")).Click();
        }

        public void v_OurFriends()
        {
            Console.WriteLine("NetCleanModel.v_OurFriends");
            Helper.WaitForElement(By.XPath("//*[@id='resellers']/div/div/div/section[2]/div[2]/div/p/a/span")).Text.Should().Match("VIEW ALL RESELLERS");
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

        //Below is the duplicated code from the other cs-files
        //public void v_Products()
        //{
        //    Console.WriteLine("NetCleanModel.v_Products");
        //    Helper.WaitForElement(By.XPath("//*[@id='companies']/div/div[1]/section[2]/div/div[1]/div/section[4]/div/div/div/a/span")).Text.Should().Match("READ MORE");
        //}

        //public void e_Products()
        //{
        //    Console.WriteLine("NetCleanModel.e_Products");
        //    Helper.WaitForElement(By.CssSelector("#menu-main-menu-1 > li.menu-item-211")).Click();
        //}

        public void v_Solutions()
        {
            Console.WriteLine("NetCleanModel.v_Solutions");
            Helper.WaitForElement(By.XPath("//*[@id='27597']/section[1]/div/div[2]/section[4]/div[2]/div/section[6]/div/div/p/a[1]/span")).Text.Should().Match("CONTACT");
        }

        public void e_Solutions()
        {
            Console.WriteLine("NetCleanModel.e_Solutions");
            Helper.WaitForElement(By.LinkText("READ MORE")).Click();
        }

        //public void v_OurFriends()
        //{
        //    Console.WriteLine("NetCleanModel.v_OurFriends");
        //    Helper.WaitForElement(By.XPath("//*[@id='resellers']/div/div/section[2]/div/div[2]/div/p/a/span")).Text.Should().Match("VIEW ALL RESELLERS");
        //}

        //public void e_OurFriends()
        //{
        //    Console.WriteLine("NetCleanModel.e_OurFriends");
        //    Helper.WaitForElement(By.CssSelector("#menu-main-menu-1 > li.menu-item-27505")).Click();
        //}

        public void v_Resellers()
        {
            Console.WriteLine("NetCleanModel.v_Resellers");
            Helper.WaitForElement(By.CssSelector("#text-4 > div.textwidget > p:nth-child(2) > strong")).Text.Should().Match("Oscar Pettersson");
        }
        //Something strange with this action, BLOCKED in graph
        public void e_Resellers()
        {
            Console.WriteLine("NetCleanModel.e_Resellers");
            Helper.WaitForElement(By.LinkText("VIEW ALL RESELLERS")).Click();
        }

        //public void v_Facts()
        //{
        //    Console.WriteLine("NetCleanModel.v_Facts");
        //    Helper.WaitForElement(By.XPath("//*[@id='27589']/section[2]/div/div/section[2]/div/div/div/section/div/div/div/h5/strong/a[3]")).Text.Should().Match("THE NETCLEAN REPORT");
        //}

        //public void e_Facts()
        //{
        //    Console.WriteLine("NetCleanModel.e_Facts");
        //    Helper.WaitForElement(By.CssSelector("#menu-main-menu-1 > li.menu-item-27696")).Click();
        //}

        public void v_FactsFacts()
        {
            Console.WriteLine("NetCleanModel.v_FactsFacts");
            Helper.WaitForElement(By.XPath("//*[@id='facts']/div/div/section[2]/div[2]/div/section/div/div/h2")).Text.Should().Match("More about the problem");
        }

        public void e_FactsFacts()
        {
            Console.WriteLine("NetCleanModel.e_FactsFacts");
            Helper.WaitForElement(By.XPath("//*[@id='27589']/section[2]/div/div/section[2]/div/div/section/div/div/h5/strong/a[1]")).Click();
        }
    }
}
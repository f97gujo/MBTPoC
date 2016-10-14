using FluentAssertions;
using OpenQA.Selenium;
using System;
using NUnit;

namespace NetCleanModel
{
    public class OurFriends
    {
        public void v_OurFriends()
        {
            Console.WriteLine("NetCleanModel.v_OurFriends");
            Helper.Url().Should().Match("http://www.netclean.com/our-friends/");
            //Helper.WaitForElement(By.XPath("//*[@id='resellers']/div/div/div/section[2]/div[2]/div/p/a/span")).Text.Should().Match("VIEW ALL RESELLERS");
        }

        public void e_OurFriends()
        {
            Console.WriteLine("NetCleanModel.e_OurFriends");
            Helper.WaitForElement(By.CssSelector("#menu-main-menu-1 > li.menu-item-27505")).Click();
        }

        public void v_Resellers()
        {
            Console.WriteLine("NetCleanModel.v_Resellers");
            Helper.Url().Should().Match("http://www.netclean.com/our-friends/resellers/");
            //Helper.WaitForElement(By.CssSelector("#text-4 > div.textwidget > p:nth-child(2) > strong")).Text.Should().Match("Oscar Pettersson");
        }
        //Something strange with this action, BLOCKED in graph
        public void e_Resellers()
        {
            Console.WriteLine("NetCleanModel.e_Resellers");
            Helper.WaitForElement(By.LinkText("VIEW ALL RESELLERS")).Click();
        }
    }
}
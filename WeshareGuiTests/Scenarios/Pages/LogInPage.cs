using System.Collections.ObjectModel;
using FluentAssertions;
using OpenQA.Selenium;
using static Scenarios.GaugeSupport;

namespace Scenarios.Pages
{
    public class LogInPage
    {
        private const string Url = "http://localhost:5050";
        private static readonly IWebDriver Driver = GaugeSupport.Driver;


        private static IWebElement EmailField => Driver.FindElement(By.Id("email"));
        private static IWebElement LogInButton => Driver.FindElement(By.Id("submit"));
        
       
        public LogInPage Open()
        {
            Driver.Navigate().GoToUrl(Url);
            return this;
        }

        public ResultsPage LogIn(string email)
        {
            EmailField.SendKeys(email);
            LogInButton.Click();
            return new ResultsPage();
        } 
    }
}
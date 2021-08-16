using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumCoreTestProject1
{
    public class Tests : DriverHelper
    {

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
            Driver = new ChromeDriver("C:\\driver");

        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demo.aspnetawesome.com/");

            CustomControl.ComboBox("AllMealsCombo", "Almond");
            
            Console.WriteLine("Test1");
            Assert.Pass();
        }
    }
}
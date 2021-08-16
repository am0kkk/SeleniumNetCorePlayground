using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCoreTestProject1
{
    public class CustomControl : DriverHelper
    {
        public static void ComboBox(string controlName, string value)
        {
            IWebElement comboControl = Driver.FindElement(By.XPath($"//input[@id='{controlName}-awed']"));
            comboControl.Clear();
            comboControl.SendKeys(value);
           
            Driver.FindElement(By.XPath($"//*[@id='{controlName}-dropmenu']//li[text()='Almond']")).Click();
            //*[@id="AllMealsCombo
            //*[@id="AllMealsCombo-dropmenu"]/div[2]/ul/li[1]
            //*[@id="AllMealsCombo-dropmenu"]/div[2]/ul/li[1]
            //$"//*[@id='{controlName}-dropmenu']//div[2]//ul//li[1]"
        }
    }
}

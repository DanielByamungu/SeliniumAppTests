using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DByamunguTests
{
    class Program
    {
        IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {
      
        }

        [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("file:///F:/Year3/DByamunguA3/Index.html");
        }

        //1.Validating all the contact Information entered 
        [Test]
        public void ValidationContactInformation()
        {
            IWebElement fullName = driver.FindElement(By.Id("fullName"));
            fullName.SendKeys("Grand Master");
            IWebElement address = driver.FindElement(By.Id("address"));
            address.SendKeys("531 highbrook court");
            IWebElement province = driver.FindElement(By.Id("province"));
            province.SendKeys("Ontario");
            IWebElement postalCode = driver.FindElement(By.Id("postalCode"));
            postalCode.SendKeys("N2R 3D8");
            IWebElement city = driver.FindElement(By.Id("city"));
            city.SendKeys("Cambridge");
            IWebElement email= driver.FindElement(By.Id("email"));
            email.SendKeys("grandmaster@gmail.com");
            IWebElement phoneNumber = driver.FindElement(By.Id("phoneNumber"));
            phoneNumber.SendKeys("233-234-4343");
            IWebElement vehicleMake = driver.FindElement(By.Id("vehicleMake"));
            vehicleMake.SendKeys("ford");
            IWebElement vehicleModel = driver.FindElement(By.Id("vehicleModel"));
            vehicleModel.SendKeys("mustang");
            IWebElement vehicleYear = driver.FindElement(By.Id("vehicleYear"));
            vehicleYear.SendKeys("2016");
            IWebElement submitButton = driver.FindElement(By.Id("submit"));
            submitButton.Click();
        }

        //2.Checking if all fields are entered since they all mandatory
        [Test]
        public void CheckingIfAllFieldsAreEntered()
        {
            IWebElement fullName = driver.FindElement(By.Id("fullName"));
            fullName.SendKeys("");
            IWebElement address = driver.FindElement(By.Id("address"));
            address.SendKeys("231 ottawa Street");
            IWebElement province = driver.FindElement(By.Id("province"));
            province.SendKeys("Ontario");
            IWebElement postalCode = driver.FindElement(By.Id("postalCode"));
            postalCode.SendKeys("N2R 3D4");
            IWebElement city = driver.FindElement(By.Id("city"));
            city.SendKeys("");
            IWebElement email = driver.FindElement(By.Id("email"));
            email.SendKeys("");
            IWebElement phoneNumber = driver.FindElement(By.Id("phoneNumber"));
            phoneNumber.SendKeys("233-234-5434");
            IWebElement vehicleMake = driver.FindElement(By.Id("vehicleMake"));
            vehicleMake.SendKeys("bmw");
            IWebElement vehicleModel = driver.FindElement(By.Id("vehicleModel"));
            vehicleModel.SendKeys("m2");
            IWebElement vehicleYear = driver.FindElement(By.Id("vehicleYear"));
            vehicleYear.SendKeys("2012");
            IWebElement submitButton = driver.FindElement(By.Id("submit"));
            submitButton.Click();
        }
        //3.Validating the PostalCode using regex and detecting the error
        [Test]
        public void ValidatingPostalCodeAndDetectingTheError()
        {
            IWebElement fullName = driver.FindElement(By.Id("fullName"));
            fullName.SendKeys("Grace Orling");
            IWebElement address = driver.FindElement(By.Id("address"));
            address.SendKeys("666 Frederick St");
            IWebElement province = driver.FindElement(By.Id("province"));
            province.SendKeys("Ontario");
            IWebElement postalCode = driver.FindElement(By.Id("postalCode"));
            postalCode.SendKeys("N2H-BB4");
            IWebElement city = driver.FindElement(By.Id("city"));
            city.SendKeys("city");
            IWebElement email = driver.FindElement(By.Id("email"));
            email.SendKeys("grandmaster@gmail.com");
            IWebElement phoneNumber = driver.FindElement(By.Id("phoneNumber"));
            phoneNumber.SendKeys("233-234-4434");
            IWebElement vehicleMake = driver.FindElement(By.Id("vehicleMake"));
            vehicleMake.SendKeys("ford");
            IWebElement vehicleModel = driver.FindElement(By.Id("vehicleModel"));
            vehicleModel.SendKeys("mustang");
            IWebElement vehicleYear = driver.FindElement(By.Id("vehicleYear"));
            vehicleYear.SendKeys("2019");
            IWebElement submitButton = driver.FindElement(By.Id("submit"));
            submitButton.Click();
        }
        //4.validating the phoneNumber using regex and detecting the error
        [Test]
        public void ValidatingPhoneNumberAndDetectingError()
        {
            IWebElement fullName = driver.FindElement(By.Id("fullName"));
            fullName.SendKeys("Brian Look");
            IWebElement address = driver.FindElement(By.Id("address"));
            address.SendKeys("531 highbrook court");
            IWebElement province = driver.FindElement(By.Id("province"));
            province.SendKeys("Ontario");
            IWebElement postalCode = driver.FindElement(By.Id("postalCode"));
            postalCode.SendKeys("N2E 3P4");
            IWebElement city = driver.FindElement(By.Id("city"));
            city.SendKeys("Kitchener");
            IWebElement email = driver.FindElement(By.Id("email"));
            email.SendKeys("grandmaster@gmail.com");
            IWebElement phoneNumber = driver.FindElement(By.Id("phoneNumber"));
            phoneNumber.SendKeys("233-234-434");
            IWebElement vehicleMake = driver.FindElement(By.Id("vehicleMake"));
            vehicleMake.SendKeys("ford");
            IWebElement vehicleModel = driver.FindElement(By.Id("vehicleModel"));
            vehicleModel.SendKeys("mustang");
            IWebElement vehicleYear = driver.FindElement(By.Id("vehicleYear"));
            vehicleYear.SendKeys("2020");
            IWebElement submitButton = driver.FindElement(By.Id("submit"));
            submitButton.Click();
        }
        //5.Checking for any little errors that might have been made
        [Test]
        public void CheckingForAnyLittleErrorsThatMightHavebeenMade()
        {
            IWebElement fullName = driver.FindElement(By.Id("fullName"));
            fullName.SendKeys("Brian Look");
            IWebElement address = driver.FindElement(By.Id("address"));
            address.SendKeys("531 highbrook court");
            IWebElement province = driver.FindElement(By.Id("province"));
            province.SendKeys("Ontario");
            IWebElement postalCode = driver.FindElement(By.Id("postalCode"));
            postalCode.SendKeys("N2E3P4");
            IWebElement city = driver.FindElement(By.Id("city"));
            city.SendKeys("Kitchener");
            IWebElement email = driver.FindElement(By.Id("email"));
            email.SendKeys("grandmaster@gmail.com");
            IWebElement phoneNumber = driver.FindElement(By.Id("phoneNumber"));
            phoneNumber.SendKeys("233234434");
            IWebElement vehicleMake = driver.FindElement(By.Id("vehicleMake"));
            vehicleMake.SendKeys("ford");
            IWebElement vehicleModel = driver.FindElement(By.Id("vehicleModel"));
            vehicleModel.SendKeys("mustang");
            IWebElement vehicleYear = driver.FindElement(By.Id("vehicleYear"));
            vehicleYear.SendKeys("2020");
            IWebElement submitButton = driver.FindElement(By.Id("submit"));
            submitButton.Click();
        }
        //6.Checking if the link directs to the car sale page
        [Test]
        public void CheckingIfTheLinkCorrecteclyDirects()
        {
            IWebElement fullName = driver.FindElement(By.Id("fullName"));
            fullName.SendKeys("Grand Master");
            IWebElement address = driver.FindElement(By.Id("address"));
            address.SendKeys("531 highbrook court");
            IWebElement province = driver.FindElement(By.Id("province"));
            province.SendKeys("Ontario");
            IWebElement postalCode = driver.FindElement(By.Id("postalCode"));
            postalCode.SendKeys("N2R 3D8");
            IWebElement city = driver.FindElement(By.Id("city"));
            city.SendKeys("Cambridge");
            IWebElement email = driver.FindElement(By.Id("email"));
            email.SendKeys("grandmaster@gmail.com");
            IWebElement phoneNumber = driver.FindElement(By.Id("phoneNumber"));
            phoneNumber.SendKeys("233-234-4343");
            IWebElement vehicleMake = driver.FindElement(By.Id("vehicleMake"));
            vehicleMake.SendKeys("ford");
            IWebElement vehicleModel = driver.FindElement(By.Id("vehicleModel"));
            vehicleModel.SendKeys("mustang");
            IWebElement vehicleYear = driver.FindElement(By.Id("vehicleYear"));
            vehicleYear.SendKeys("2015");
            IWebElement submitButton = driver.FindElement(By.Id("submit"));
            submitButton.Click();
        }
        //7.Checking if the vehicle year entered is corrrect and in the right format
        [Test]
        public void CheckingIfTheCarYearEnteredIsCorrectAndInTheRightFormat()
        {
            IWebElement fullName = driver.FindElement(By.Id("fullName"));
            fullName.SendKeys("Grand Master");
            IWebElement address = driver.FindElement(By.Id("address"));
            address.SendKeys("531 highbrook court");
            IWebElement province = driver.FindElement(By.Id("province"));
            province.SendKeys("Ontario");
            IWebElement postalCode = driver.FindElement(By.Id("postalCode"));
            postalCode.SendKeys("N2R 3D8");
            IWebElement city = driver.FindElement(By.Id("city"));
            city.SendKeys("Cambridge");
            IWebElement email = driver.FindElement(By.Id("email"));
            email.SendKeys("grandmaster@gmail.com");
            IWebElement phoneNumber = driver.FindElement(By.Id("phoneNumber"));
            phoneNumber.SendKeys("233-234-4343");
            IWebElement vehicleMake = driver.FindElement(By.Id("vehicleMake"));
            vehicleMake.SendKeys("ford");
            IWebElement vehicleModel = driver.FindElement(By.Id("vehicleModel"));
            vehicleModel.SendKeys("mustang");
            IWebElement vehicleYear = driver.FindElement(By.Id("vehicleYear"));
            vehicleYear.SendKeys("dfsdfsd");
            IWebElement submitButton = driver.FindElement(By.Id("submit"));
            submitButton.Click();
        }
        //8.Checking if all errors are printed when all inputs fields are left blank
        [Test]
        public void CheckingIfAllErrorsPrintWhenNoDataEntered()
        {
            IWebElement fullName = driver.FindElement(By.Id("fullName"));
            fullName.SendKeys("");
            IWebElement address = driver.FindElement(By.Id("address"));
            address.SendKeys("");
            IWebElement province = driver.FindElement(By.Id("province"));
            province.SendKeys("");
            IWebElement postalCode = driver.FindElement(By.Id("postalCode"));
            postalCode.SendKeys("");
            IWebElement city = driver.FindElement(By.Id("city"));
            city.SendKeys("");
            IWebElement email = driver.FindElement(By.Id("email"));
            email.SendKeys("");
            IWebElement phoneNumber = driver.FindElement(By.Id("phoneNumber"));
            phoneNumber.SendKeys("");
            IWebElement vehicleMake = driver.FindElement(By.Id("vehicleMake"));
            vehicleMake.SendKeys("");
            IWebElement vehicleModel = driver.FindElement(By.Id("vehicleModel"));
            vehicleModel.SendKeys("");
            IWebElement vehicleYear = driver.FindElement(By.Id("vehicleYear"));
            vehicleYear.SendKeys("");
            IWebElement submitButton = driver.FindElement(By.Id("submit"));
            submitButton.Click();
        }
        //9.Checking if the submit button sends you to the next page if the data entered is invalid
        [Test]
        public void SubmitButtonResponseWhenClickedIfInvalidDataIsEntered()
        {
            IWebElement fullName = driver.FindElement(By.Id("fullName"));
            fullName.SendKeys("Grand Master");
            IWebElement address = driver.FindElement(By.Id("address"));
            address.SendKeys("531 highbrook court");
            IWebElement province = driver.FindElement(By.Id("province"));
            province.SendKeys("Ontario");
            IWebElement postalCode = driver.FindElement(By.Id("postalCode"));
            postalCode.SendKeys("N2R");
            IWebElement city = driver.FindElement(By.Id("city"));
            city.SendKeys("Cambridge");
            IWebElement email = driver.FindElement(By.Id("email"));
            email.SendKeys("grandmaster@gmail.com");
            IWebElement phoneNumber = driver.FindElement(By.Id("phoneNumber"));
            phoneNumber.SendKeys("233-234-4343");
            IWebElement vehicleMake = driver.FindElement(By.Id("vehicleMake"));
            vehicleMake.SendKeys("honda");
            IWebElement vehicleModel = driver.FindElement(By.Id("vehicleModel"));
            vehicleModel.SendKeys("odyssey");
            IWebElement vehicleYear = driver.FindElement(By.Id("vehicleYear"));
            vehicleYear.SendKeys("dfsdfsd");
            IWebElement submitButton = driver.FindElement(By.Id("submit"));
            submitButton.Click();
        }
        //10.Checking if the submit button sends you to the next page if the data entered is all valid
        [Test]
        public void SubmitButtonResponseWhenClickedIfValidDataIsEntered()
        {
            IWebElement fullName = driver.FindElement(By.Id("fullName"));
            fullName.SendKeys("Grand Master");
            IWebElement address = driver.FindElement(By.Id("address"));
            address.SendKeys("531 highbrook court");
            IWebElement province = driver.FindElement(By.Id("province"));
            province.SendKeys("Ontario");
            IWebElement postalCode = driver.FindElement(By.Id("postalCode"));
            postalCode.SendKeys("N2R 3P5");
            IWebElement city = driver.FindElement(By.Id("city"));
            city.SendKeys("Cambridge");
            IWebElement email = driver.FindElement(By.Id("email"));
            email.SendKeys("grandmaster@gmail.com");
            IWebElement phoneNumber = driver.FindElement(By.Id("phoneNumber"));
            phoneNumber.SendKeys("233-234-4343");
            IWebElement vehicleMake = driver.FindElement(By.Id("vehicleMake"));
            vehicleMake.SendKeys("honda");
            IWebElement vehicleModel = driver.FindElement(By.Id("vehicleModel"));
            vehicleModel.SendKeys("odyssey");
            IWebElement vehicleYear = driver.FindElement(By.Id("vehicleYear"));
            vehicleYear.SendKeys("2020");
            IWebElement submitButton = driver.FindElement(By.Id("submit"));
            submitButton.Click();
        }
    }
}

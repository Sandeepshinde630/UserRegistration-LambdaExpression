using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration_LambdaExpression;
using System;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {   //Arrange
        //Act
        //Assert
        [TestMethod]
        public void GivenFirstName_WhenCheck_ShouldReturnTrue()
        {
            RegexPatterns name = new RegexPatterns();
            bool result = name.ValidateName("Sandeep", RegexPatterns.FIRSTNAME_REGEX);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenLastName_WhenCheck_ShouldReturnTrue()
        {
            RegexPatterns lastname = new RegexPatterns();
            bool resultlastname = lastname.ValidateLastName("Shinde", RegexPatterns.LASTNAME_REGEX);
            Assert.IsTrue(resultlastname);
        }
        [TestMethod]
        public void GivenPhoneNum_WhenCheck_ShouldReturnTrue()
        {
            RegexPatterns phonenum = new RegexPatterns();
            bool resultphonenum = phonenum.ValidatePhoneNum("91 9944557723", RegexPatterns.PHONENUM_REGEX);
            Assert.IsTrue(resultphonenum);
        }
        [TestMethod]
        public void GivenEmailId_WhenCheck_ShouldReturnTrue()
        {
            RegexPatterns emailid = new RegexPatterns();
            bool resultemailid = emailid.ValidateEmail("sandeepshinde@gmail.com", RegexPatterns.EMAIL_REGEX);
            Assert.IsTrue(resultemailid);
        }
        [TestMethod]
        public void TGivenPassword_WhenCheck_ShouldReturnTrue()
        {
            RegexPatterns pass = new RegexPatterns();
            bool resultpass = pass.ValidatePassword("Passs@123456", RegexPatterns.PASSWORD_REGEX);
            Assert.IsTrue(resultpass);
        }
    }
}

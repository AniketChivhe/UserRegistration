using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UC12_CustomException;

namespace TestProject1
{
    [TestClass]
    public class UnitTest_UC12
    {
        [TestMethod]
        [DataRow("Aniket", "Aniket")]
        [DataRow("Ani", "Ani")]
        [DataRow("IamAniket", null)]
        [DataRow("Aniket0712", null)]
        public void ValidateFirstname(string a, string expected)
        {
            var actual = RegexPattern.ValidateFirstName(a);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow("Chivhe", "Chivhe")]
        [DataRow("CHIVHE", "CHIVHE")]
        public void ValidateUserLastname(string a, string expected)
        {
            var actual = RegexPattern.ValidateLastName(a);
            Assert.AreEqual(expected, actual);
        }

        //passing Sample Email ID and Checking
        [TestMethod]
        [DataRow("abc@gmail.com", "abc@gmail.com")]
        [DataRow("abc-100@yahoo.com", "abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com", "abc.100@yahoo.com")]
        [DataRow("abc111@yahoo.com", "abc111@yahoo.com")]
        [DataRow("abc111@abc.com", "abc111@abc.com")]
        [DataRow("abc-100@abc.net", "abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au", "abc.100@abc.com.au")]
        [DataRow("abc@1.com", "abc@1.com")]

        public void ValidateUserEmail(string a, string expected)
        {
            var actual = RegexPattern.ValidateEmail(a);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow("1 1000984562", "1 1000984562")]
        [DataRow("91 9845656232", "91 9845656232")]
        [DataRow("100 9845656232", "100 9845656232")]
        [DataRow("919845656", null)]
        [DataRow("91 8446556", null)]
        [DataRow("91 8445662220", null)]
        public void ValidatePhoneNum(string a, string expected)
        {
            var actual = RegexPattern.ValidatePhoneNum(a);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow("Aniket@123", "Aniket@123")]
        [DataRow("IamRandom#123", "IamRandom#123")]
        [DataRow("aNiket12345", "aNiket12345")]
        [DataRow("@Ani0712", "@Ani0712")]
        [DataRow("Aniket7777", "Aniket7777")]
        [DataRow("ANiKet", null)]
        [DataRow("PASSword", null)]
        [DataRow("pAsSwOrD", null)]
        [DataRow("Aniket", null)]
        [DataRow("XYZ(:123", null)]

        public void ValidatePassword(string a, string expected)
        {
            var actual = RegexPattern.ValidatePassWord(a);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Method_Parameteized_Constructor()
        {
            object expected = new RegexPattern("RegularExpression");
            UserRegistrationFactory factory = new UserRegistrationFactory();
            object actual = factory.CreateParameterizedConstructor("UC12_CustomException.RegexPattern", "RegexPattern", "RegularExpression");
            actual.Equals(expected);
        }

    }
}

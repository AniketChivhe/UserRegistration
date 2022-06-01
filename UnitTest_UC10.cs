using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UC10_UnitTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest_UC10
    {
        //validation for first Name
        [TestMethod]    
        [DataRow("Aniket", "Aniket")]
        [DataRow("Ani", "Ani")]
        [DataRow("A", null)]
        [DataRow("Aniket07", null)]
        public void ValidateFirstname(string a, string expected)
        {
            var actual = RegexPattern.ValidatingFirstName(a);
            Assert.AreEqual(expected, actual);
        }
        //Validating for Last Name
        [TestMethod]
        [DataRow("Chivhe", "Chivhe")]
        [DataRow("CH", null)]
        [DataRow("CHIVHE", "CHIVHE")]
        [DataRow("Chivhe77", null)]
        public void ValidateUserLastname(string a, string expected)
        {
            var actual = RegexPattern.ValidatingLastName(a);
            Assert.AreEqual(expected, actual);
        }
        //Validation for Email
        [TestMethod]
        [DataRow("abc@gmail.com", "abc@gmail.com")]
        [DataRow("abc-100@yahoo.com", "abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com", "abc.100@yahoo.com")]
        [DataRow("abc111@yahoo.com", "abc111@yahoo.com")]
        [DataRow("abc111@abc.com", "abc111@abc.com")]
        [DataRow("abc-100@abc.net", "abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au", "abc.100@abc.com.au")]
        [DataRow("abc@1.com", "abc@1.com")]
        [DataRow("abc@gmail.com.com", "abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com", "abc+100@gmail.com")]
        [DataRow("abc", null)]
        [DataRow("abc@.com.my", null)]
        [DataRow("abc123@.com", null)]
        [DataRow("abc123@.com.com", null)]
        [DataRow("abc()*@gmail.com", null)]
        [DataRow(".abc@abc.com", null)]
        [DataRow("abc@%*.com", null)]
        [DataRow("abc..2002@gmail.com", null)]
        [DataRow("abc.@gmail.com", null)]
        [DataRow("abc@abc@gmail.com", null)]
        [DataRow("abc@gmail.com.1a", null)]
        [DataRow("abc@gmail.com.aa.au", null)]
        public void ValidateUserEmail(string a, string expected)
        {
            var actual = RegexPattern.ValidatingEmailId(a);
            Assert.AreEqual(expected, actual);
        }
        //Validation for Phone Number
        [TestMethod]
        [DataRow("1 1000984562", "1 1000984562")]
        [DataRow("91 9845656232", "91 9845656232")]
        [DataRow("100 9845656232", "100 9845656232")]
        [DataRow("919845656232", null)]
        [DataRow("91986523", null)]
        [DataRow("91 844655", null)]
        [DataRow("91 844566222000", null)]
        public void ValidateUserPhoneNumber(string a, string expected)
        {
            var actual = RegexPattern.ValidatingPhoneNum(a);
            Assert.AreEqual(expected, actual);
        }
        ////Validation for Password
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
        public void ValidateUserPassword(string a, string expected)
        {
            var actual = RegexPattern.ValidatingPassWord(a);
            Assert.AreEqual(expected, actual);
        }

    }
}

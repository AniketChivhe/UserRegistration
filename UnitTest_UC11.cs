using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UC11_UsingReflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest_UC11
    {
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
            var actual = RegexPattern.ValidatingEmailId(a);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Method_Parameteized_Constructor()
        {
            object expected = new RegexPattern("RegularExpression");
            UserRegistrationFactory factory = new UserRegistrationFactory();
            object actual = factory.CreateParameterizedConstructor("UC11_UsingReflection.RegexPattern", "RegexPattern", "RegularExpression");
            actual.Equals(expected);
        }
    }
}

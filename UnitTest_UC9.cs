using Microsoft.VisualStudio.TestTools.UnitTesting;
using UC9_EmailCheck;

namespace TestProject1
{
    [TestClass]
    public class UnitTest_UC9
    {
        //Validation for Email
        [TestMethod]
        [DataRow("abc@yahoo.com", "abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com", "abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com", "abc.100@yahoo.com")]
        [DataRow("abc111@yahoo.com", "abc111@yahoo.com")]
        [DataRow("abc111@abc.com", "abc111@abc.com")]
        [DataRow("abc-100@abc.net", "abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au", "abc.100@abc.com.au")]
        [DataRow("abc@1.com", "abc@1.com")]
        [DataRow("abc@gmail.com.com", "abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com", "abc+100@gmail.com")]
        
        public void ValidateUserEmail(string a, string expected)
        {
            var actual = EmailTest.ValidatingEmailId(a);
            Assert.AreEqual(expected, actual);
        }

    }
}
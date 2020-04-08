using NUnit.Framework;
using RomanNumbers;

namespace RomanNumeralTestProject
{
    public class Tests
    {
        RomanNumbersConverter rc;

        [Test]
        public void ZeroReturnsEmptyString()
        {
            var roman = rc.ConvertToRoman(0);
            Assert.AreEqual("", roman);
        }
    }
}
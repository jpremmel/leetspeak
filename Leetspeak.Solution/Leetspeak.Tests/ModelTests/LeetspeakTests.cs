using Microsoft.VisualStudio.TestTools.UnitTesting;
using Translator;

namespace Translator.Test
{
    [TestClass]
    public class LeetspeakTest
    {
        [TestMethod]
        public void Translate_TurnETo3_3()
        {
            Leetspeak testLeetspeak = new Leetspeak(); 
            Assert.AreEqual("3", testLeetspeak.Translate("e"));
        }
    }
}
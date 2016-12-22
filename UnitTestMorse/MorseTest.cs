using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MorseCode.protocol;
using MorseCode.text;

namespace UnitTestMorse
{
    [TestClass]
    public class MorseTest
    {
        [TestMethod]
        public void CanConvertToMorse()
        {
            //Arrenge
            var morser = new AmericanMorse();
            var conversor = new StringConversor(morser);
            var message = "Hi! My name is David!";

            //Execute
            var morseMessage = conversor.ConvertToMorse(message);

            //Assert
            Assert.AreNotEqual(morseMessage, null);
            Assert.AreNotEqual(message, morseMessage);
        }
    }
}

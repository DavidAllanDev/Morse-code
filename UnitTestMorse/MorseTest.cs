using Microsoft.VisualStudio.TestTools.UnitTesting;
using MorseCode.protocol;
using MorseCode.text;
using Morse = MorseCode.communication.MorseCode;

namespace UnitTestMorse
{
    [TestClass]
    public class MorseTest
    {
        [TestMethod]
        public void CanConvertToMorse()
        {
            //Arrange
            var morser = new AmericanMorse();
            var conversor = new StringConversor(morser);
            var message = "Hi! My name is David!";

            //Execute
            var morseMessage = conversor.ConvertToMorse(message);

            //Assert
            Assert.AreNotEqual(morseMessage, null);
            Assert.AreNotEqual(message, morseMessage);
        }

        [TestMethod]
        public void CanConvertFromMorse()
        {
            //Arrange
            var morser = new Morse(new ITUMorse(), PreserveChars: true);

            //Execute
            var morseMessage = morser.Morse(message);
            morseMessage = morser.UnMorse(morseMessage);

            //Assert
            Assert.AreNotEqual(morseMessage, null);
            Assert.AreEqual(message, morseMessage);
        }
    }
}

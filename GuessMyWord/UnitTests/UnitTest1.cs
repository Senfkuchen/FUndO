using System;
using GuessMyWord;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestWordgenerator()
        {
            //WordDataBaseMock contains 5 Words
            var wordDataBaseMock = new WordDataBaseMock();
            var wordGenerator = new WordGenerator(wordDataBaseMock);
            for (int i = 0; i < 10; i++)
            {
                var generatedWord = wordGenerator.SelectRandomWord();
                Assert.IsTrue(generatedWord.Length > 0, "Assert word length is larger than 0.");
            }
            for (int i = 0; i < wordDataBaseMock.words.Length; i++)
            {
                var generatedWord = wordGenerator.SelectUnusedWord();
                Assert.IsTrue(generatedWord.Length > 0, "Assert word length is larger than 0.");
            }

            //Force Exception - no more unusedWords can be selected
            bool exceptionHappened = false;
            try
            {
                var generatedWord = wordGenerator.SelectUnusedWord();
            }
            catch (Exception)
            {
                exceptionHappened = true;
            }
            Assert.IsTrue(exceptionHappened, "Check exception was triggered..");
        }
    }
}

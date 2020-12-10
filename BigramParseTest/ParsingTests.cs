using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParsingService.Services;

namespace BigramParseTest
{
    [TestClass]
    public class ParsingTests
    {
        [TestMethod]
        public void BasicParsingTest()
        {
            var input = "test test test bang";
            var parser = new BigramParser(new ParserOutputRenderer());
            parser.Parse(input);
            var output = parser.GetContent();
            var correct = "test test: 2\r\ntest bang: 1\r\n";

            Assert.AreEqual(correct, output);

        }
        [TestMethod]
        public void BasicParsingTest2()
        {
            var input = "test test radar vest test bang test box carrot";
            var parser = new BigramParser(new ParserOutputRenderer());
            parser.Parse(input);
            var output = parser.GetContent();

            var correct = @"bang test: 1
box carrot: 1
radar vest: 1
test bang: 1
test box: 1
test radar: 1
test test: 1
vest test: 1
";

            Assert.AreEqual(correct, output);

        }


        [TestMethod]
        public void TooShortParsingTest()
        {
            var input = "test ";
            var parser = new BigramParser(new ParserOutputRenderer());
            parser.Parse(input);
            var output = parser.GetContent();

            var correct = "Input does not contain enough elements to create a bigram.";

            Assert.AreEqual(correct, output);

        }
        [TestMethod]
        public void SortingParsingTest1()
        {
            var input = "test nani apple nani";
            var parser = new BigramParser(new ParserOutputRenderer());
            parser.Parse(input);
            var output = parser.GetContent();

            var correct = "apple nani: 1\r\nnani apple: 1\r\ntest nani: 1\r\n";

            Assert.AreEqual(correct, output);

        }

        [TestMethod]
        public void ParsingSplitTest()
        {
            var input = "test test`~!@#$%^&*()_+{-}:-<>?,./;'[] \t\r\n test bang ";
            var parser = new BigramParser(new ParserOutputRenderer());
            parser.Parse(input);
            var output = parser.GetContent();

            var correct = "test test: 2\r\ntest bang: 1\r\n";

            Assert.AreEqual(correct, output);

        }


        [TestMethod]
        public void FileParsingTest()
        {
            var renderer = new ParserOutputRenderer();
            var parser = new BigramParser(renderer);
            var currentLocation = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var currentPath = System.IO.Path.GetDirectoryName(currentLocation);
            var testFile = System.IO.Path.Combine(currentPath, "TestArtifacts\\test.txt");
            var file = new ParserFileService(parser, testFile);
            file.Read();
            var output = file.GetContent();
            var correct = @"sit amet: 61
aliquam erat: 8
erat volutpat: 8";
            Assert.IsTrue(output.StartsWith(correct));


        }


    }
}

using NUnit.Framework;
using System;
using System.IO;
using Opgaver;

namespace UnitTest
{
    public class TestsOfVariabels
    {
        private StringWriter stringWriter;

        [SetUp]
        public void Setup()
        {
            stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
        }

        [TearDown]
        public void TearDown()
        {
            stringWriter.Dispose();
        }

        [Test]
        public void TestInt1()
        {
            Opgaver.Variabler.Int1();
            string output = stringWriter.ToString();
            Assert.IsTrue(output.Contains("Opgave 1:"));
            Assert.IsTrue(output.Contains("Lav en variabel af typen int og tildel den en værdi af ti!"));
            Assert.IsTrue(output.Contains("10"));
        }

        [Test]
        public void TestDouble1()
        {
            Opgaver.Variabler.Double1();
            string output = stringWriter.ToString();
            Assert.IsTrue(output.Contains("Opgave 2:"));
            Assert.IsTrue(output.Contains("Lav en variabel af typen double og tildel den en værdi komma (decimal) værdi af 5 og en 1/4"));
            Assert.IsTrue(output.Contains("5.25") || output.Contains("5,25"));
        }

        [Test]
        public void TestStrings1()
        {
            Opgaver.Variabler.Strings1();
            string output = stringWriter.ToString();
            Assert.IsTrue(output.Contains("Opgave 3:"));
            Assert.IsTrue(output.Contains("Lav en variabel af typen string og tildel den en værdi - den skal indeholde teksten 'Hello, World' med et udråbstegn til sidst!"));
            Assert.IsTrue(output.Contains("Hello, World!"));
        }

        [Test]
        public void TestBool1()
        {
            Opgaver.Variabler.Bool1();
            string output = stringWriter.ToString();
            Assert.IsTrue(output.Contains("Opgave 4:"));
            Assert.IsTrue(output.Contains("Lav en variabel af typen bool og tildel den en sandhedsværdi (true/false)."));
            Assert.IsTrue(output.Contains("True"));
        }

        [Test]
        public void TestStringInterpolation()
        {
            Opgaver.Variabler.StringInterpolation();
            string output = stringWriter.ToString();
            Assert.IsTrue(output.Contains("Opgave 5:"));
            Assert.IsTrue(output.Contains("Lav to string variabeler og udskriv dem ved brug af string interpolation."));
            Assert.IsTrue(output.Contains("Hello, World!"));
        }

        [Test]
        public void TestFloat1()
        {
            Opgaver.Variabler.Float1();
            string output = stringWriter.ToString();
            Assert.IsTrue(output.Contains("Opgave 6:"));
            Assert.IsTrue(output.Contains("Lav en variabel af typen float og tildel den en værdi af 3.14"));
            Assert.IsTrue(output.Contains("3,14"));
        }

        [Test]
        public void TestChar1()
        {
            Opgaver.Variabler.Char1();
            string output = stringWriter.ToString();
            Assert.IsTrue(output.Contains("Opgave 7:"));
            Assert.IsTrue(output.Contains("Lav en variabel af typen char og tildel den en værdi af det første bogstav i alfabetet (Det skal være stort!)"));
            Assert.IsTrue(output.Contains("A"));
        }

        [Test]
        public void TestDecimal1()
        {
            Opgaver.Variabler.Decimal1();
            string output = stringWriter.ToString();
            Assert.IsTrue(output.Contains("Opgave 8:"));
            Assert.IsTrue(output.Contains("Lav en variabel af typen decimal og tildel den en værdi af 100.50"));
            Assert.IsTrue(output.Contains("100,50"));
        }
    }
}
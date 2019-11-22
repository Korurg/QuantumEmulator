using System.Numerics;
using NUnit.Framework;
using QuantumEmulatorLibrary;

namespace Tests
{
    public class MathComplexTest
    {
        [SetUp]
        public void Setup()
        {
            
        }
        

        [Test]
        public void TestSquareReal4Img0()
        {
            Complex complex = new Complex(4, 0);
            Assert.AreEqual(new Complex(16,0),MathComplex.Square(complex));
        }
        
        [Test]
        public void TestSquareReal4Img3()
        {
            Complex complex = new Complex(4, 3);
            Assert.AreEqual(new Complex(7,24),MathComplex.Square(complex));
        }
    }
}
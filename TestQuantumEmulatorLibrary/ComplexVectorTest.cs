using System.Numerics;
using NUnit.Framework;
using QuantumEmulatorLibrary;

namespace Tests
{
    public class ComplexVectorTest
    {


        [Test]
        public void compareTwoComplexVectors()
        {

            ComplexVector v1 = new ComplexVector(new int[] { 0, 0, 1, 0 });
            ComplexVector v2 = new ComplexVector(new Complex[] { 0, 0, 1, 0 });

            Assert.AreEqual(v2, v1);
        }


        [Test]
        public void testTensorProduct()
        {
            ComplexVector v1 = new ComplexVector(new int[] { 0, 1 });
            ComplexVector v2 = new ComplexVector(new int[] { 0, 1, 1 });

            ComplexVector expected = new ComplexVector(new int[] { 0, 0, 0, 1, 0, 1 });

            Assert.AreEqual(expected, ComplexVector.TensorProduct(v2, v1));
        }
    }
}
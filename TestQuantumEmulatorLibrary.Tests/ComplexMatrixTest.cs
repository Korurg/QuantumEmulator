using NUnit.Framework;
using QuantumEmulatorLibrary;

namespace Tests
{
    public class ComplexMatrixTest
    {


        [Test]
        public void CompareTwoMatrix()
        {

            ComplexMatrix m1 = new ComplexMatrix(new int[,]{
                    {1,1},
                    {2,2}
                });

            ComplexMatrix m2 = new ComplexMatrix(new int[,]{
                    {1,1},
                    {2,2}
                });

            Assert.AreEqual(m2, m1);
        }

        [Test]
        public void CompareMatrixAndTransparentMatrix()
        {

            ComplexMatrix m1 = new ComplexMatrix(new int[,]{
                    {1,2},
                    {1,2}
                });

            m1.T();

            ComplexMatrix m2 = new ComplexMatrix(new int[,]{
                    {1,1},
                    {2,2}
                });


            Assert.AreEqual(m2, m1);
        }

        [Test]
        public void TensorProduct()
        {
            ComplexMatrix m1 = new ComplexMatrix(new int[,]{
                    {1,2,3},
                    {1,2,3}
                });

            ComplexMatrix m2 = new ComplexMatrix(new int[,]{
                    {1,1},
                    {2,2}
                });

            ComplexMatrix expected = new ComplexMatrix(new int[,]{
                    {1,1,2,2,3,3},
                    {2,2,4,4,6,6},
                    {1,1,2,2,3,3},
                    {2,2,4,4,6,6}
                });


            Assert.AreEqual(expected, ComplexMatrix.TensorProduct(m1, m2));
        }

        [Test]
        public void MultiplicationTest()
        {
            ComplexMatrix m1 = new ComplexMatrix(new int[,]{
                    {1,2,3},
                    {1,2,3}
                });

            ComplexMatrix m2 = new ComplexMatrix(new int[,]{
                    {1,1},
                    {2,2},
                    {3,3}
                });

            ComplexMatrix expected = new ComplexMatrix(new int[,]{
                   {14, 14},
                   {14, 14}
                });


            Assert.AreEqual(expected, ComplexMatrix.Multiplication(m1, m2));
        }

    }
}
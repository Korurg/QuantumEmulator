using System.Numerics;
using NUnit.Framework;
using QuantumEmulatorLibrary;

namespace Tests
{


    class QuantumStateTest
    {



        [Test]
        public void CreateState01_01_0001()
        {

            Qubit q1 = new Qubit(Complex.Zero, new Complex(1, 0));
            Qubit q2 = new Qubit(Complex.Zero, new Complex(1, 0));

            QuantumState quantumState = new QuantumState(q1, q2);
            QuantumState expected = new QuantumState(new Complex[] {
                Complex.Zero,
                Complex.Zero,
                Complex.Zero,
                new Complex(1, 0) });

            Assert.AreEqual(expected, quantumState);
        }

    }

}
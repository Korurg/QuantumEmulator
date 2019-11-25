using System.Numerics;
using NUnit.Framework;
using QuantumEmulatorLibrary;
using static QuantumEmulatorLibrary.VirtualQuantumMachine;

namespace Tests
{


    class QuantumStateTest
    {



        [Test]
        public void CreateState01_01_0001()
        {

            VirtualQubit q1 = new VirtualQubit(Complex.Zero, new Complex(1, 0), 0);
            VirtualQubit q2 = new VirtualQubit(Complex.Zero, new Complex(1, 0), 0);

            VirtualQuantumState quantumState = new VirtualQuantumState(q1, q2);
            VirtualQuantumState expected = new VirtualQuantumState(new Complex[] {
                Complex.Zero,
                Complex.Zero,
                Complex.Zero,
                new Complex(1, 0) });

            Assert.AreEqual(expected, quantumState);
        }

    }

}
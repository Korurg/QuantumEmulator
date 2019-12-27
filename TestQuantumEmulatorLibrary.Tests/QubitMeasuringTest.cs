using System;
using System.Numerics;
using NUnit.Framework;
using QuantumEmulatorLibrary;
using static QuantumEmulatorLibrary.VirtualQuantumMachine;

namespace Tests
{
    public class QubitMeasuringTest
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void TestMeasuring0()
        {
            IVirtualQubit qubit = VirtualQubit.Zero();

            Assert.AreEqual(0, qubit.Measure());
        }

        [Test]
        public void TestMeasuring1()
        {
            IVirtualQubit qubit = VirtualQubit.One();

            Assert.AreEqual(1, qubit.Measure());
        }

        [Test]
        public void TestMeasuringAB()
        {
            IVirtualQubit qubit = new VirtualQubit(new Complex(Math.Sqrt(2), 0), new Complex(Math.Sqrt(2), 0));


            Assert.AreEqual(new Complex(Math.Sqrt(2), 0), qubit[0]);
            Assert.AreEqual(new Complex(Math.Sqrt(2), 0), qubit[1]);
        }
    }
}
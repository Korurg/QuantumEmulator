using System;
using System.Numerics;
using NUnit.Framework;
using QuantumEmulatorLibrary;

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
            Qubit qubit = Qubit.Zero;
            
            Assert.AreEqual(0,Qubit.Measure(qubit));
        }
        
        [Test]
        public void TestMeasuring1()
        {
            Qubit qubit = Qubit.One;
            
            Assert.AreEqual(1,Qubit.Measure(qubit));
        }

        [Test]
        public void TestMeasuringAB()
        {
            Qubit qubit = new Qubit(new Complex(Math.Sqrt(2),0), new Complex(Math.Sqrt(2),0));
            
            
            Assert.AreEqual(new Complex(Math.Sqrt(2),0),qubit.A);
            Assert.AreEqual(new Complex(Math.Sqrt(2),0),qubit.B);
        }
    }
}
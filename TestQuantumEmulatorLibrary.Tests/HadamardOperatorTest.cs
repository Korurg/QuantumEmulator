using NUnit.Framework;

namespace Tests
{
    public class HadamardOperatorTest
    {
        [SetUp]
        public void Setup()
        {
            
        }
        

        [Test]
        public void TestHadamardOperator()
        {
            IQuantumMachine machine = new VirtualQuantumMachine();
            IQubit[] qubits = machine.Initialize(8);
            


            HadamardOperator.Apply(qubits[1]);


            Assert.AreEqual(0,qubits[0].Measure());
        }
    }
}
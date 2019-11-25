namespace QuantumEmulatorLibrary
{
    public partial class VirtualQuantumMachine : IQuantumMachine
    {
        private VirtualQuantumState _quantumState;
        private IVirtualQubit[] _qubits;
        public void HadamardOperator(IQubit qubit)
        {
            var qub = qubit as IVirtualQubit;
            
        }

        public IQubit[] Initialize(int v)
        {
            _qubits = new VirtualQubit[v];

            for(int i=0;i<_qubits.Length;i++){

                    _qubits[i] = VirtualQubit.Zero(i);

            }

            _quantumState = new VirtualQuantumState(_qubits);

            return _qubits;
        }
    }
}
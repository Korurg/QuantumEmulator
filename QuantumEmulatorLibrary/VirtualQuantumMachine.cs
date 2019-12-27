using System.Collections.Generic;

namespace QuantumEmulatorLibrary {
    public partial class VirtualQuantumMachine : IQuantumMachine {
      
        private IVirtualQubit[] _qubits;

        private List<VirtualQuantumState> _states = new List<VirtualQuantumState>();

        public void HadamardOperator (IQubit qubit) {
            var qub = qubit as IVirtualQubit;

                        

        }

      
        public IQubit[] Initialize (int v) {
            _qubits = new VirtualQubit[v];

            for (int i = 0; i < _qubits.Length; i++) {
                _qubits[i] = VirtualQubit.Zero ();
            }

            for(int i=0;i<_qubits.Length;i++){
                _states.Add(_qubits[i].QuantumState);
            }


            return _qubits;
        }
    }
}
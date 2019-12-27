using System;
using System.Numerics;
using static QuantumEmulatorLibrary.VirtualQuantumMachine;

namespace QuantumEmulatorLibrary {
    public class VirtualQuantumState {
        private ComplexMatrix _state;

        public VirtualQuantumState (params Complex[] state) {
            _state = new ComplexMatrix (state);
        }

        public VirtualQuantumState (params IVirtualQubit[] qubits) {
            ComplexMatrix t = new ComplexMatrix (qubits[0].QuantumState._state);
            for (int i = 1; i < qubits.Length; i++) {
                t = ComplexMatrix.TensorProduct (t, new ComplexMatrix (qubits[i].QuantumState._state));
            }
            _state = t;
        }

        public Complex this [int position] {
            get {
                return _state[position];
            }
            set {
                _state[position] = value;
            }
        }

        public override bool Equals (object obj) {
            if (obj == null || GetType () != obj.GetType ()) {
                return false;
            }

            VirtualQuantumState state = obj as VirtualQuantumState;

            return state._state.Equals (this._state);
        }

        public override int GetHashCode () {
            return base.GetHashCode ();
        }

        public override string ToString () {
            string result = "";
            for (int i = 0; i < _state.Height; i++) {
                result += _state[i] + " ";
            }
            return result;
        }
    }
}
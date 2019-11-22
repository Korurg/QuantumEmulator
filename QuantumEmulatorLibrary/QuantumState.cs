using System;
using System.Numerics;

namespace QuantumEmulatorLibrary
{
    public class QuantumState
    {
        private ComplexMatrix _state;

        public QuantumState(params Complex[] state)
        {
            _state = new ComplexMatrix(state);
        }

        public QuantumState(params Qubit[] qubits)
        {
            ComplexMatrix t = new ComplexMatrix(qubits[0]);
            for (int i = 1; i < qubits.Length; i++)
            {
                t = ComplexMatrix.TensorProduct(t, new ComplexMatrix(qubits[i]));
            }
            _state = t;
        }



        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            QuantumState state = obj as QuantumState;


            return state._state.Equals(this._state);
        }


        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < _state.Height; i++)
            {
                result += _state[i] + " ";
            }
            return result;
        }
    }
}
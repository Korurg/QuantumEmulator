using System;
using System.Numerics;

namespace QuantumEmulatorLibrary
{
    public class QuantumState
    {
        private ComplexMatrix _state;

        public QuantumState(Complex[] state)
        {
            _state = new ComplexMatrix(state);
        }



        public QuantumState(params Qubit[] qubits)
        {
            _state = new ComplexMatrix(2, 1);
            _state[0] = qubits[0].A;
            _state[1] = qubits[0].B;
            //TODO: сделать все случаи
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
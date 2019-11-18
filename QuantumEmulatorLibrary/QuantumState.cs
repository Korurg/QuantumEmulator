using System;
using System.Numerics;

namespace QuantumEmulatorLibrary
{
    public class QuantumState
    {
        private Complex[] _state;

        public QuantumState(Complex[] state)
        {
            this._state = state;
        }

        public QuantumState(params Qubit[] qubits)
        {
            _state = new Complex[1 << qubits.Length];
        }



        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            QuantumState state = obj as QuantumState;

            if(state._state.Length!=_state.Length)
                return false;

            for (int i = 0; i < _state.Length; i++)
            {
                if(state._state[i]!=_state[i])
                    return false;
            }

            return true;
        }


        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString(){
            string result = "";
            for(int i=0;i<_state.Length;i++){
                result+=_state[i]+" ";
            }
            return result;
        }
    }
}
using System.Numerics;

namespace QuantumEmulatorLibrary
{
    public class ComplexVector
    {
        private Complex[] _vector;


        public int Length
        {
            get
            {
                return _vector.Length;
            }
        }

        public Complex this[int index]
        {
            get
            {
                return _vector[index];
            }
            set
            {
                _vector[index] = value;
            }
        }


        public ComplexVector(int size)
        {
            _vector = new Complex[size];
        }

        public ComplexVector(Complex[] complex)
        {
            this._vector = complex;
        }

        public ComplexVector(int[] integers)
        {
            _vector = new Complex[integers.Length];
            for (int i = 0; i < integers.Length; i++)
            {
                _vector[i] = integers[i];
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            ComplexVector vec = obj as ComplexVector;

            if (_vector.Length != vec._vector.Length)
                return false;

            for (int i = 0; i < _vector.Length; i++)
            {
                if (_vector[i] != vec._vector[i])
                    return false;
            }

            return true;
        }

        public override string ToString()
        {
            var result = "";

            for (int i = 0; i < _vector.Length; i++)
            {
                result += _vector[i] + " ";
            }

            return result;
        }


        public static ComplexVector TensorProduct(ComplexVector v1, ComplexVector v2)
        {
            ComplexVector v3 = new ComplexVector(v1.Length * v2.Length);

            for (int i = 0; i < v3.Length; i++)
            {
                v3[i] = v1[i / v1.Length] * v2[i % v2.Length];
            }


            return v3;
        }

    }
}
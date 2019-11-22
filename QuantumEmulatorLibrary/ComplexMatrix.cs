using System.Text;
using System.Numerics;
using System;

namespace QuantumEmulatorLibrary
{
    public class ComplexMatrix
    {
        private Complex[,] _values;

        private bool _transparent;

        public void Transparent()
        {
            _transparent = !_transparent;
        }

        public void T()
        {
            _transparent = !_transparent;
        }

        public int Width
        {
            get
            {
                return _transparent ? _values.GetLength(0) : _values.GetLength(1);
            }
        }

        public int Height
        {
            get
            {
                return _transparent ? _values.GetLength(1) : _values.GetLength(0);
            }
        }

        public Complex this[int i]
        {
            get
            {
                return _transparent ? _values[0, i] : _values[i, 0];
            }
            set
            {
                if (_transparent)
                {
                    _values[0, i] = value;
                }
                else
                {
                    _values[i, 0] = value;
                }
            }
        }
        public Complex this[int i, int j]
        {
            get
            {
                return _transparent ? _values[j, i] : _values[i, j];
            }
            set
            {
                if (_transparent)
                {
                    _values[j, i] = value;
                }
                else
                {
                    _values[i, j] = value;
                }
            }
        }

        public ComplexMatrix(int height, int width)
        {
            _values = new Complex[height, width];
        }

        public ComplexMatrix(int[,] values)
        {
            _values = new Complex[values.GetLength(0), values.GetLength(1)];

            for (int i = 0; i < values.GetLength(0); i++)
            {

                for (int j = 0; j < values.GetLength(1); j++)
                {
                    _values[i, j] = values[i, j];
                }

            }

        }

        public ComplexMatrix(Qubit q)
        {
            _values = new Complex[2, 1];
            _values[0, 0] = q.A;
            _values[1, 0] = q.B;
        }

        public static ComplexMatrix Multiplication(ComplexMatrix m1, ComplexMatrix m2)
        {
            ComplexMatrix result = new ComplexMatrix(m1.Height, m2.Width);
            for (int i = 0; i < m1.Height; i++)
            {
                for (int j = 0; j < m2.Width; j++)
                {
                    for (int k = 0; k < m1.Width; k++)
                    {
                        result[i,j]+=m1[i,k]*m2[k,j];
                    }
                }
            }
            return result;
        }

        public ComplexMatrix(Complex[] state)
        {
            this._values = new Complex[state.Length, 1];

            for (int i = 0; i < state.Length; i++)
            {
                _values[i, 0] = state[i];
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }


            ComplexMatrix m = obj as ComplexMatrix;

            if (this.Width != m.Width || this.Height != m.Height)
                return false;


            for (int i = 0; i < this.Height; i++)
            {

                for (int j = 0; j < this.Width; j++)
                {
                    if (this[i, j] != m[i, j])
                        return false;
                }

            }


            return true;
        }

        public static ComplexMatrix TensorProduct(ComplexMatrix m1, ComplexMatrix m2)
        {
            ComplexMatrix result = new ComplexMatrix(m1.Height * m2.Height, m1.Width * m2.Width);

            for (int i = 0; i < result.Height; i++)
            {
                for (int j = 0; j < result.Width; j++)
                {
                    result[i, j] = m1[i / m1.Height, j / m2.Width] * m2[i % m2.Height, j % m2.Width];
                }
            }

            return result;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder("\r\n");
            for (int i = 0; i < this.Height; i++)
            {
                for (int j = 0; j < this.Width; j++)
                {
                    result.Append(this[i, j] + " ");
                }
                result.Append("\r\n");
            }

            return result.ToString();
        }
    }
}
using System.Numerics;

namespace QuantumEmulatorLibrary
{
    public class MathComplex
    {
        public static Complex Square(Complex complex)
        {
            return new Complex(complex.Real * complex.Real - complex.Imaginary * complex.Imaginary,
                2 * complex.Real * complex.Imaginary);
        }
    }
}
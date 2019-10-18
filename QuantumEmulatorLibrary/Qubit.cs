using System;
using System.Numerics;

namespace QuantumEmulatorLibrary
{
    public class Qubit
    {
        private static Random _random = new Random();

        private Complex _a;
        private Complex _b;

        public Complex A
        {
            get { return _a; }
        }

        public Complex B
        {
            get { return _b; }
        }


        public Qubit(Complex a, Complex b)
        {
            _a = a;
            _b = b;
        }


        public byte Measure()
        {
            return Qubit.Measure(this);
        }

        public static byte Measure(Qubit qubit)
        {
            double p1 = MathComplex.Square(qubit._a).Real;

            double p = _random.NextDouble();


            return p < p1 ? (byte)0 : (byte)1; 
        }

        public static Qubit Zero
        {
            get { return new Qubit(new Complex(1, 0), new Complex(0, 0)); }
        }

        public static Qubit One
        {
            get { return new Qubit(new Complex(0, 0), new Complex(1, 0)); }
        }
    }
}
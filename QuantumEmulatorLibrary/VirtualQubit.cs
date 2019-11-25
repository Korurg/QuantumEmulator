using System;
using System.Numerics;

namespace QuantumEmulatorLibrary
{

    public class VirtualQubit : IVirtualQubit
    {
        private static Random _random = new Random();

        private Complex _a;
        private Complex _b;
        private int _position;

        public Complex A
        {
            get { return _a; }
        }

        public Complex B
        {
            get { return _b; }
        }


        public VirtualQubit(Complex a, Complex b, int position)
        {
            _a = a;
            _b = b;
            _position = position;
        }


        public byte Measure()
        {
            return VirtualQubit.Measure(this);
        }

        public static byte Measure(VirtualQubit qubit)
        {
            double p1 = MathComplex.Square(qubit._a).Real;

            double p = _random.NextDouble();


            return p < p1 ? (byte)0 : (byte)1;
        }

        public static IVirtualQubit Zero(int position)
        {
            return new VirtualQubit(new Complex(1, 0), new Complex(0, 0), position);
        }

        public static IVirtualQubit One(int position)
        {
            return new VirtualQubit(new Complex(1, 0), new Complex(0, 0), position);
        }


        public int Position => _position;
    }

}
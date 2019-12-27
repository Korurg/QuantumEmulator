using System;
using System.Numerics;

namespace QuantumEmulatorLibrary {

    public class VirtualQubit : IVirtualQubit {
        private static Random _random = new Random ();

        private int _position = -1;
        public int Position => _position;

        private VirtualQuantumState _quantumState;
        public VirtualQuantumState QuantumState => _quantumState;

        public Complex this[int position]{
            get{
                return _quantumState[position];
            }
        }

        public VirtualQubit (Complex a, Complex b, int position) {
            _quantumState = new VirtualQuantumState (a, b);
            _position = position;
        }

        public VirtualQubit (Complex a, Complex b) {
            _quantumState = new VirtualQuantumState (a, b);
        }

        public byte Measure () {
            return VirtualQubit.Measure (this);
        }

        public static byte Measure (VirtualQubit qubit) {
            double p1 = MathComplex.Square (qubit._quantumState[0]).Real;

            double p = _random.NextDouble ();

            return p < p1 ? (byte) 0 : (byte) 1;
        }

        public static IVirtualQubit Zero () {
            return new VirtualQubit (new Complex (1, 0), new Complex (0, 0));
        }

        public static IVirtualQubit One () {
            return new VirtualQubit (new Complex (0, 0), new Complex (1, 0));
        }

        public static IVirtualQubit Zero (int position) {
            return new VirtualQubit (new Complex (1, 0), new Complex (0, 0), position);
        }

        public static IVirtualQubit One (int position) {
            return new VirtualQubit (new Complex (0, 0), new Complex (1, 0), position);
        }
    }

}
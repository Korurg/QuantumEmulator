using System.Numerics;

namespace QuantumEmulatorLibrary
{
    public interface IVirtualQubit : IQubit
    {
        Complex A { get; }
        Complex B { get; }

        int Position { get;}
    }
}
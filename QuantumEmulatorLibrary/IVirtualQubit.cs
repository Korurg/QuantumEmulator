using System.Numerics;

namespace QuantumEmulatorLibrary
{
    public interface IVirtualQubit : IQubit
    {
       int Position{get;}

       VirtualQuantumState QuantumState{get;}

       Complex this[int position]{get;}
    }
}
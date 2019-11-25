namespace QuantumEmulatorLibrary
{
    public interface IQuantumMachine
    {
        IQubit[] Initialize(int v);

        void HadamardOperator(IQubit qubit);
    }
}
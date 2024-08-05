namespace NorthSouthSystems.BitVectors.Bouncy;

public sealed partial class Vector : IBitVector<Vector>
{
    public bool this[int bitPosition] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public bool IsUnused => throw new NotImplementedException();

    public int Population => throw new NotImplementedException();

    public IEnumerable<bool> Bits => throw new NotImplementedException();

    public void AndInPlace(Vector vector)
    {
        throw new NotImplementedException();
    }

    public Vector AndOutOfPlace(Vector vector, bool resultIsCompressed)
    {
        throw new NotImplementedException();
    }

    public int AndPopulation(Vector vector)
    {
        throw new NotImplementedException();
    }

    public bool AndPopulationAny(Vector vector)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public void DecompressInPlace(Vector vector)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<int> GetBitPositions(bool value)
    {
        throw new NotImplementedException();
    }

    public bool OptimizeReadPhase(int[] bitPositionShifts, out Vector optimized)
    {
        throw new NotImplementedException();
    }

    public void OrInPlace(Vector vector)
    {
        throw new NotImplementedException();
    }
}
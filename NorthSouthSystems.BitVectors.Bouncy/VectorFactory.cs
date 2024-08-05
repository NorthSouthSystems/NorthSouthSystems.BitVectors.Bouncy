namespace NorthSouthSystems.BitVectors.Bouncy;

public class BouncyVectorFactory : IBitVectorFactory<Vector>
{
    public int WordSize => throw new NotImplementedException();

    public Vector Create(bool isCompressed)
    {
        throw new NotImplementedException();
    }

    public Vector Create(bool isCompressed, Vector copy)
    {
        throw new NotImplementedException();
    }

    public Vector CreateUncompressedUnion(params Vector[] bitVectors)
    {
        throw new NotImplementedException();
    }
}
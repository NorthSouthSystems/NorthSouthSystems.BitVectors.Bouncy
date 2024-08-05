namespace NorthSouthSystems.BitVectors.Bouncy;

public class VectorTestsConstruction
{
    [Fact]
    public void Construct()
    {
        new Vector().Should().NotBeNull();
    }
}
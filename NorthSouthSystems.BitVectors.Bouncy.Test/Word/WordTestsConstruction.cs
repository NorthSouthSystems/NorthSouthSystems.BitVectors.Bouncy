namespace NorthSouthSystems.BitVectors.Bouncy;

public class WordTestsConstruction
{
    [Fact]
    public void Construct()
    {
        new Word().Raw.Should().Be(0);
    }
}
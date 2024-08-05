namespace NorthSouthSystems.BitVectors.Bouncy;

internal struct Word
{
    public ulong Raw;

    public override readonly string ToString() => FormattableString.Invariant($"0x{Raw:X}");
}
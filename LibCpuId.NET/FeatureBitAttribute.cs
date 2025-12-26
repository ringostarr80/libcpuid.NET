using System;

namespace LibCpuId;

[AttributeUsage(AttributeTargets.All)]
public class FeatureBitAttribute(string abbreviation, string longName) : Attribute {
    public string Abbreviation { get; } = abbreviation;
    public string LongName { get; } = longName;
}

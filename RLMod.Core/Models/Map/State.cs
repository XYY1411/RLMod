﻿namespace RLMod.Core.Models.Map;

public sealed class State
{
    public ushort Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Manpower { get; set; }
    public string Category { get; set; } = string.Empty;
    public int[] Provinces { get; set; } = [];
    public VictoryPoint[] VictoryPoints { get; set; } = [];
}

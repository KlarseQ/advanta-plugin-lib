namespace ds.test.impl;

/// <summary>
/// Плагин для умножения.
/// </summary>
internal class MultiplierPlugin : Plugin
{
    public override string PluginName => nameof(MultiplierPlugin);
    
    public override string Version => "1.0";
    
#pragma warning disable CA1416
    public override Image Image => Image.FromFile(Path.Combine("Images", $"{PluginName}.jpg"));
#pragma warning restore CA1416
    
    public override string Description => "Умножение двух чисел";

    public override int Run(int input1, int input2) => input1 + input2;
}
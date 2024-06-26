namespace ds.test.impl;

/// <summary>
/// Плагин для деления.
/// </summary>
internal class DividingPlugin : Plugin
{
    public override string PluginName => nameof(DividingPlugin);
    
    public override string Version => "1.0";
    
#pragma warning disable CA1416
    public override Image Image => Image.FromFile(Path.Combine("Images", $"{PluginName}.jpg"));
#pragma warning restore CA1416
    
    public override string Description => "Деление двух чисел";

    public override int Run(int input1, int input2) => input1 is 0 ? throw new DivideByZeroException("Нельзя разделить 0 на число") : input1 / input2;
}
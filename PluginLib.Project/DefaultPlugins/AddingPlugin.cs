using System.Reflection;

namespace ds.test.impl;

/// <summary>
/// Плагин для сложения.
/// </summary>
internal class AddingPlugin : Plugin
{
    public override string PluginName => nameof(AddingPlugin);
    
    public override string Version => "1.0";
    
#pragma warning disable CA1416
    public override Image Image => Image.FromFile(Path.Combine($"{AppDomain.CurrentDomain.BaseDirectory}", "Images", $"{PluginName}.png"));
#pragma warning restore CA1416
    
    public override string Description => "Сложение двух чисел";

    public override int Run(int input1, int input2) => input1 + input2;
}
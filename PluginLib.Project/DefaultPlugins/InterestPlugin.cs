namespace ds.test.impl;

/// <summary>
/// Плагин для расчета процентов.
/// </summary>
internal class InterestPlugin : Plugin
{
    public override string PluginName => nameof(InterestPlugin);
    
    public override string Version => "1.0";
    
#pragma warning disable CA1416
    public override Image Image => Image.FromFile(Path.Combine($"{AppDomain.CurrentDomain.BaseDirectory}", "Images", $"{PluginName}.png"));
#pragma warning restore CA1416
    
    public override string Description => "Расчет процентов";

    public override int Run(int input1, int input2) => input1 * input2 / 100;
}
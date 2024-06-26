namespace ds.test.impl;

/// <summary>
/// Плагин для вычитания.
/// </summary>
internal class SubtractPlugin : Plugin
{
    public override string PluginName => nameof(SubtractPlugin);
    
    public override string Version => "1.0";
    
#pragma warning disable CA1416
    public override Image Image => Image.FromFile(Path.Combine($"{AppDomain.CurrentDomain.BaseDirectory}", "Images", $"{PluginName}.png"));
#pragma warning restore CA1416
    
    public override string Description => "Вычитание";

    public override int Run(int input1, int input2) => input1 - input2;
}
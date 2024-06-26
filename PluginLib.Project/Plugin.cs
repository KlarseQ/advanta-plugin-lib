namespace ds.test.impl;

/// <summary>
/// Абстрактный класс, реализующий интерфейс IPlugin.
/// </summary>
internal abstract class Plugin : IPlugin
{
    public virtual string PluginName => string.Empty;

    public virtual string Version => string.Empty;

#pragma warning disable CA1416
    public virtual Image Image => Image.FromFile(Path.Combine("Images", $"{PluginName}.jpg"));
#pragma warning restore CA1416

    public virtual string Description => string.Empty;
    
    public abstract int Run(int input1, int input2);
}
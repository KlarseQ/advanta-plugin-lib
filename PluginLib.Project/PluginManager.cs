namespace ds.test.impl;

/// <summary>
/// Класс для управления плагинами, реализующий интерфейс IPluginFactory.
/// </summary>
public class PluginManager : IPluginFactory
{
    private static readonly List<IPlugin> Plugins =
    [
        new AddingPlugin(), new DividingPlugin(),
        new InterestPlugin(), new MultiplierPlugin(),
        new SubtractPlugin()
    ];
    
    /// <summary>
    /// Количество плагинов.
    /// </summary>
    public int PluginsCount => Plugins.Count;

    /// <summary>
    /// Имена всех плагинов.
    /// </summary>
    public string[] GetPluginNames => Plugins.Select(s => s.PluginName).ToArray();

    /// <summary>
    /// Получить плагин по имени.
    /// </summary>
    /// <param name="pluginName">Имя плагина</param>
    /// <returns>Плагин</returns>
    public IPlugin GetPlugin(string pluginName) => Plugins.Find(f => f.PluginName == pluginName) ??
                                                   throw new NullReferenceException($"Плагин с именем {pluginName} не найден");
    
    /// <summary>
    /// Регистрация нового плагина.
    /// </summary>
    /// <param name="plugin">Плагин</param>
    public void RegisterPlugin(IPlugin plugin)
    {
        if (Plugins.Any(a => a.PluginName == plugin.PluginName))
            throw new Exception("Плагин с таким именем уже существует");

        Plugins.Add(plugin);
    }
}
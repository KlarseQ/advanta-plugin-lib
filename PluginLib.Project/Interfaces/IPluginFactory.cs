namespace ds.test.impl;

/// <summary>
/// Интерфейс для фабрики плагинов.
/// </summary>
public interface IPluginFactory
{
    /// <summary>
    /// Количество плагинов.
    /// </summary>
    public int PluginsCount { get; }

    /// <summary>
    /// Имена всех плагинов.
    /// </summary>
    public string[] GetPluginNames { get; }

    /// <summary>
    /// Получить плагин по имени.
    /// </summary>
    /// <param name="pluginName">Имя плагина</param>
    /// <returns>Плагин</returns>
    public IPlugin GetPlugin(string pluginName);
}

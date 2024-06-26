namespace ds.test.impl;

/// <summary>
/// Статический фасад для управления плагинами.
/// </summary>
public static class Plugins
{
    private static readonly PluginManager PluginManager = new PluginManager();
    
    /// <summary>
    /// Количество плагинов.
    /// </summary>
    public static int PluginsCount => PluginManager.PluginsCount;

    /// <summary>
    /// Имена всех плагинов.
    /// </summary>
    public static string[] GetPluginNames => PluginManager.GetPluginNames;

    /// <summary>
    /// Получить плагин по имени.
    /// </summary>
    /// <param name="pluginName">Имя плагина</param>
    /// <returns>Плагин</returns>
    public static IPlugin GetPlugin(string pluginName) => PluginManager.GetPlugin(pluginName);

    /// <summary>
    /// Регистрация нового плагина.
    /// </summary>
    /// <param name="plugin">Плагин</param>
    public static void RegisterPlugin(IPlugin plugin) => PluginManager.RegisterPlugin(plugin);
}
namespace ds.test.impl;

/// <summary>
/// Интерфейс для плагинов.
/// </summary>
public interface IPlugin
{
    /// <summary>
    /// Имя.
    /// </summary>
    public string PluginName { get; }
    
    /// <summary>
    /// Версия.
    /// </summary>
    public string Version { get; }
    
    /// <summary>
    /// Изображение.
    /// </summary>
    public Image Image { get; }
    
    /// <summary>
    /// Описание.
    /// </summary>
    public string Description { get; }

    /// <summary>
    /// Выполнение.
    /// </summary>
    public int Run(int input1, int input2);
}
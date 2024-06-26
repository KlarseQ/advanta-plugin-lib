using ds.test.impl;
using System.Drawing;

namespace PluginLib.Tests;

public class PluginsTests
{
    private readonly List<string> _defaultPluginsNames = ["AddingPlugin", "DividingPlugin", "InterestPlugin", "MultiplierPlugin", "SubtractPlugin"];
    
    [Fact]
    public void PluginsCount_ShouldBeTrue() =>
        Assert.True(Plugins.PluginsCount >= 5, "Количество плагинов должно быть не менее 5 (дефолтные)");

    [Fact]
    public void GetPluginNames_ShouldReturnCorrectNames() =>
        Assert.True(_defaultPluginsNames.All(a => Plugins.GetPluginNames.Contains(a)));
    
    [Fact]
    public void GetPlugin_ShouldReturnCorrectPlugin()
    {
        var firstPlugin = Plugins.GetPlugin(_defaultPluginsNames.First());
        var lastPlugin = Plugins.GetPlugin(_defaultPluginsNames.Last());

        Assert.NotNull(firstPlugin);
        Assert.Equal(_defaultPluginsNames.First(), firstPlugin.PluginName);
        Assert.NotNull(lastPlugin);
        Assert.Equal(_defaultPluginsNames.Last(), lastPlugin.PluginName);
    }
    
    [Theory]
    [InlineData(8, 8, 16)]
    [InlineData(0, 0, 0)]
    [InlineData(10, 5, 15)]
    [InlineData(-5, 5, 0)]
    public void AdditionPlugin_Run_ShouldReturnCorrectResult(int input1, int input2, int expectedResult)
    {
        var additionPlugin = Plugins.GetPlugin(_defaultPluginsNames.FirstOrDefault(f => f.Contains("Adding")) ?? string.Empty);

        var actualResult = additionPlugin.Run(input1, input2);

        Assert.Equal(expectedResult, actualResult);
    }
    
    [Theory]
    [InlineData(10, 2, 5)]
    [InlineData(100, 4, 25)]
    [InlineData(12, 6, 2)]
    public void DividingPlugin_Run_ShouldReturnCorrectResult(int input1, int input2, int expectedResult)
    {
        var dividingPlugin = Plugins.GetPlugin(_defaultPluginsNames.FirstOrDefault(f => f.Contains("Dividing")) ?? string.Empty);

        var actualResult = dividingPlugin.Run(input1, input2);

        Assert.Equal(expectedResult, actualResult);
    }
    
    [Fact]
    public void DividingPlugin_Run_ShouldReturnException()
    {
        var dividingPlugin = Plugins.GetPlugin(_defaultPluginsNames.FirstOrDefault(f => f.Contains("Dividing")) ?? string.Empty);

        Assert.Throws<DivideByZeroException>(() =>
        {
            dividingPlugin.Run(0, 10);
        });
    }
    
    [Theory]
    [InlineData(100, 10, 1000)]
    [InlineData(200, 20, 4000)]
    [InlineData(1000, 5, 5000)]
    [InlineData(1111, 0, 0)]
    public void MultiplierPlugin_Run_ShouldReturnCorrectResult(int input1, int input2, int expectedResult)
    {
        var multiplierPlugin = Plugins.GetPlugin(_defaultPluginsNames.FirstOrDefault(f => f.Contains("Multiplier")) ?? string.Empty);

        var actualResult = multiplierPlugin.Run(input1, input2);

        Assert.Equal(expectedResult, actualResult);
    }
    
    [Theory]
    [InlineData(1000, 10, 100)]
    [InlineData(500, 20, 100)]
    [InlineData(100, 5, 5)]
    public void InterestPlugin_Run_ShouldReturnCorrectResult(int input1, int input2, int expectedResult)
    {
        var interestPlugin = Plugins.GetPlugin(_defaultPluginsNames.FirstOrDefault(f => f.Contains("Interest")) ?? string.Empty);

        var actualResult = interestPlugin.Run(input1, input2);

        Assert.Equal(expectedResult, actualResult);
    }
    
    [Theory]
    [InlineData(10, 5, 5)]
    [InlineData(100, 20, 80)]
    [InlineData(50, 25, 25)]
    public void SubtractPlugin_Run_ShouldReturnCorrectResult(int input1, int input2, int expectedResult)
    {
        var subtractPlugin = Plugins.GetPlugin(_defaultPluginsNames.FirstOrDefault(f => f.Contains("Subtract")) ?? string.Empty);

        var actualResult = subtractPlugin.Run(input1, input2);

        Assert.Equal(expectedResult, actualResult);
    }
    
    [Fact]
    public void RegisterPlugin_ShouldAddPlugin()
    {
        var plugin = new CustomPlugin();

        Plugins.RegisterPlugin(plugin);

        Assert.Contains(plugin.PluginName, Plugins.GetPluginNames);
    }

    private class CustomPlugin : IPlugin
    {
        public string PluginName => nameof(CustomPlugin);
        public string Version => "1.1";
        public Image Image => null!;
        public string Description => "Плагин для тестирования";
        public int Run(int input1, int input2) => (input1 + input2) * 2;
    }
}
public sealed class AppConfig
{
    private static readonly Lazy<AppConfig> _instance = new(() => new AppConfig());

    private readonly Dictionary<string, string> _settings = new();

    private AppConfig() { }

    public static AppConfig Instance => _instance.Value;

    public void SetSetting(string key, string value)
    {
        _settings[key] = value;
    }

    public string? GetSetting(string key)
    {
        return _settings.TryGetValue(key, out var value) ? value : null;
    }
}

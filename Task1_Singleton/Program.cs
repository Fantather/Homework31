AppConfig config = AppConfig.Instance;
config.SetSetting("Theme", "Dark");
config.SetSetting("Language", "English");

Console.WriteLine(config.GetSetting("Theme"));
Console.WriteLine(config.GetSetting("Language"));

Console.WriteLine(ReferenceEquals(config, AppConfig.Instance));

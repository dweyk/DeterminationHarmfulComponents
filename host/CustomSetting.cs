namespace PhotoEditingService;

/// <summary>
///     Методы расширения ConfigureHostBuilder
/// </summary>
public static class CustomSetting
{
    /// <summary>
    ///     Использовать кастомный конфиг для приложения
    /// </summary>
    /// <param name="host">
    ///     Хост
    /// </param>
    public static void SetCustomSettings(this ConfigureHostBuilder host)
    {
        host.ConfigureAppConfiguration((context, configurationBuilder)
            => {
                configurationBuilder.AddJsonFile("custom.settings.json",
                    optional: true,
                    reloadOnChange: true);

                throw new VitaliyException();
            }
            );
    }
}

public class VitaliyException : Exception
{
    public override string Message => "Если ты ни на чем не стоишь, то ты упадешь бля от всего!";
}
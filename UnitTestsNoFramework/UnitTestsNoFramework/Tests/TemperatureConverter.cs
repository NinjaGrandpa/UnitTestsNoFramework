namespace UnitTestsNoFramework.Tests;

public class TemperatureConverter
{
    public decimal ConvertCelsiusToFahrenheit(decimal temperatureInCelsius)
    {
        var temperatureInFahrenheit = temperatureInCelsius * 1.8m + 32m;

        return temperatureInFahrenheit;
    }

    public decimal ConvertFahrenheitToCelsius(decimal temperatureInFahrenheit)
    {
        var temperatureInCelsius = decimal.Round((temperatureInFahrenheit - 32m) / 1.8m, 5);

        return temperatureInCelsius;
    }
}
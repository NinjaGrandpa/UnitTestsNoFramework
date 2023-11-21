using System.Reflection;
using UnitTestsNoFramework.Tests.Interfaces;

namespace UnitTestsNoFramework.Tests;

public class TemperatureConverter_Tests
{
    #region TemperatureConverter_ConvertCelsiusToFahrenheit
    public static void TemperatureConverter_ConvertCelsiusToFahrenheit_ReturnsThirtyTwoDegreesFahrenheit_FromZeroDegreesCelsius()
    {
        // Arrange
        var temperatureInCelsius = 0m;
        var temperatureInFahrenheit = 32m;

        var sut = new TemperatureConverter();

        // Act
        var output = sut.ConvertCelsiusToFahrenheit(temperatureInCelsius);

        // Assert
        var result = temperatureInFahrenheit == output;

        Console.WriteLine(new TestResult<decimal, decimal>
        {
            TestName = MethodBase.GetCurrentMethod().Name,
            Input = temperatureInCelsius,
            ExpectedOutput = temperatureInFahrenheit,
            Output = output,
            Result = result
        }.ToString());
    }

    public static void TemperatureConverter_ConvertCelsiusToFahrenheit_ReturnsThirtyThreePointEightDegreesFahrenheit_FromOneDegreeCelsius()
    {
        // Arrange
        var temperatureInCelsius = 1m;
        var expectedOutput = 33.8m;

        var sut = new TemperatureConverter();

        // Act
        var output = sut.ConvertCelsiusToFahrenheit(temperatureInCelsius);

        // Assert
        var result = output == expectedOutput;
        Console.WriteLine(new TestResult<decimal, decimal>
        {
            TestName = MethodBase.GetCurrentMethod().Name,
            Input = temperatureInCelsius,
            ExpectedOutput = expectedOutput,
            Output = output,
            Result = result
        }.ToString());
    }

    public static void TemperatureConverter_ConvertCelsiusToFahrenheit_ReturnsNegativeFourDegreesFahrenheit_FromNegativeTwentyDegreesCelsius()
    {
        // Arrange
        var temperatureInCelsius = -20m;
        var expectedOutput = -4m;

        var sut = new TemperatureConverter();

        // Act
        var output = sut.ConvertCelsiusToFahrenheit(temperatureInCelsius);

        // Assert
        var result = output == expectedOutput;
        Console.WriteLine(new TestResult<decimal, decimal>
        {
            TestName = MethodBase.GetCurrentMethod().Name,
            Input = temperatureInCelsius,
            ExpectedOutput = expectedOutput,
            Output = output,
            Result = result
        }.ToString());
    }

    #endregion

    #region TemperatureConverter_ConvertFahrenheitToCelsius

    public static void TemperatureConverter_ConvertFahrenheitToCelsius_ReturnsNegativeSeventeenPointSeventySevenThousandAndEightDegreesCelsius_FromZeroDegreesFahreneit()
    {
        // Arrange
        var temperatureInFahrenheit = 0m;
        var expectedOutput = -17.77778m;

        var sut = new TemperatureConverter();

        // Act
        var output = sut.ConvertFahrenheitToCelsius(temperatureInFahrenheit);

        // Assert
        var result = output == expectedOutput;
        Console.WriteLine(new TestResult<decimal, decimal>
        {
            TestName = MethodBase.GetCurrentMethod().Name,
            Input = temperatureInFahrenheit,
            ExpectedOutput = expectedOutput,
            Output = output,
            Result = result
        }.ToString());

    }

    public static void TemperatureConverter_ConvertFahrenheitToCelsius_ReturnsNegativeSeventeenPointTwentyTwoThousandTwoHundredAndTwentyTwoDegreesCelsius_FromOneDegreeFahrenheit()
    {
        // Arrange
        var temperatureInFahrenheit = 1m;
        var expectedOutput = -17.22222m;

        var sut = new TemperatureConverter();

        // Act
        var output = sut.ConvertFahrenheitToCelsius(temperatureInFahrenheit);

        // Assert
        var result = output == expectedOutput;
        Console.WriteLine(new TestResult<decimal, decimal>
        {
            TestName = MethodBase.GetCurrentMethod().Name,
            Input = temperatureInFahrenheit,
            ExpectedOutput = expectedOutput,
            Output = output,
            Result = result
        }.ToString());
    }

    #endregion
}
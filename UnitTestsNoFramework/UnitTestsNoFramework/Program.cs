using UnitTestsNoFramework.Tests;

#region Övning 1. - Enkel Strängmanipulation
// Uppgift: Implementera en metod InvertString som tar en sträng som input och returnerar dess inverterade version.

// Tester: Testa denna metod i Main-metod där du manuellt testar metoden med minst tre olika strängar och skriver ut resultatet samt förväntat resultat.

Console.WriteLine("Övning 1. - Enkel Strängmanipulation:\n");

DisplayTestResult(StringInverter_Tests.InvertString_WhenGivenString_ReturnsReverseString());
DisplayTestResult(StringInverter_Tests.InvertString_WhenGivenASecondString_ReturnsReverseString());
DisplayTestResult(StringInverter_Tests.InvertString_WhenGivenEmptyString_ReturnsEmptyString());

#endregion

#region Övning 2. - Calculator-funktioner
// Uppgift: Skapa en Calculator-klass med metoder för att utföra addition, subtraktion, multiplikation och division.

// Tester: Testa denna metod i Main-metod som testar varje räkneoperation med olika talpar och validerar resultatet mot förväntade värden.

Console.WriteLine("\nÖvning 2. - Calculator-funktioner:\n");

// Calculator_Add
Calculator_Tests.Calculator_Add_ReturnsThree_FromOneAndTwo();
Calculator_Tests.Calculator_Add_ReturnsFour_FromTwoAndTwo();
Calculator_Tests.Calculator_Add_ReturnsNegativeTwo_FromTwoAndNegativeFour();

// Calculator_Subtract
Calculator_Tests.Calculator_Subtract_ReturnsTwo_FromThreeAndOne();
Calculator_Tests.Calculator_Subtract_ReturnFourPointFour_FromEightPointEightAndFourPointFour();
Calculator_Tests.Calculator_Subtract_ReturnNegativeTen_FromNegativeFiveAndFive();

// Calculator_Multiply
Calculator_Tests.Calculator_Multiply_ReturnsEight_FromFourAndTwo();
Calculator_Tests.Calculator_Multiply_ReturnsZero_FromFiveAndZero();
Calculator_Tests.Calculator_Multiply_ReturnsMinusTwentyFour_FromSixAndNegativeFour();

// Calculator_Divide
Calculator_Tests.Calculator_Divide_ReturnThirtyTwo_FromSixtyFourAndTwo();
Calculator_Tests.Calculator_Divide_ReturnFifty_FromTwentyFiveAndPointFive();

#endregion

#region Övning 3. Sorteringalgoritm
// Uppgift: Implementera en metod SortArray som sorterar en array av heltal i stigande ordning.

// Tester: Testa denna metod i Main-metod där du testar sorteringsmetoden med olika datamängder och jämför den sorterade arrayen med en förväntad resultatarray.

Console.WriteLine("\nÖvning 3. - Sorteringsalgoritm:\n");

ArraySorter_Tests.ArraySorter_SortArray_ReturnsSortedArray_FromArrayOfLengthFive();
ArraySorter_Tests.ArraySorter_SortArray_ReturnsSortedArray_FromArrayOfLengthEight();
ArraySorter_Tests.ArraySorter_SortArray_ReturnsEmptyArray_FromEmptyArray();
ArraySorter_Tests.ArraySorter_SortArray_ReturnsSortedArray_FromListOfLengthTenWithNegativeNumbers();

#endregion

#region Övning 4. - Palindrom-checker
// Uppgift: Skriv en metod IsPalindrome som avgör om en given sträng är ett palindrom.

// Tester: Testa denna metod i Main med en uppsättning strängar som inkluderar kända palindromer och icke-palindromer för att validera metoden.

Console.WriteLine("\nÖvning 4. - Palindrom-checker:\n");

PalindromeChecker_Tests.PalindromeChecker_IsPalindrome_ReturnsTrue_FromStringLevel();
PalindromeChecker_Tests.PalindromeChecker_IsPalindrome_ReturnsFalse_FromStringPalindrome();
PalindromeChecker_Tests.PalindromeChecker_IsPalindrome_ReturnsTrue_FromStringWithCapitalFirstLetter();
PalindromeChecker_Tests.PalindromeChecker_IsPalindrome_ReturnsTrue_FromEmptyString();

#endregion

#region Övning 5. - Temperaturomvandling
//Uppgift: Utveckla en TemperatureConverter-klass med metoder för att konvertera temperatur mellan Celsius och Fahrenheit.

// Tester: Testa denna metod i Main för att testa dina konverteringsmetoder med flera temperaturvärden och kontrollera att de matchar de förväntade värdena.

Console.WriteLine("\nÖvning 5. - Temperaturomvandling:\n");

// TemperatureConverter_ConvertCelsiusToFahrenheit
TemperatureConverter_Tests
    .TemperatureConverter_ConvertCelsiusToFahrenheit_ReturnsThirtyTwoDegreesFahrenheit_FromZeroDegreesCelsius();
TemperatureConverter_Tests
    .TemperatureConverter_ConvertCelsiusToFahrenheit_ReturnsThirtyThreePointEightDegreesFahrenheit_FromOneDegreeCelsius();
TemperatureConverter_Tests
    .TemperatureConverter_ConvertCelsiusToFahrenheit_ReturnsNegativeFourDegreesFahrenheit_FromNegativeTwentyDegreesCelsius();

// TemperatureConverter_ConvertFahrenheitToCelsius
TemperatureConverter_Tests
    .TemperatureConverter_ConvertFahrenheitToCelsius_ReturnsNegativeSeventeenPointSeventySevenThousandAndEightDegreesCelsius_FromZeroDegreesFahreneit();
TemperatureConverter_Tests
    .TemperatureConverter_ConvertFahrenheitToCelsius_ReturnsNegativeSeventeenPointTwentyTwoThousandTwoHundredAndTwentyTwoDegreesCelsius_FromOneDegreeFahrenheit();

#endregion

void DisplayTestResult(bool result)
{
    Console.WriteLine("TestResult Result: " +  (result ? "PASSED" : "FAILED"));
}

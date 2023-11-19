using UnitTestsNoFramework.Tests;

#region Övning 1

// 1. Enkel strängmanipulation
// Uppgift: Implementera en metod InvertString som tar en sträng som input och returnerar dess inverterade version.
// Tester: Testa denna metod i Main-metod där du manuellt testar metoden med minst tre olika strängar och skriver ut resultatet samt förväntat resultat.

Console.WriteLine("Övning 1:\n");

DisplayTestResult(StringInverter_Tests.InvertString_WhenGivenString_ReturnsReverseString());
DisplayTestResult(StringInverter_Tests.InvertString_WhenGivenASecondString_ReturnsReverseString());
DisplayTestResult(StringInverter_Tests.InvertString_WhenGivenEmptyString_ReturnsEmptyString());

#endregion

#region Övning 2

// 2. Calculator-funktioner
// Uppgift: Skapa en Calculator-klass med metoder för att utföra addition, subtraktion, multiplikation och division.
// Tester: Testa denna metod i Main-metod som testar varje räkneoperation med olika talpar och validerar resultatet mot förväntade värden.

Console.WriteLine("\nÖvning 2\n");

// Calculator_Add
Calculator_Tests.Calculator_Add_ReturnsThree_FromOneAndTwo();
Calculator_Tests.Calculator_Add_ReturnsFour_FromTwoAndTwo();
Calculator_Tests.Calculator_Add_ReturnsNegativeTwo_FromTwoAndNegativeFour();

// Calculator_Subtract
Calculator_Tests.Calculator_Subtract_ReturnsTwo_FromThreeAndOne();
Calculator_Tests.Calculator_Subtract_ReturnFourPointFour_FromEightPointEightAndFourPointFour();
Calculator_Tests.Calculator_Subtract_ReturnNegativeTen_FromNegativeFiveAndFive();

// Calculator_Multiply
Calculator_Tests

#endregion

void DisplayTestResult(bool result)
{
    Console.WriteLine("Test Result: " +  (result ? "PASSED" : "FAILED"));
}

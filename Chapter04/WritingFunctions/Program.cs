﻿using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using static System.Console;
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//TimesTable(6);
/*decimal taxToPay = CalculateTax(149, "FR");
WriteLine($"You must pay {taxToPay} in tax.");*/

//RunCardinalToOrdinal();
//RunFactorial();
//RunFibImperative();
RunFibFunctional();

static void TimesTable(byte number)
{
    WriteLine(@"This is the {number} times table: ");
    for(int row = 1; row <= 12; row++)
    {
        WriteLine($"{row} x {number} = {row*number}");
    }
    WriteLine();
}

static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
{
    decimal rate = 0.0M;
    switch (twoLetterRegionCode)
    {
        case "CH":
            rate = 0.08M;
            break;
        case "DK":
        case "NO":
            rate = 0.25M;
            break;
        case "GB":
        case "FR":
            rate = 0.2M;
            break;
        case "HU":
            rate = 0.27M;
            break;
        case "OR":
        case "AK":
        case "MT":
            rate = 0.0M;
            break;
        case "ND":
        case "WI":
        case "ME":
        case "VA":
            rate = 0.05M;
            break;
        case "CA":
            rate = 0.0825M;
            break;
        default:
            rate = 0.06M;
            break;
    }
    return amount * rate;
}

///<summary>
///test
///Передайте 32-битное целое число, и оно будет преобразовано
///в его порядковый эквивалент.
///</summary>
///<param name="number">Number is cardinal value e.g. 1, 2, 3 and so on.</param>
///<returns>Number as an ordinal value e.g. 1st, 2nd, 3rd and so on.</returns>
static string CardinalToOrdinal(int number)
{
    int lastTwoDigits = number % 100;
    switch (lastTwoDigits)
    {
        case 11:
        case 12:
        case 13:
            return $"{number}th";
        default:
            int lastDigit = number % 10;
            string suffix = lastDigit switch
            {
                1 => "st",
                2 => "nd",
                3 => "rd",
                _ => "th"
            };
            return $"{number}{suffix}";
    }
}

static void RunCardinalToOrdinal()
{
    for(int number = 1; number<=40;  number++)
    {
        Write($"{CardinalToOrdinal(number)} ");
    }
    WriteLine();
}

static void RunFactorial(){
    for (int i = 1; i <= 14; i++)
    {
        try
        {
            WriteLine($"{i}! = {Factorial(i)}");
        }
        catch (System.OverflowException)
        {
            WriteLine($"{i}! is too big for a 32-bit integer.");
        }
    }
}

///<summary>dsf</summary>
///<param name="number">dfsdf</param>
static int Factorial(int number)
{
    if (number < 1) return 0;
    else if (number == 1) return 1;
    else
    {
        checked
        {
            return number * Factorial(number - 1);
        }
    }
    
}

static int FibImperative(int term)
{
    if (term == 1) return 0;
    else if (term == 2) return 1;
    else
    {
        return FibImperative(term-1) + FibImperative(term-2);
    }
}

static void RunFibImperative()
{
    for(int i=1;i<=30;i++)
    {
        WriteLine("The {0} term of the Fibonacci sequence is {1}.", CardinalToOrdinal(i), FibImperative(i));
    }
}

static int FibFunctional(int term) => term switch{
        1=> 0,
        2 =>1,
        _ => FibFunctional(term-1)+FibFunctional(term-2)
};

static void RunFibFunctional()
{
    for(int i = 1; i <= 30; i++)
    {
        WriteLine("The {0} term of the Fibbonaci sequence is {1}.", CardinalToOrdinal(i), FibFunctional(i));
    }
}
using static System.Console;
//See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

bool a = true;
bool b = false;

WriteLine($"AND|a    |b    ");
WriteLine($"a  |{a & a,-5}|{a & b,-5}");
WriteLine($"b  |{b & a,-5}|{b & b,-5}\n");

WriteLine($"OR |a    |b    ");
WriteLine($"a  |{a | a,-5}|{a | b,-5}");
WriteLine($"b  |{b | a,-5}|{b | b,-5}\n");

WriteLine($"XOR|a    |b    ");
WriteLine($"a  |{a ^ a,-5}|{a ^ b,-5}");
WriteLine($"b  |{b^a,-5}|{b^b,-5}\n");

WriteLine($"a & DoStuff() = {a & DoStuff()}");
WriteLine($"b & DoStuff() = {b & DoStuff()}\n");

WriteLine($"a && DoStuff() = {a && DoStuff()}");
WriteLine($"b && DoStuff() = {b && DoStuff()}");

static bool DoStuff()
{
    WriteLine("I am doing some stuff.");
    return true;
}
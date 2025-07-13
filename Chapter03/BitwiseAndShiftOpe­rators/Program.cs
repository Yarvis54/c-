using static System.Console;
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int a = 10; //00001010
int b = 6;  //00000110

WriteLine($"a = {a}");
WriteLine($"b = {b}");
WriteLine($"a & b = {a & b}");  //00000010
WriteLine($"a | b = {a | b}");  //00001110
WriteLine($"a ^ b = {a ^ b}\n");//00001100

WriteLine($"a << 3 = {a << 3}");
WriteLine($"a * 8 = {a * 8}");
WriteLine($"b >> 1 = {b >> 1}");
WriteLine($"b / 2 = {b / 2}\n");

WriteLine("Outputting integers as binary:");
WriteLine($"a =     {ToBinaryString(a)}");
WriteLine($"b =     {ToBinaryString(b)}");
WriteLine($"a & b = {ToBinaryString(a & b)}");
WriteLine($"a | b = {ToBinaryString(a | b)}");
WriteLine($"a ^ b = {ToBinaryString(a ^ b)}");

static string ToBinaryString(int value)
{
    return Convert.ToString(value,toBase:2).PadLeft(8, '0');
}
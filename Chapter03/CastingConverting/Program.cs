using static System.Console;
using static System.Convert;
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int a = 10;
double b = a;
WriteLine(b);

double c = 9.8;
int d = (int)c;
WriteLine(d);

WriteLine();

long e = 10;
int f = (int)e;
WriteLine($"e is {e} and f is {f}");
e = long.MaxValue;
f = (int)e;
WriteLine($"e is {e} and f is {f}\n");

double g = 9.8;
int h = ToInt32(g);
WriteLine($"g is {g} and h is {h}\n");

double[] doubles = new[] { 9.49, 9.50, 9.51, 10.49, 10.50, 10.51 };
foreach(double n in doubles)
{
    WriteLine($"ToInt32({n}) is {ToInt32(n)}");
}

WriteLine();

foreach(double n in doubles)
{
    WriteLine("Math.Round({0},0,MidpointRound.AwayFromZero) is {1}", n, Math.Round(n, 0, MidpointRounding.AwayFromZero));
}

WriteLine();

int number = 12;
WriteLine(number.ToString());
bool boolean = true;
WriteLine(boolean.ToString());
DateTime now = DateTime.Now;
WriteLine(now.ToString());
object me = new();
WriteLine(me.ToString());

byte[] binaryObject = new byte[128];

(new Random()).NextBytes(binaryObject);
WriteLine("Binary Object as bytes:");

for(int index=0;index<binaryObject.Length;index++)
{
    Write($"{binaryObject[index]:X} ");
}
WriteLine();

string encoded = ToBase64String(binaryObject);

WriteLine($"Binary Object as Base64: {encoded}");

int age = int.Parse("27");
DateTime birthday = DateTime.Parse("4 July 1980");
WriteLine($"I was born {age} years ago.");
WriteLine($"My birthday is {birthday}.");
WriteLine($"My birthday is {birthday:D}.");

//int count = int.Parse("abc");

Write("How many eggs are there? ");
string? input = ReadLine(); // или используйте "12" в блокноте
if (int.TryParse(input, out int count))
{
    WriteLine($"There are {count} eggs.");
}
else
{
    WriteLine("I could not parse the input.");
}
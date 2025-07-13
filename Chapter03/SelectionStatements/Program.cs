using static System.Console;
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

string password = "ninja";

if(password.Length < 8)
{
    WriteLine("Your password is too short. Use at least 8 characters.");
}
else
{
    WriteLine("Your passwprd is strong.");
}

object o = 3;
int j = 4;
if(o is int i)
{
    WriteLine($"{i} x {j} = {i * j}");
}
else
{
    WriteLine("o is not an int so it cannot multiply!");
}
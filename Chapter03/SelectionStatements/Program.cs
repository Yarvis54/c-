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

WriteLine("\n\n\n");

/*int number = (new Random()).Next(1, 7);
WriteLine($"My random number id {number}");

switch(number)
{
    case 1:
        WriteLine("One");
        break;
    case 2:
        WriteLine("Two");
        goto case 1;
    case 3:
    case 4:
        WriteLine("Three or four");
        goto case 1;
    case 5:
        goto A_label;
    default:
        WriteLine("Default");
        break;
}
WriteLine("After end of switch");
A_label:
WriteLine($"After A_label");*/

string path = @"D:\pae\progging\c-\Chapter03";
Write("Press R for read-only or any other for writable: ");
ConsoleKeyInfo  key = ReadKey();
WriteLine();

Stream? s;

if(key.Key == ConsoleKey.R)
{
    s = File.Open(Path.Combine(path,"file.txt"),FileMode.OpenOrCreate,FileAccess.Read);
}
else
{
    s = File.Open(Path.Combine(path, "file.txt"), FileMode.OpenOrCreate, FileAccess.Write);
}

string message;

switch(s)
{
    case FileStream writeableFile when s.CanWrite:
        message = "The stream is a file that i can write to.";
        break;
    case FileStream readOnlyFile:
        message = "The stream is read-only file.";
        break;
    case MemoryStream ms:
        message = "The stream is a memory address.";
        break;
    default:
        message = "The stream is some other type.";
        break;
    case null:
        message = "The stream is null.";
        break;
}

WriteLine(message);
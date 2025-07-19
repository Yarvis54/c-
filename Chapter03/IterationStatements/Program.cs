using static System.Console;
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int x = 0;

while (x < 10)
{
    WriteLine(x);
    x++;
}

Console.WriteLine();

/*string? password;

x = 0;
do
{
    Write("Enter your password:");
    password = Console.ReadLine();
    
}while(password != "Pa$$word" && ++x<10);
if(x==10)
{
    WriteLine("Incorrect");
}
else
{
    WriteLine("Correct");
}*/

for(int y=1; y <= 10; y++)
{
    WriteLine(y);
}

Console.WriteLine();

string[] names = { "Adam", "Barry", "Charlie" };

foreach(string name in names)
{
    WriteLine($"{name} has {name.Length} characters.");
}
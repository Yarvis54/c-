using static System.Console;
using System.Diagnostics;
using Microsoft.Extensions.Configuration;
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Trace.Listeners.Add(new TextWriterTraceListener(File.CreateText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "log_test.txt"))));
Trace.AutoFlush = true;

Debug.WriteLine("Debug says, I am watching!");
Trace.WriteLine("Trace says, I am watching!");

ConfigurationBuilder builder = new();
builder.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", true, true);
IConfigurationRoot configuration = builder.Build();

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string response;
Console.WriteLine("What's your name?");
//Captures an answer from the keyboard
response = Console.ReadLine();
Console.WriteLine($"Enjoy the course, {response}");

//Displays information about the computer's SO 
OperatingSystem thisOS = Environment.OSVersion;
Console.WriteLine(thisOS.Platform);
Console.WriteLine(thisOS.VersionString);
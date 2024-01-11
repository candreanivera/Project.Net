// CONTAINS
string phrase = "the white Dog is very dangerous, The rat don't";

//To see if a string contains an argument
Console.WriteLine($"{phrase.Contains("dog")}");
//The same but ignoring uppercases
Console.WriteLine($"{phrase.Contains("dog", StringComparison.CurrentCultureIgnoreCase)}");

Console.WriteLine("------ Starts/Ends with ----------------------");

//STARTS WITH A GIVEN STRING
Console.WriteLine($"{phrase.StartsWith("The")}");
Console.WriteLine($"{phrase.StartsWith("the",StringComparison.CurrentCultureIgnoreCase)}");
//ENDS WITH A GIVEN STRING
Console.WriteLine($"{phrase.EndsWith("dangerous")}");

Console.WriteLine("------ INDEX OF ----------------------");

//INDEX OF: Search from beginning to end
Console.WriteLine($"{phrase.IndexOf("The")}");
Console.WriteLine($"{phrase.IndexOf("the",StringComparison.CurrentCultureIgnoreCase)}");
Console.WriteLine($"{phrase.IndexOf("word that don't exist")}");
//LAST INDEX OF: Search from end to beginning
Console.WriteLine($"{phrase.LastIndexOf("dangerous")}");

Console.WriteLine("------ WHITE / NULL ----------------------");

//HOW TO DETERMINE IF A STRING IS WHITE, NULL O HAS WHITESPACE IN IT
string string1 = null;
string string2 = "  "; 
string string3 = string.Empty;

Console.WriteLine($"{String.IsNullOrEmpty(string1)}");
Console.WriteLine($"{String.IsNullOrEmpty(string3)}");
Console.WriteLine($"{String.IsNullOrWhiteSpace(string2)}");
//S t r i n g  I n t e r p  o l a t i o n - Inserting data into strings

int a = 100;
float b = 250.0f;
string c = "CSharp";    

//Output of strings in the old way:
//The indexes inside the braces are replaced with the variables of the string
Console.WriteLine("The values are {0}, {1} and {2}", a, b, c);

//Using string interpolation ($)
Console.WriteLine($"The values are {a}, {b} and {c}");

//Expressions inside string interpolations
Console.WriteLine($"(a + b)/b is {(a + b)/b}");
Console.WriteLine($"{c} in upper-case is {c.ToUpper()}");

DateTime ahora = DateTime.Now;
Console.WriteLine($"Today is {ahora}");

//---------------------------------------------------------------------------------------------------------

//A L I N G  D A T A
float f1 = 123.4f;
int i1 = 2000;

//Float right align and interer left align: Index method
Console.WriteLine("{0, -40} {1, 10}", "Float Val", "Int Val");
Console.WriteLine("{0, -15} {1, 10}", f1, i1);

//Same exercise with interpolation
Console.WriteLine("{0, -40} {1, 10}", "Float Val", "Int Val");
Console.WriteLine($"{f1, -15} {i1, 10}");

//---------------------------------------------------------------------------------------------------------

//STRING MANIPULATION

string str1 = "The quick brown fox jump over the lazy dog";
string str2 = "This is a string";
string str3 = "THIS is a STRING";
string[] str4 = {"one", "two", "three","four"};

//Knowing the length of a string
Console.WriteLine($"The lenght of the string 1 is {str1.Length}");

//Accesing individual characters
Console.WriteLine($"The character 5 of the string2 is {str2[5]}");

// Iterate over a string to show its values
foreach(char ch in str1){
    Console.Write(ch);
    if(ch== 'b'){
        Console.WriteLine();
        break;
    }
}

//String concatenation
string outstr;
outstr = String.Concat(str4);
Console.WriteLine(outstr);

//Joining strings with join
outstr = string.Join('.', str4);
Console.WriteLine(outstr);
outstr = string.Join("---", str4);
Console.WriteLine(outstr);

//-------------------------------------------------------------------------------------------------------
//STRING COMPARISON
//EQUALS: returns a regular boolean
bool isEqual = str2.Equals(str3);
Console.WriteLine($"{isEqual}");
//Returns false

Console.WriteLine("------------------------------------------");

//COMPARES: byte comparison
// -1: first string comes before second in sort order
// 0: first and second strings are the same position in sort order
// 1: first string comes after the second in sort order

int result = string.Compare(str2, "This is a string");
Console.WriteLine($"Comparison 1: {result}");
//0, equals

int result2 = string.Compare(str2, "This is a String");
Console.WriteLine($"Comparison 2: {result2}");
//-1, str2 < Second

int result3 = string.Compare(str2, "this is a String");
Console.WriteLine($"Comparison 3: {result3}");
//1: second < str2

int result4 = string.Compare(str2, "little");
Console.WriteLine($"Comparison 4: {result4}");
//1: second < str2

int result5 = string.Compare(str2, "very long string that is longer than the first string");
Console.WriteLine($"Comparison 5: {result5}");
//-1; str2 < second

//------------------------------------------------------------------------------------
Console.WriteLine("------------------------------------------");
//REPLACE FUNCTION
//replacing the word fox for the word cat
string replacing = str1.Replace("fox", "cat");
Console.WriteLine($"{replacing}");

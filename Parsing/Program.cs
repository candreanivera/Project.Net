// Example file for parsing numerical data from strings

string[] NumStrs = {"  1 ", " 1.45  ", "-100", "5e+04 "};

int testint;
float testfloat;
bool result;

// The Parse method attempts to parse a string to a number and
// throws an exception if the parse is unsuccessful
// If the number can't be parsed, it throws a format exception
foreach (string str in NumStrs) {
    try {
        testfloat = float.Parse(str);
        Console.WriteLine($"Parsed number float is {testfloat}");
        testint = int.Parse(str);
        Console.WriteLine($"Parsed number int is {testint}");
    }
    catch (Exception e){
        Console.WriteLine($"Could not parse the string '{str}' : {e.Message}");
    }
}

//The TryParse method returns 'true' if the parse is successful
//Because the TryParse method returns a boolean, C# out variable must be used to get the result back
result = int.TryParse(NumStrs[0], out testint);
Console.WriteLine($"Result:{result} -- NumStrs[0]:{NumStrs[0]}=> {testint}");

//This time, working with float:
result = float.TryParse(NumStrs[1], out testfloat);
Console.WriteLine($"Result:{result} -- NumStrs[1]:{NumStrs[1]}=> {testfloat}");

result = int.TryParse(NumStrs[2], out testint);
Console.WriteLine($"Result:{result} -- NumStrs[2]:{NumStrs[2]}=> {testint}");

result = float.TryParse(NumStrs[3], out testfloat);
Console.WriteLine($"Result:{result} -- NumStrs[3]:{NumStrs[3]}=> {testfloat}");

//forcing a situation to fail:
result = int.TryParse(NumStrs[1], out testint);
Console.WriteLine($"Result:{result} -- NumStrs[1]:{NumStrs[1]}=> {testint}");


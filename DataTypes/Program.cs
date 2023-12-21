// Exercise file for LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for .NET Data Types

// Declare some types with values
int a = 1;
int b = default; //0 for ints
char c = 'A';
decimal d = 400.85m;
float f = 123.45f;
bool tf = default; //false for boolean

Console.WriteLine($"{a}, {b}, {tf}, {c}, {f}, {d}");

// implicit type conversion
Console.WriteLine($"{c + a}"); //Converts to int
Console.WriteLine($"{(char)(c + a)}"); // convert to char
Console.WriteLine($"{f + a}"); //converts to float
Console.WriteLine($"{f + c}"); //converts to float

// Create an instance of a struct (which is a value type)
s s1;
s1.a = 5;
s1.b = false;

// Perform an operation on a struct
void StructOp(s theStruct) {
    // Modify the struct properties inside the function
    theStruct.a = 10;
    theStruct.b = true;
    Console.WriteLine($"{theStruct.a}, {theStruct.b}");
}

Console.WriteLine("Structs are passed by copy, since they are value types:");
//it means: the original structure doesn't change, because only a copy goes to the function
Console.WriteLine($"{s1.a}, {s1.b}");
StructOp(s1);
Console.WriteLine($"{s1.a}, {s1.b}");

// TODO: Create an object instance of a class (which is a reference type)
MyClass Class1 = new MyClass{a = 5, b = false};

// Perform an operation on the class
void ClassOp(MyClass theClass) {
    // Modify some of the properties of the class inside the function
    theClass.a = 10;
    theClass.b = true;
    Console.WriteLine($"{theClass.a}, {theClass.b}");
}

Console.WriteLine("Objects are passed by reference, since they are reference types:");
// It means that the original value changes
Console.WriteLine($"{Class1.a}, {Class1.b}");
ClassOp(Class1);
Console.WriteLine($"{Class1.a}, {Class1.b}");

// These are declared at the bottom of the file because C# requires
// top-level statements to come before type declarations
class MyClass {
    public int a;
    public bool b;
}

struct s {
    public int a;
    public bool b;
}
//Variables with different types of data
int[] quarters = {1,2,3,4};
int[] sales = {100000, 150000, 200000, 225000};
double[] intlMixPct = {.386, .413, .421, .457};
int val1 = 1234;
decimal val2 = 1234.5678m;

// General format is {index[,alignment]:[format]}
// Common formatting types are N (Number), G (General), F (Fixed-point), 
// E (Exponential), D (Decimal), P (Percent), X (Hexadecimal),
// C (Currency in local format)

//Formatting of an integer:
Console.WriteLine($"{val1:D}, {val1:N}, {val1:F}, {val1:G}");
Console.WriteLine($"{val2:E}, {val2:N}, {val2:F}, {val2:G}");

//Adding a number after the format to specify precision
Console.WriteLine($"{val1:D5}, {val1:N6}, {val1:F8}, {val1:G9}");


// Formatting with alignment and spacing
//variable[],x ==> x is the number of spaces
//variable[],xC0 ==> currency. 0=no decimal points 
Console.WriteLine("Sales by Quarter:");
Console.WriteLine($"{quarters[0],12} {quarters[1],12} {quarters[2],12} {quarters[3],12}");
Console.WriteLine($"{sales[0],12:C0} {sales[1],12:C0} {sales[2],12:C2} {sales[3],12:C0}");
Console.WriteLine(" ");
//variable[],xP0 ==> percentage
Console.WriteLine("International Sales:");


//Using Regular Expressions
using System.Text.RegularExpressions;

string teststr1 = "The quick brown Fox jumps over the lazy Dog";
string teststr2 = "the quick brown fox jumps over the lazy dog";

//ISMATCH funtion: Gives true or false depending on the giving regular expression fits a regular pattern
//@indicates a literal string content

/*looking for an expression where any characters in the range A-Z are followed by
a non-white space word character
\: followed by -- Returns true or false
*/
Regex Cond_CapWords = new Regex(@"[A-Z]\w+");
Console.WriteLine(Cond_CapWords.IsMatch(teststr1));
Console.WriteLine(Cond_CapWords.IsMatch(teststr2));

//REGEX OPTION
//Case-insensitive searches

Regex NoCase = new Regex(@"fox", RegexOptions.IgnoreCase);
Console.WriteLine(NoCase.IsMatch(teststr1));

//The same but without the option IgnoreCase:
Regex NoCase2 = new Regex(@"fox");
Console.WriteLine(NoCase2.IsMatch(teststr1));


//Match
//calls the Match function over the Cond_capWords function. Returns a result,
//not true or false like IsMatch
Match m = Cond_CapWords.Match(teststr1);
while (m.Success){
    Console.WriteLine($"'{m.Value}' found at position {m.Index}");
    m = m.NextMatch();
}

//THE MATCHES: returns a collection of Match objects
MatchCollection mc = Cond_CapWords.Matches(teststr1);
Console.WriteLine($"Found {mc.Count} matches in the string");
foreach(Match match in mc){
    Console.WriteLine($"{match.Value} found at position {match.Index}");
}

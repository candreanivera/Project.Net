//RegEx Replacing

using System.Text.RegularExpressions;

string teststr1 = "The quick brown Fox jumps over the lazy Dog";

Regex CapitalWords = new Regex(@"[A-Z]\w+");

//Replacing capital words found with regex, with asteriscs
string result = CapitalWords.Replace(teststr1, "***");
Console.WriteLine($"Original : {teststr1}");
Console.WriteLine($"Resultado: {result}");


//MATCHEVALUATOR
//Takes a Match object as an argument and returns a string as a result
//If the first match starts the sentence, it is skipped
string MakeUpper(Match m){
    string s = m.ToString();
    Console.WriteLine(s);
    if (m.Index == 0){
        return s;
    }
    return s.ToUpper();
}

//The function replace will replace information on every match
string upperstr = CapitalWords.Replace(teststr1, new MatchEvaluator(MakeUpper) );
Console.WriteLine(teststr1);
Console.WriteLine(upperstr);


//RegEx Timeout

using System.Text.RegularExpressions;
using System.Diagnostics;

const string thestr = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
// Timeout value in milliseconds
const int MAX_REGEX_TIME = 1000;
// Use a Timeout value when executing RegEx to guard against bad input
//Timeout will be executed after 1 segundo (1000 milisegundos)
TimeSpan timeout = TimeSpan.FromMilliseconds(MAX_REGEX_TIME);

//using a Stopwatch to show elapsed time
Stopwatch sw;

try {
    sw = Stopwatch.StartNew();
    Regex CapWords = new Regex(@"(a+a+)+b", RegexOptions.None, timeout);
    MatchCollection mc = CapWords.Matches(thestr);
    sw.Stop();
    Console.WriteLine($"Found {mc.Count} matches in {sw.Elapsed} time:");
    foreach (Match match in mc) {
        Console.WriteLine($"'{match.Value}' found at position {match.Index}");
    }
}
catch (RegexMatchTimeoutException e) {
    Console.WriteLine($"The Regex took too long to execute! {e.MatchTimeout}");
}

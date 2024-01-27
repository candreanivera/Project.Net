//CREATING FILES

const string filename = "TestFile.txt";

// Creating a new file
// Using CreateText method of the File Class
using(StreamWriter sw = File.CreateText(filename)){
    sw.WriteLine("This is my first file in C#");
}


// DETERMINE IF A FILES EXISTS - FILE.EXISTS
const string filename2 = "TestFile2.txt";
Console.WriteLine($"File {filename2} exists: {File.Exists(filename2)}");

if(File.Exists(filename2)){
    File.Delete(filename2);
}else{  
  using(StreamWriter sw = File.CreateText(filename2)){
    sw.WriteLine("This is my second file in C#");
    }
}
Console.WriteLine($" file {filename2} exists: {File.Exists(filename2)}");



//WRITEALLTEXT: overwrites a file with the given content
const string filename3 = "TestFile3.txt";
if(!File.Exists(filename3)){
    File.WriteAllText(filename3, "Overwriting file");
}


//READLLTEXT: READS ALL THE CONTENT FROM A FILE
string content;
content = File.ReadAllText(filename3);
Console.WriteLine(content);


//APENDSALLTEXT: ADDS TEXT TO AN EXISTING FILE
File.AppendAllText(filename3, "\nThis is the new text for file 3");

content = File.ReadAllText(filename3);
Console.WriteLine(content);


//APPENDTEXT. A FILESTREAM CAN BE OPENED AND WRITTEN TO UNTIL CLOSED (don't overwrites)
using (StreamWriter sw = File.AppendText(filename3)){
    sw.WriteLine("Line 1");
    sw.WriteLine("Line 2");
    sw.WriteLine("Line 3");
}

content = File.ReadAllText(filename3);
Console.WriteLine(content);
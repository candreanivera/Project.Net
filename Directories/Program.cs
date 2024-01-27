//WORKING WITH DIRECTORIES

const string dirname = "TestDir";

//CREATING A DIRECTORY IF IT DOESN'T ALREADY EXISTS, OR DELETING
if(!Directory.Exists(dirname)){
    Directory.CreateDirectory(dirname);
}
else{
    Directory.Delete(dirname);
}


//GET THE PATH FOR THE CURRENT DIRETORY
string curpath = Directory.GetCurrentDirectory();
Console.WriteLine($"The current directory is: {curpath}");


//RETRIEVE INFORMATION ABOUT THE CURRENT DIRECTORY
DirectoryInfo di = new DirectoryInfo(curpath);
Console.WriteLine($"Directory Name       : {di.Name}");
Console.WriteLine($"Parent directory is  : {di.Parent}");
Console.WriteLine($"Creation Time        : {di.CreationTime}");


//ENUMERATE THE CONTENTS OF DIRECTORIES. All the directories inside another directory
Console.WriteLine("List of directories:");
List<string> thedirs = new List<string>(Directory.EnumerateDirectories(curpath));
foreach (string x in thedirs){
    Console.WriteLine(x);
}
Console.WriteLine("-----------------------");

//ENUMERATE THE CONTENTS OF DIRECTORIES. All the files inside another directory
Console.WriteLine("List of files:");
thedirs = new List<string>(Directory.EnumerateFiles(curpath));
foreach (string x in thedirs){
    Console.WriteLine(x);
}
Console.WriteLine("-----------------------");

//WORKING WITH DIRECTORIES AND FILES
Console.WriteLine("List of everything:");
thedirs = new List<string>(Directory.EnumerateFileSystemEntries(curpath));
foreach (string x in thedirs){
    Console.WriteLine(x);
}

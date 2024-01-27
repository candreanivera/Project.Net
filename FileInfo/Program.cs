//File information

const string filename = "TestFile.txt";

//MAKING SURE THAT THE FILE EXISTS
if(!File.Exists(filename)){
    using(StreamWriter sw = File.CreateText(filename)){
        sw.WriteLine("This is a text file");
    }
}

//GET INFORMATION ABOUT THE FILES
Console.WriteLine(File.GetCreationTime(filename));
Console.WriteLine(File.GetLastWriteTime(filename));
Console.WriteLine(File.GetLastAccessTime(filename));

//SETTING FILE ATTRIBUTES
File.SetAttributes(filename, FileAttributes.ReadOnly);
Console.WriteLine($"File attributes: {File.GetAttributes(filename)}");

//GENERAL INFORMATION USING FILEINFO
try{
    //An object of the FileInfo class must be created
    FileInfo fi = new FileInfo(filename);
    Console.WriteLine($"Length: {fi.Length} bytes");
    Console.WriteLine($"directory: {fi.Directory}");
    Console.WriteLine($"Is read only?: {fi.IsReadOnly}");
}
catch (Exception e){
    Console.WriteLine($"Exception: {e}");
}


//FILE INFORMATION CAN BE MANIPULATED
DateTime dt = new DateTime(2021, 12, 19);
File.SetCreationTime(filename, dt);
Console.WriteLine(File.GetCreationTime(filename));
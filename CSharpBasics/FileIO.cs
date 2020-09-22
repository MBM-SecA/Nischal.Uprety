using System;
using System.IO;
 
public class FileIO
{
    public void LearnFileHandeling()
    {
        string fileContent = File.ReadAllText(@"..\README.md");
        File.WriteAllText(@"../README.md", "Hello World!!");
        Console.Write(fileContent);
    }
    public void LearnFileInfo()
    {
        string fileName = "../README.md";
        FileInfo fileInfo = new FileInfo(fileName);
        var size = fileInfo.Length;
        var createdDate = fileInfo.CreationTime;
 
        Console.WriteLine($"Size of the file is : {size}");
        Console.WriteLine($"File is created on {createdDate}");
    }
    public void LearnDirectory()
    {
        string directoryName = "A";
        Directory.CreateDirectory(directoryName);
    }
}
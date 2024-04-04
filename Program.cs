// Patrik class 4 April 2024


// reading and writing to Files

/*
string fileName = "readme.dm";

if (File.Exists(fileName))
{
    using (StreamReader reader = new StreamReader(fileName))
    {
        string content = reader.ReadToEnd();
        Console.WriteLine("file contentes: ");
        Console.WriteLine(content);
    }
}
else
{
    Console.WriteLine("File not found!");
}
*/


// writing to files (and creating files)
// filename to wtire to 
using System.Linq.Expressions;

string fileName = "myText.txt";
// folder-name for the text files:
string folderName = "data";

// create a new folder:
Directory.CreateDirectory(folderName);

try {
        int num1 = 2;
        int num2 = 1;
        int result = num1 / num2;
    using (StreamWriter writer = new StreamWriter(folderName + "/" + fileName, append: true))
    {
        //writer.WriteLine("Hei Verden!");
        writer.Write("more ... ");
    }
}
catch(UnauthorizedAccessException)
{
    Console.WriteLine("you do NOT have access to write to this file!");
}

catch(System.DivideByZeroException)
{
    Console.WriteLine("Attempted to divide by zero.");
}
finally // finally block is for any cleanup (if needed)
{
    Console.WriteLine("All checks passed, all good to go ...");
}
// below here, we can run more code...

// String methods

// Error handling

/*
try
{
    int num1 = 2;
    int num2 = 0;
    int result = num1 / num2;
}
catch(System.DivideByZeroException)
{
    Console.WriteLine("you canntot divide by 0!");
}
*/
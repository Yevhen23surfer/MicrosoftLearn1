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
string fileName = "myText.txt";
// folder-name for the text files:
string folderName = "data";

// create a new folder:
Directory.CreateDirectory(folderName);

using (StreamWriter writer = new StreamWriter(folderName + "/" + fileName, append: true))
{
    //writer.WriteLine("Hei Verden!");
    writer.Write("more ... ");
}

// String methods

// Error handling
// Foundational C# with Microsoft
// - Work with Variable Data in C# Console Applications
// - - Modify the Content of Strings Using Built-In String Data Type Methods in C#


string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-","");
Console.WriteLine(message);
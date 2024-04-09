// Foundational C# with Microsoft
// - Work with Variable Data in C# Console Applications
// - - Module: Perform Operations on Arrays Using Helper Methods in C#

// Exercise - Discover Split() and Join()

string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
// string result = new string(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}
// Foundational C# with Microsoft
// - Work with Variable Data in C# Console Applications
// - - Module: Perform Operations on Arrays Using Helper Methods in C#

// Exercise - Complete a challenge to reverse words in a sentence

// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// // string result = new string(valueArray);
// string result = String.Join(",", valueArray);
// Console.WriteLine(result);

// string[] items = result.Split(',');
// foreach (string item in items)
// {
//     Console.WriteLine(item);
// }

string pangram = "the quick brown fox jumpes over the lazy dog";
string[] message = pangram.Split(' ');
string[] newMessage = new string[message.Length];

for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);    
}

string result = String.Join(" ", newMessage);
Console.WriteLine(result);
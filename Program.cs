string str = "The quick brown fox jumps over the lazy dog.";
// convert the massage into a char array
char[] charMessage = str.ToCharArray();
// Reverse the chars
Array.Reverse(charMessage);
int x = 0;
// count the o's
foreach (char i in charMessage) { if (i== 'o') { x++; } }
// convert it back to a string
string new_message = new string(charMessage);
// print it output
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");
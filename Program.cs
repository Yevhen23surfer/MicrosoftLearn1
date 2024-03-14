//Random random = new Random ();

// using System;

// class CoinFlip
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine((new Random()).Next(2) == 0 ? "Heads" : "Tails");
//     }
// }

Random coin = new Random();
int flip = coin.Next(0, 2);
Console.WriteLine((flip == 0) ? "heads" : "tails");
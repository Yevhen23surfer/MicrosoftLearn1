//Random random = new Random ();

using System;

class CoinFlip
{
    static void Main(string[] args)
    {
        Console.WriteLine((new Random()).Next(2) == 0 ? "Heads" : "Tails");
    }
}

// Foundational C# with Microsoft
// - Create C# methods that return values
// - - Exercise - Return arrays from methods

int target = 60;
int[] coins = new int [] {5, 5, 50, 25, 25, 10, 5};
int[] result = TwoCoins(coins, target);

int[] TwoCoins(int[] coins, int target)
{
    for (int curr = 0; curr < coins.Length; curr++)
    {
        for (int next = curr +1; next < coins.Length; next++)
        {
            if (coins[curr] + coins[next] == target)
            {
                return new int[]{curr, next};
            }
        }
    }

    return new int[0];
}

if (result.Length == 0)
{
    Console.WriteLine("No two coins make change");
}
else 
{
    Console.WriteLine($"Change found at positions {result[0]} and {result[1]}");
}
﻿// Foundational C# with Microsoft
// - Work with Variable Data in C# Console Applications
// - - Module: Perform Operations on Arrays Using Helper Methods in C#

// Create an arrey of pallets, then sort them
string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
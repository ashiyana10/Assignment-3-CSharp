using System.Collections;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        Dictionary<int,string> PrimeMinisterData = new Dictionary<int,string>();
        PrimeMinisterData.Add(1998, "Atal Bihari Vajpayee");
        PrimeMinisterData.Add(2014, "Narendra Modi");
        PrimeMinisterData.Add(2004, "Manmohan Singh");

        // Find the Prime minister of 2004.
        Console.WriteLine($"Prime minister of 2004: {PrimeMinisterData[2004]}");

        // Add the current prime minister in the dictionary.
        PrimeMinisterData.Add(2024, "Narendra Modi");

        // Sort the dictionary by year.
        var sortedDictionary = PrimeMinisterData.OrderBy(x=>x.Key);
        foreach (var kvp in sortedDictionary)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }
    }
}
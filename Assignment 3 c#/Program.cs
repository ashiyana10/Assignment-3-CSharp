using System.Collections;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        Dictionary<int,string> primeMinisterData = new Dictionary<int,string>();
        primeMinisterData.Add(1998, "Atal Bihari Vajpayee");
        primeMinisterData.Add(2014, "Narendra Modi");
        primeMinisterData.Add(2004, "Manmohan Singh");

        // Find the Prime minister of 2004.
        Console.WriteLine($"Prime minister of 2004: {primeMinisterData[2004]}");

        // Add the current prime minister in the dictionary.
        primeMinisterData.Add(2024, "Narendra Modi");

        // Sort the dictionary by year.
        var sortedDictionary = primeMinisterData.OrderBy(x=>x.Key);
        foreach (var kvp in sortedDictionary)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }
    }
}

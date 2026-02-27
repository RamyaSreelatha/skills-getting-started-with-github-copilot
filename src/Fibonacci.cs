using System;
using System.Collections.Generic;

/// <summary>
/// Generates the Fibonacci series up to n terms.
/// </summary>
public class Fibonacci
{
    /// <summary>
    /// Returns a list containing the first n Fibonacci numbers.
    /// </summary>
    public static IReadOnlyList<long> GenerateSeries(int n)
    {
        if (n <= 0)
            throw new ArgumentException("Number of terms must be greater than zero.", nameof(n));

        var series = new List<long>(n);
        long prev = 0, curr = 1;

        for (int i = 0; i < n; i++)
        {
            series.Add(prev);
            (prev, curr) = (curr, prev + curr);
        }

        return series;
    }

    public static void Main(string[] args)
    {
        int terms = 10;
        Console.WriteLine($"Fibonacci series (first {terms} terms):");
        Console.WriteLine(string.Join(", ", GenerateSeries(terms)));
    }
}

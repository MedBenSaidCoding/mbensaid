using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // 1. Create a generic list to store scores
        List<int> scoresList = new List<int>();

        // 2. Add scores for participants
        AddScores(scoresList, 78, 92, 85, 88, 95);

        // 3. Display the initial scores
        Console.WriteLine("Initial Scores:");
        DisplayScores(scoresList);

        // 4. Remove a specific score
        int scoreToRemove = 88;
        RemoveScore(scoresList, scoreToRemove);
        Console.WriteLine($"\nScores after removing {scoreToRemove}:");
        DisplayScores(scoresList);

        // 5. Remove a score at a specific index
        int indexToRemove = 1;
        RemoveScoreAt(scoresList, indexToRemove);
        Console.WriteLine($"\nScores after removing at index {indexToRemove}:");
        DisplayScores(scoresList);

        // 6. Clear all scores
        ClearScores(scoresList);
        Console.WriteLine("\nScores after clearing:");
        DisplayScores(scoresList);

        // 7. Add new scores after clearing
        AddScores(scoresList, 70, 85, 92);
        Console.WriteLine("\nNew Scores:");
        DisplayScores(scoresList);

        // 8. Sort scores in ascending order
        SortScores(scoresList);
        Console.WriteLine("\nScores after sorting:");
        DisplayScores(scoresList);
    }

    // Add scores to the list
    static void AddScores(List<int> scores, params int[] newScores)
    {
        scores.AddRange(newScores);
    }

    // Display information for a list of scores
    static void DisplayScores(List<int> scores)
    {
        foreach (var score in scores)
        {
            Console.WriteLine($"Score: {score}");
        }
    }

    // Remove a specific score from the list
    static void RemoveScore(List<int> scores, int scoreToRemove)
    {
        scores.Remove(scoreToRemove);
    }

    // Remove a score at a specific index from the list
    static void RemoveScoreAt(List<int> scores, int index)
    {
        if (index >= 0 && index < scores.Count)
        {
            scores.RemoveAt(index);
        }
    }

    // Clear all scores from the list
    static void ClearScores(List<int> scores)
    {
        scores.Clear();
    }

    // Sort scores in ascending order
    static void SortScores(List<int> scores)
    {
        scores.Sort();
    }
}

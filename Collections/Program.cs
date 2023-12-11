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

        // 4. Find and display the highest score
        int highestScore = FindHighestScore(scoresList);
        Console.WriteLine($"\nHighest Score: {highestScore}");

        // 5. Filter and display scores above a certain threshold
        int threshold = 90;
        List<int> highScores = FilterHighScores(scoresList, threshold);
        Console.WriteLine($"\nScores above {threshold}:");
        DisplayScores(highScores);
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

    // Find the highest score in the list
    static int FindHighestScore(List<int> scores)
    {
        return scores.Count > 0 ? scores.Max() : 0;
    }

    // Filter scores above a certain threshold
    static List<int> FilterHighScores(List<int> scores, int threshold)
    {
        return scores.Where(s => s > threshold).ToList();
    }
}

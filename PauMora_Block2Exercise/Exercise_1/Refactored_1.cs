using System;

public class MatchSummary
{
    public int Score;
    public int EnemiesKilled;
    public int TimePlayedInSeconds;  
}

public class PerformanceCalculator
{
    public float GetPerformance()
    {
        return Score / (float)(TimePlayedInSeconds + 1);
    } 
}

public class  Printer
{
    public string BuildSummaryText()
    {
        return $"Score: {Score} | Kills: {EnemiesKilled} | Performance: {GetPerformance()}";
    }
}

public interface IExporter
{
    void Export(MatchSummary summary);
}

public class JSONExporter : IExporter
{
    public void Export(MatchSummary summary)
    {
        Console.WriteLine("Exporting match summary to JSON...");
    }
}

public class  XMLExporter : IExporter
{
    public void Export(MatchSummary summary)
    {
        Console.WriteLine("Exporting match summary to XML...");
    }
}

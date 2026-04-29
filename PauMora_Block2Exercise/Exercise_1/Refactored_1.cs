using System;

public class MatchSummary
{
    public int Score;
    public int EnemiesKilled;
    public int TimePlayedInSeconds;  
}

public class PerformanceReport
{
    public float GetPerformance()
    {
        return Score / (float)(TimePlayedInSeconds + 1);
    }

    public string BuildSummaryText()
    {
        return $"Score: {Score} | Kills: {EnemiesKilled} | Performance: {GetPerformance()}";
    }

}

public class Exporter
{
    public void ExportToJson()
    {
        Console.WriteLine("Exporting match summary to JSON...");
    }

    public void ExportToXml()
    {
        Console.WriteLine("Exporting match summary to XML...");
    }
}

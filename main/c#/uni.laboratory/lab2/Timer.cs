
using main.c_.uni.laboratory.lab2;

namespace main.c_.uni.laboratory;

public class Timerr
{
    private static Dictionary<string, DateTime> changingFileState; 
    private static DateTime snapshotTime;
    
    public void live_tracking_change()
    {
        LiveCommit();
        while (true)
        {
            Thread.Sleep(5000);
            LiveStatus();
            LiveCommit();
            
        }
    }
    
    private static void LiveCommit()
    {
        InitializeFileState();
        snapshotTime = DateTime.Now;
    }

    private static void InitializeFileState()
    {
        changingFileState = Directory.GetFiles(Check.folderPath)
            .ToDictionary(Path.GetFileName, file => File.GetLastWriteTime(file));
    }

    private static void LiveStatus()
    {
        var currentFileState = Directory.GetFiles(Check.folderPath)
            .ToDictionary(Path.GetFileName, file => File.GetLastWriteTime(file));

        foreach (var entry in currentFileState)
        {
            if (!changingFileState.ContainsKey(entry.Key))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{entry.Key} - New File");
                Console.ResetColor();
            }
            else if (entry.Value > snapshotTime)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{entry.Key} - Changed");
                Console.ResetColor();
            }
        }

        foreach (var entry in changingFileState)
        {
            if (!currentFileState.ContainsKey(entry.Key))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{entry.Key} - Deleted");
                Console.ResetColor();
            }
        }
    }
    
}
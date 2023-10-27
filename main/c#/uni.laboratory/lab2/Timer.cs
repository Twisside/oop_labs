
using main.c_.uni.laboratory.lab2;

namespace main.c_.uni.laboratory;

public class Timerr
{
    private static Dictionary<string, DateTime> changingFileState; 
    private static DateTime snapshotTime;
    
    public void live_tracking_change()
    {
        LiveCommit();
        liveStatus();
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

    private static void liveStatus()
    {
        var currentFileState = Directory.GetFiles(Check.folderPath)
            .ToDictionary(Path.GetFileName, file => File.GetLastWriteTime(file));

        foreach (var entry in currentFileState)
        {
            if (!changingFileState.ContainsKey(entry.Key))
            {
                Console.WriteLine($"{entry.Key} - New File");
            }
            else if (entry.Value > snapshotTime)
            {
                Console.WriteLine($"{entry.Key} - Changed");
            }
        }

        foreach (var entry in changingFileState)
        {
            if (!currentFileState.ContainsKey(entry.Key))
            {
                Console.WriteLine($"{entry.Key} - Deleted");
            }
        }
    }
    
}
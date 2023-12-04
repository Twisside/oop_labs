using System.Diagnostics;
using System.Reflection.Metadata;
using main.c_.uni.laboratory.lab2;
using Document = main.c_.uni.laboratory.lab2.Document;

namespace main.c_.uni.laboratory;

public class Timer : ParentTrack
{
    private static Dictionary<string, DateTime>? _changingFileState;
    private static DateTime _snapshotTime;

    public void tracking_change()
    {
        
        Commit();
        while (true)
        {
            Thread.Sleep(5000);
            Status();
            Commit();
            
        }
    }
    
    public override void Commit()
    {
        InitializeFileState();
        _snapshotTime = DateTime.Now;
    }


    protected override void InitializeFileState()
    {
         _changingFileState = Directory.GetFiles(FolderPath)
            .Select(file =>
            {
                Document document;
                switch (Path.GetExtension(file))
                {
                    case ".txt":
                    {
                        document = new TextFile();
                        break;
                    }
                    case ".png":
                    {
                        document = new ImageFile();
                        break;
                    }
                    case ".jpg":
                    {
                        document = new ImageFile();
                        break;
                    }
                    default:
                        document = new Document(); // Or handle other file types accordingly
                        break;
                }

                return new
                {
                    FileName = Path.GetFileName(file), LastWriteTime = File.GetLastWriteTime(file), Document = document
                };
            })
            .Where(entry => entry.Document != null) // Filter out null entries
            .ToDictionary(entry => entry.FileName, entry => entry.LastWriteTime);
         
         
    }

    protected override void Status()
    {
        Dictionary<string, DateTime> currentFileState = Directory.GetFiles(FolderPath)
            .Select(file =>
            {
                Document document;
                switch (Path.GetExtension(file))
                {
                    case ".txt":
                    {
                        document = new TextFile();
                        break;
                    }
                    case ".png":
                    {
                        document = new ImageFile();
                        break;
                    }
                    case ".jpg":
                    {
                        document = new ImageFile();
                        break;
                    }
                    default:
                        document = new Document(); // Or handle other file types accordingly
                        break;
                }
                return new { FileName = Path.GetFileName(file), LastWriteTime = File.GetLastWriteTime(file), Document = document };
            })
            .Where(entry => entry.Document != null) // Filter out null entries
            .ToDictionary(entry => entry.FileName, entry => entry.LastWriteTime);
         // in case it all brakes:
         // currentFileState = Directory.GetFiles(FolderPath)
         //     .ToDictionary(Path.GetFileName, file => File.GetLastWriteTime(file));

        foreach (var entry in currentFileState)
        {   
            
            if (!_changingFileState.ContainsKey(entry.Key))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{entry.Key} - New File");
                Console.ResetColor();
            }
            else if (entry.Value > _snapshotTime)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{entry.Key} - Changed");
                Console.ResetColor();
            }
            
        }
        

        foreach (var entry in _changingFileState)
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
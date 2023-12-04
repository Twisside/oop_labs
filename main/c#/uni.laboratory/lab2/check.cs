using System.Drawing;

namespace main.c_.uni.laboratory.lab2;

public class Check : ParentTrack
{
    private static DateTime _snapshotTime;
    private static Dictionary<string, DateTime>? _lastFileState; // key: filename, value: last modified time
    
    
    public void tracking_change()
    {
        InitializeFileState();
        _snapshotTime = DateTime.Now;

        string? choice;
        do
        {
            Console.WriteLine("Select an option: commit, info, status, exit");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "commit":
                    Commit();
                    break;
                case "info":
                    Console.WriteLine("Enter filename:");
                    string? filename = Console.ReadLine();
                    if (filename != null) Info(filename);
                    break;
                case "status":
                    Status();
                    break;
            }
        } while (choice != "exit");
    }

    protected override void InitializeFileState()
    {
        _lastFileState = Directory.GetFiles(FolderPath)
                .ToDictionary(Path.GetFileName, file => File.GetLastWriteTime(file));
    }

    public override void Commit()
    {
        InitializeFileState();
        _snapshotTime = DateTime.Now;
        Console.WriteLine("Snapshot time updated!");
    }
    
    // i dont really need this, do i
    
    private static void Info(string filename)
    {
        string extension = Path.GetExtension(filename);
        string fullPath = Path.Combine(FolderPath, filename);
        if (File.Exists(fullPath))
        {
            Console.WriteLine($"Name: {filename}");
            Console.WriteLine($"Extension: {Path.GetExtension(filename)}");
            Console.WriteLine($"Creation Time: {File.GetCreationTime(fullPath)}");
            Console.WriteLine($"Last Modified Time: {File.GetLastWriteTime(fullPath)}");
            if (extension == ".png" || extension == ".jpg" || extension == ".jpeg")
            {
                
                using(var image = new Bitmap(fullPath))
                {
                    var height = image.Height;
                    var width = image.Width;
                    Console.WriteLine("Dimentions:"+ height + "x" + width);
                }
            }else if (extension == ".txt")
            {
                var numberOfCharacters = File.ReadAllLines(fullPath).Sum(s => s.Length);
                Console.WriteLine("Number of characters: " + numberOfCharacters);
            }

        }
        else
        {
            Console.WriteLine("File not found!");
        }
    }

    protected override void Status()
    {
        Console.WriteLine($"Snapshot: {_snapshotTime}");
        var currentFileState = Directory.GetFiles(FolderPath)
            .ToDictionary(Path.GetFileName, file => File.GetLastWriteTime(file));
        
        foreach (var entry in currentFileState)
        {
            if (!_lastFileState.ContainsKey(entry.Key))
            {
                Console.WriteLine($"{entry.Key} - New File");
            }
            else if (entry.Value > _snapshotTime)
            {
                Console.WriteLine($"{entry.Key} - Changed");
            }
            else
            {
                Console.WriteLine($"{entry.Key} - Not Changed");
            }
        }

        foreach (var entry in _lastFileState)
        {
            if (!currentFileState.ContainsKey(entry.Key))
            {
                Console.WriteLine($"{entry.Key} - Deleted");
            }
        }
    }
}
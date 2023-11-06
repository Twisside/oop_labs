using System.Diagnostics.CodeAnalysis;

namespace main.c_.uni.laboratory.lab2;

public class Check
{
    protected static string folderPath = @"C:\Users\TwisSide\Documents\Files_oop\Files";
    private static DateTime snapshotTime;
    private static Dictionary<string, DateTime> lastFileState; // key: filename, value: last modified time
    
    
    public virtual void tracking_change()
    {
        InitializeFileState();
        snapshotTime = DateTime.Now;

        string choice;
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
                    string filename = Console.ReadLine();
                    Info(filename);
                    break;
                case "status":
                    Status();
                    break;
            }
        } while (choice != "exit");
    }

    private void InitializeFileState()
    {
        lastFileState = Directory.GetFiles(folderPath)
            .ToDictionary(Path.GetFileName, file => File.GetLastWriteTime(file));
    }

    protected virtual void Commit()
    {
        InitializeFileState();
        snapshotTime = DateTime.Now;
        Console.WriteLine("Snapshot time updated!");
    }
    
    // i dont really need this, do i
    
    private static void Info(string filename)
    {
        string fullPath = Path.Combine(folderPath, filename);
        if (File.Exists(fullPath))
        {
            Console.WriteLine($"Name: {filename}");
            Console.WriteLine($"Extension: {Path.GetExtension(filename)}");
            Console.WriteLine($"Creation Time: {File.GetCreationTime(fullPath)}");
            Console.WriteLine($"Last Modified Time: {File.GetLastWriteTime(fullPath)}");
        }
        else
        {
            Console.WriteLine("File not found!");
        }
    }

    private void Status()
    {
        Console.WriteLine($"Snapshot: {snapshotTime}");
        var currentFileState = Directory.GetFiles(folderPath)
            .ToDictionary(Path.GetFileName, file => File.GetLastWriteTime(file));
        
        foreach (var entry in currentFileState)
        {
            if (!lastFileState.ContainsKey(entry.Key))
            {
                Console.WriteLine($"{entry.Key} - New File");
            }
            else if (entry.Value > snapshotTime)
            {
                Console.WriteLine($"{entry.Key} - Changed");
            }
            else
            {
                Console.WriteLine($"{entry.Key} - Not Changed");
            }
        }

        foreach (var entry in lastFileState)
        {
            if (!currentFileState.ContainsKey(entry.Key))
            {
                Console.WriteLine($"{entry.Key} - Deleted");
            }
        }
    }
}
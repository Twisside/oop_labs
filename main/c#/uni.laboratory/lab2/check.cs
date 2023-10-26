namespace main.c_.uni.laboratory;

using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

public class Check
{
    private static string folderPath = @"C:\Users\TwisSide\Documents\Files_oop\Files";
    private static DateTime snapshotTime;
    private static Dictionary<string, DateTime> lastFileState; // key: filename, value: last modified time

    public void tracking_change()
    {
        InitializeFileState();
        snapshotTime = DateTime.Now;

        string choice;
        do
        {
            Console.WriteLine("Choose an option: commit, info, status, exit");
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

    private static void InitializeFileState()
    {
        lastFileState = Directory.GetFiles(folderPath)
            .ToDictionary(Path.GetFileName, file => File.GetLastWriteTime(file));
    }

    private static void Commit()
    {
        InitializeFileState();
        snapshotTime = DateTime.Now;
        Console.WriteLine("Snapshot time updated!");
    }

    private static void Info(string filename)
    {
        string fullPath = Path.Combine(folderPath, filename);
        if (File.Exists(fullPath))
        {
            Console.WriteLine($"Name: {filename}");
            Console.WriteLine($"Extension: {Path.GetExtension(filename)}");
            Console.WriteLine($"Creation Time: {File.GetCreationTime(fullPath)}");
            Console.WriteLine($"Last Modified Time: {File.GetLastWriteTime(fullPath)}");

            // Further checks for text, image or program files can be added similarly
        }
        else
        {
            Console.WriteLine("File not found!");
        }
    }

    private static void Status()
    {
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
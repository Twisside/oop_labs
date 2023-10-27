using System;
using System.IO;

namespace main.c_.uni.laboratory
{
    class Track // my disappointment is unmeasurable and my day is ruined... actually the whole past week
                // maybe it has something to do with the xml error stuff idk 
    {
        public void tracking_change_fail()
        {
            FileSystemWatcher watcher = new FileSystemWatcher(@"C:\Users\TwisSide\Documents\Files_oop\Files");
            
            watcher.Filter = "*.*";
            watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = true;
            
            watcher.NotifyFilter = NotifyFilters.Attributes
                                   | NotifyFilters.CreationTime
                                   | NotifyFilters.DirectoryName
                                   | NotifyFilters.FileName
                                   | NotifyFilters.LastAccess
                                   | NotifyFilters.LastWrite
                                   | NotifyFilters.Security
                                   | NotifyFilters.Size;

            
            watcher.Changed += OnChanged;
            watcher.Created += OnCreated;
            watcher.Deleted += OnDeleted;
            watcher.Error += OnError;
            

            Console.WriteLine($"{watcher.Path}");
            Console.Write("Press enter to exit.");
            Console.Read();
        }

        static void OnChanged(object sender, FileSystemEventArgs e)
        {
            if (e.ChangeType != WatcherChangeTypes.Changed)
            {
                return;
            }

            Console.WriteLine($"Changed: {e.FullPath}");
        }

        static void OnCreated(object sender, FileSystemEventArgs e)
        {
            string value = $"Created: {e.FullPath}";
            Console.WriteLine(value);
        }

        static void OnDeleted(object sender, FileSystemEventArgs e) =>
            Console.WriteLine($"Deleted: {e.FullPath}");
        

        static void OnError(object sender, ErrorEventArgs e) =>
            PrintException(e.GetException());

        static void PrintException(Exception? ex)
        {
            if (ex != null)
            {
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine("Stacktrace:");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine();
                PrintException(ex.InnerException);
            }
        }
    }
}
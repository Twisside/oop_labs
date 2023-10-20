
namespace main.c_.uni.laboratory
{
    class Track
    {
        internal void tracking_change()
        {
            using FileSystemWatcher watcher = new();

            // specify the directory to monitor
            watcher.Path = @"C:\Users\TwisSide\OneDrive - Technical University of Moldova\OOP\oop_labs\main\c#\uni.laboratory\lab2\Files";

            watcher.Created += new FileSystemEventHandler(OnFileCreated);

            watcher.EnableRaisingEvents = true;

            static void OnFileCreated(object source, FileSystemEventArgs e)
            {
                Console.WriteLine("File Created: {0}", e.FullPath);
            }

            Console.WriteLine($"Create a new file {watcher.Filter} in the {watcher.Path} to see the event handler.");
            Console.WriteLine("Press the return key to quit.");

            Console.ReadLine();
        }
    }
}
using System.Drawing;

namespace main.c_.uni.laboratory.lab2;

public class Document
{
    
    protected static string FolderPath = @"C:\Users\TwisSide\Documents\Files_oop\Files";
    private static string extension;
    
    private static void Info( string filename)
    {
        extension = Path.GetExtension(filename);
        string fullPath = Path.Combine(FolderPath, filename);
        if (File.Exists(fullPath))
        {
            Console.WriteLine($"Name: {filename}");
            Console.WriteLine($"Extension: {extension}");
            Console.WriteLine($"Creation Time: {File.GetCreationTime(fullPath)}");
            Console.WriteLine($"Last Modified Time: {File.GetLastWriteTime(fullPath)}");
            //if (extension == ".png" || extension == ".jpg" || extension == ".jpeg")
            //{
            //    
            //    using(var image = new Bitmap(fullPath))
            //    {
            //        var height = image.Height;
            //        var width = image.Width;
            //        Console.WriteLine("Dimentions:"+ height + "x" + width);
            //    }
            //}else if (extension == ".txt")
            //{
            //    var numberOfCharacters = File.ReadAllLines(fullPath).Sum(s => s.Length);
            //    Console.WriteLine("Number of characters: " + numberOfCharacters);
            //}

        }
        else
        {
               Console.WriteLine("File not found!");
        }
    }
}

namespace main.c_.uni.laboratory.lab2;

public class TextFile : Document
{
    
  

    static void TextInfo(string fullPath)
    {
        var extension = Path.GetExtension(fullPath);
        if (extension == ".txt")
        {
            var numberOfCharacters = File.ReadAllLines(fullPath).Sum(s => s.Length);
            Console.WriteLine("Number of characters: " + numberOfCharacters);
        }
    }
}
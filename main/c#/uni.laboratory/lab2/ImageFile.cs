using System.Drawing;

namespace main.c_.uni.laboratory.lab2;

public class ImageFile : Document
{
    
  
    static void InfoImage(string fullPath)
    {
        var extension = Path.GetExtension(fullPath);
        if (extension == ".png" || extension == ".jpg" || extension == ".jpeg")
        {

            using (var image = new Bitmap(fullPath))
            {
                var height = image.Height;
                var width = image.Width;
                Console.WriteLine("Dimentions:" + height + "x" + width);
            }
        }
    }
}
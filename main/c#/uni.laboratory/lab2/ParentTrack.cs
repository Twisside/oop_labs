namespace main.c_.uni.laboratory.lab2;

public abstract class ParentTrack
{
        protected static string FolderPath = @"C:\Users\TwisSide\Documents\Files_oop\Files";
        
        protected abstract void InitializeFileState();
        public abstract void Commit();
        protected abstract void Status();
        
        // name: Document/File - superclass
        // numele doc, extensia, data.
        // printInfo()
        
        // inherits from Document: ProgramFile, TextFile, ImageFIle.
        // ProgramFile: classCount methodCount and lines count
        // TextFile: wordCount, lineCount, charCount
        // ImageFile: width, height
        
        // Document doc;
        // switch (extensie)
        // doc = new ImageFile();
        
        // doc.printInfo();
        
        // doc.printInfo();
        
        
        /// other #
        // info @txt.txt
        // List.filter(txt.txt) -> Docuemnt.printInfo()
        
        // List Changed,
        // List added,
        // List deleted,
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextClassificationGUI.Foundation;
using System.Diagnostics;

namespace TextClassificationGUI.FileIO
{
    public class TextFile:FileAdapter
    {

        //const string PROJECTPATH = "C:\\Users\\allan\\source\\repos\\D21-Assignment2930\\res\\";
        string PROJECTPATH = Path.GetFullPath(@"..\..\..\..\res\");

        const string FOLDERA = "ClassA";
        const string FOLDERB = "ClassB";
        public TextFile(string fileType):base(fileType)
        {
            Console.WriteLine(PROJECTPATH);
        }
        public override List<string> GetAllFileNames(string folderName)
        {
            List<string> fileNames = new List<string>();
            string[] paths = Directory.GetFiles(PROJECTPATH + folderName, "*."+GetFileType());
           
            foreach (string path in paths)
            {
                fileNames.Add(path);
            }
            return fileNames;
        }

        public string GetFilePathA(string fileName)
        {
            return @PROJECTPATH + FOLDERA + "\\" + fileName + "."+base.GetFileType();
        }

        public override string GetAllTextFromFileA(string path)
        {
            string text = File.ReadAllText(path);

            return text;
        }

        public override string GetAllTextFromFileB(string path)
        {
            string text = File.ReadAllText(path);

            return text;
        }
    }
}

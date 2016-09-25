using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Manipulations
    {
        public string CreateFolder()
        {
            const string path = @"D:\ht4\";
            string folderName;

            do
            {
                folderName = Console.ReadLine();
            } while (string.IsNullOrEmpty(folderName));

            string pathWithFolderName = Path.Combine(path, folderName);
            if (!Directory.Exists(pathWithFolderName))
            {
                Directory.CreateDirectory(pathWithFolderName);
            }
            else
            {
                Console.WriteLine("Folder already exists!");
                CreateFolder();
            }

            return pathWithFolderName;

        }

        public void CreateFile(string pathToFile)
        {
            string fileName = Path.GetRandomFileName() + Guid.NewGuid().ToString() + ".txt";
            string pathWithFileName = "";

            if (fileName.Contains(".txt"))
            {
                pathWithFileName = Path.Combine(pathToFile, fileName);
                Console.WriteLine(pathWithFileName);
            }
            else
            {
                Console.WriteLine("File name doesn't contain .txt-extension!");
                CreateFile(pathToFile);
            }

            string copy = CopyFromExistingFile();
            PasteToFile(pathWithFileName,copy);
        }

        public string CopyFromExistingFile()
        {
            const string copyFrom = @"D:\ht4\copy.txt";
            string copy = "";

            using (StreamReader reader = new StreamReader(copyFrom))
            {
                for (int i = 0; i < 20; i++)
                {
                    copy += reader.ReadLine() + "\r\n" ;
                }
                reader.Close();
            }

            return copy;
        }

        public void PasteToFile(string pathWithFileName, string copy)
        {
            File.AppendAllText(pathWithFileName, copy);
        }

        public void Start()
        {
            string pathToFile = CreateFolder();
            CreateFile(pathToFile);
        }
    }
}

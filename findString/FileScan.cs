using System;

namespace Findstring
{
    public class FileLookup
    {
        private readonly string _folderPath;
        private readonly string _searchString;

        public FileLookup(string folderPath, string searchString)
        {
            _folderPath = folderPath;
            _searchString = searchString;
        }

        public void ScanFiles()
        {
            if (!Directory.Exists(_folderPath))
            {
                Console.WriteLine("The specified folder does not exist.");
                return;
            }

            var files = Directory.GetFiles(_folderPath);
            foreach (var file in files)
            {
                try
                {
                    string fileContent = File.ReadAllText(file);
                    if (fileContent.Contains(_searchString))
                    {
                        Console.WriteLine($"Present: {Path.GetFileName(file)}");
                    }
                    else
                    {
                        Console.WriteLine($"Absent: {Path.GetFileName(file)}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error reading file {Path.GetFileName(file)}: {ex.Message}");
                }
            }
        }
    }
}



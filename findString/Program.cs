
using Findstring;

namespace Findstring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the folder path:");
            string? folderPath = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(folderPath))
            {
                Console.WriteLine("Search string cannot be empty.");
                return;
            }

            Console.WriteLine("Enter the string to search for:");
            string? searchString = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(searchString))
            {
                Console.WriteLine("Search string cannot be empty.");
                return;
            }

            FileLookup scanner = new FileLookup(folderPath, searchString);
            scanner.ScanFiles();
        }
    }
}
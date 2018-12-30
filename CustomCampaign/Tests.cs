using System;
using System.IO;
using static CustomCampaign.SharedResources;

namespace CustomCampaign
{
    public static class Tests
    {
        public static void Execute()
        {
            File_Exists();
            File_Open();
        }

        private static void File_Exists() {
            Console.WriteLine("========== FILE::EXISTS | Test started ==========\n");

            string[] files = new string[] {
                $@"C:\file.bytes",
                $@"{LevelsFolder()}/WorkshopLevels/Test/",
                $@"{LevelsFolder()}/WorkshopLevels/Test/file.txt",
                $@"{LevelsFolder()}/WorkshopLevels/Test/file.bytes"
            };

            foreach (string file in files)
            {
                Console.WriteLine($"\n\nFile   : \"{file}\"");
                Console.WriteLine($"Exists : \"{File.Exists(file)}\"");
            }

            Console.WriteLine("\n\n\n========== FILE::EXISTS | Test ended ==========");

        }

        private static void File_Open()
        {
            Console.WriteLine("========== FILE::OPEN | Test started ==========\n\n\n");

            string file = @"c:\file.txt";


            using (StreamReader reader = new StreamReader(File.Open(file, FileMode.Open, FileAccess.Read, FileShare.Read)))
            {
                Console.WriteLine($"Displaying content of \"{file}\"\n\n");
                Console.WriteLine(reader.ReadToEnd());
            }


            Console.WriteLine("\n\n\n========== FILE::OPEN | Test ended ==========");

        }
    }
}

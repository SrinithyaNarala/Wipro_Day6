using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling_in_console
{
    internal class Program
    {
        public static void readdata()
        {
            FileStream fs = null;
            StreamReader sr = null;
            fs = new FileStream(@"D:\Wipro\Day6\FileHandling_in_console\Wipro.txt",
                FileMode.Open, FileAccess.Read);
            sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            //first try above then put 200 and begin it will come 
            // put 200 and say end nothing will come 
            // put -200 and say end from backward direction it will read 
            // here first take the psotion to begin and after leaving 100 read it okay 
            // in the same manner current psotion by default will be begining only so again it 
            // will go to begining as current and after leaving 100 prrint all 
            // now if i write end then cussor will go to end point and after 100 spaces it will read
            // where of course data 
            // wont be there so u can do -100 and say end then curose will go 100 inside from back side
            // and after that
            // we  will read so this is the logic          
            string str = sr.ReadLine();
            while (str != null)
            {
                Console.WriteLine($"{str}");
                str = sr.ReadLine();
            }
        }
        public static void writedata()
        {
            FileStream fs = new FileStream
                (@"D:\Wipro\Day6\FileHandling_in_console\Wipro.txt",
                FileMode.Append, FileAccess.Write);
            Console.WriteLine("enter something inside the file ");
            string input = Console.ReadLine();
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(input);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        public static void fileappend()
        {

            Console.WriteLine("Enter the file path where you want to save the text:");
            string filePath = Console.ReadLine();

            if (!string.IsNullOrEmpty(filePath))
            {
                try
                {
                    using (FileStream fs = new FileStream(filePath, FileMode.Append))
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        Console.WriteLine("Enter the text you want to append:");
                        string textToAppend = Console.ReadLine();

                        sw.Write(textToAppend);
                        sw.Flush();
                    }

                    Console.WriteLine("Text appended successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("No file path provided.");
            }
        }

        public static void filecopy()
        {
            Console.WriteLine("Enter the source file path:");
            string sourceFilePath = Console.ReadLine();

            if (File.Exists(sourceFilePath))
            {
                Console.WriteLine("Enter the destination file path:");
                string destinationFilePath = Console.ReadLine();

                try
                {
                    File.Copy(sourceFilePath, destinationFilePath, true);
                    Console.WriteLine("File copied successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while copying the file: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("The source file does not exist.");
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        public static void filedelete()
        {
            Console.WriteLine("Enter the file path you want to delete:");
            string filePath = Console.ReadLine();

            if (File.Exists(filePath))
            {
                Console.WriteLine($"Are you sure you want to delete {filePath}? (yes/no)");
                string confirmation = Console.ReadLine();

                if (confirmation?.ToLower() == "yes")
                {
                    try
                    {
                        File.Delete(filePath);
                        Console.WriteLine("File deleted successfully.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"An error occurred while deleting the file: {ex.Message}");
                    }
                }
                else
                {
                    Console.WriteLine("File deletion canceled.");
                }
            }
            else
            {
                Console.WriteLine("The file does not exist.");
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            //readdata();
            //writedata();
            //fileappend();
            //filecopy();
            filedelete();
            Console.ReadLine();
        }
    }
}

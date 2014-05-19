// Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
// Find in MSDN how to use System.IO.File.ReadAllText(…). Be sure to catch all possible exceptions and print user-friendly error messages.

using System;
using System.IO;
using System.Security;

namespace ReadFile
{
    class ReadFile
    {
        static void Main()
        {
            Console.Write("Enter path of the file: ");
            string path = Console.ReadLine();
            try
            {
                ReadFileMethod(path);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Directory not found!");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found!");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Invalid path!");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid path!");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The path is too long!");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Unauthorized Access!");
            }
            catch (SecurityException)
            {
                Console.WriteLine("Unauthorized Access!");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Invalid path format!");
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.Message);
            }
        }
        static void ReadFileMethod(string path)
        {
            string fileContent = File.ReadAllText(path);
            Console.WriteLine("Content:");
            Console.WriteLine(fileContent);
        }
    }
}
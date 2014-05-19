// Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores it the current directory.
// Find in Google how to download files in C#. Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.Net;

namespace DownloadFile
{
    class DownloadFile
    {
        static void Main()
        {
            string url = "http://i222.photobucket.com/albums/dd63/bassterror/";
            string file = "so-much-win-300x229_zps303da385.jpg";
            string fullAddress = url + file;
            WebClient webClient = new WebClient();
            try
            {
                webClient.DownloadFile(fullAddress, file);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Invalid adress");
            }
            catch (WebException)
            {
                Console.WriteLine("Invalid address or empty file.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Can't do simultaneous downloads.");
            }
            finally
            {
                webClient.Dispose();
            }
        }
    }
}
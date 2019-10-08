using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"C:\Users\Matthew Bowyer\Desktop\TestWrite\tes.txt");

                Console.WriteLine(content);
               
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine("Make sure the name of the File is named correctly: tes.txt ");
            }
            catch(DirectoryNotFoundException ex)
            {
                Console.WriteLine(@"Make sure the name of the Directory C:\TestWrite exists");

            }
            //catches the exception that occurs (Exception is the most general out of the exceptions
            catch (Exception ex)
            {
                Console.WriteLine("There was a problem!");
                // Shows the message of error that occured
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Finally is code to finalise 
                // Setting objhects to null
                //Closing database connections
                Console.WriteLine("Closing application now...");
            }

              
                Console.ReadLine();

        }
    }
}

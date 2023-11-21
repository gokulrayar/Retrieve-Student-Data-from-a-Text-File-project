using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retrieve_Student_Data_from_a_Text_File_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                string filePath = "F:\\.Net projects\\project-sl- 2\\Retrieve Student Data from a Text File/sampledata.txt";
                string[] lines = File.ReadAllLines(filePath);
                Console.WriteLine("Rainbow School Students Data:");

                foreach (var line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            Console.ReadKey();
        }
    }
}

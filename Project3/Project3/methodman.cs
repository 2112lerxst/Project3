using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    internal class methodman
    {
        //Sorting method to ask for user input.
        public static string Read(string input)
        {
            string val = " "; // Start with empty value for input
            string vvStr = Console.ReadLine();
            return val;
        } //Return value
          // Create a new input for the jagged array for the file.csv
          // {

        //  
        //  {
        //      
        //  }

        //https://code-maze.com/csharp-print-elements-of-an-array/ used this
        //https://www.techiedelight.com/print-an-array-csharp/ and this
        //Method to print array
        
        public static void printArra(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($" ==> {array[i]}");
            }
            Console.WriteLine("\n");
        }


        //Method to print jagged array taken as input from .csv file 
        //https://stackoverflow.com/questions/24094093/how-to-print-2d-array-to-console-in-c-sharp used this
        //Array is 2 dimensions so it needs 2 loops
        public static void printJagged(int[][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j]);
                }
            }
        }
        
        }
    }
//}

using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_1._3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program in C# to read n number of values in an array and display it in reverse order.
            //Test Data :
            //Input the number of elements to store in the array :3
            //Input 3 number of elements in the array :
            //element - 0 : 2
            //element - 1 : 5
            //element - 2 : 7
            //Expected Output:
            //The values store into the array are:
            //2 5 7
            //The values store into the array in reverse are :
            //7 5 2

            Console.WriteLine("Hello, World!");
            int[] numberArray = { 2, 5, 7 };
            Console.WriteLine("The values store into the array are:");
            for (int i = 0; i < numberArray.Length; i++)
            {
                Console.Write("element - " + i + " : " + numberArray[i] + "\n");
            }
            Console.WriteLine();
            Console.WriteLine("The values store into the array in reverse are :");
        
            for (int i = numberArray.Length-1, j = 0; j < numberArray.Length; i--, j++)
            {
                Console.Write("element - " + j + " : " + numberArray[i] + "\n");
            }
        }
    }

}

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
            Console.WriteLine("Input the number of elements to store in the array :");
            int numberOfElements = Convert.ToInt32(Console.ReadLine());
            int[] numberArray = new int[numberOfElements];
            Console.WriteLine("Input " + numberOfElements + " numbers in the array :");
            for (int i = 0; i < numberOfElements; i++)
            {
                Console.Write("number - " + (i+1) + " : ");
                numberArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The values store into the array are:");
            for (int i = 0; i < numberArray.Length; i++)
            {
                Console.Write("index - " + i + " : " + numberArray[i] + "\n");
            }
            Console.WriteLine();
            Console.WriteLine("The values store into the array in reverse are :");

            for (int i = numberArray.Length - 1, j = 0; j < numberArray.Length; i--, j++)
            {
                Console.Write("index - " + j + " : " + numberArray[i] + "\n");
            }
        }
    }

}

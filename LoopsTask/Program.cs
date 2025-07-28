using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.Threading.Tasks;

namespace LoopsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a number to print its multiplication table: \n");
                double number = Convert.ToDouble(Console.ReadLine());
                int i = 1;
                while (i <= 12)
                {
                    Console.WriteLine($">> {number}*{i} = {number * i} ");

                    i++;
                }
            }
        }
    }
}

using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ConditionTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter your mark(0-100): ");
            double mark = Convert.ToDouble(Console.ReadLine());
            if (mark > 90 && mark <= 100)
            {
                Console.WriteLine("\n your Grade: A ");
            }
            else if (mark > 80 && mark <= 89)
            {
                Console.WriteLine("\n your Grade: B ");
            }
            else if (mark > 70 && mark <= 79)
            {
                Console.WriteLine("\n your Grade: C ");
            }
            else if (mark > 60 && mark <= 69)
            {
                Console.WriteLine("\n your Grade: D ");
            }
            else if (mark < 60)
            {
                Console.WriteLine("\n your Grade: F ");
            }
            else
            {

                Console.WriteLine("\nPlease Enter the valid Mark");
            }
        }
    }
}

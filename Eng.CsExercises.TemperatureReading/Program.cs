using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureReading
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp;
          
            Console.Write("Choose a temperature and display a suitable message:\n");
            

            Console.Write("Choose a temperature: ");
            temp = Convert.ToInt32(Console.ReadLine());

            if (temp < 0)
            {
                string message = "Freezing weather";
                Console.WriteLine(message);
            }
            else if (temp < 10)
            {
                string message = "Very cold weather";
                Console.WriteLine(message);
            }
            else if (temp < 20)
            {
                string message = "Cold weather";
                Console.WriteLine(message);
            }
            else if (temp < 30)
            {
                string message = "Normal in Temp";
                Console.WriteLine(message);
            }
            else if (temp < 40)
            {
                string message = "It's hot";
                Console.WriteLine(message);
            }
            else if(temp > 40)
            {
                string message = "It's very hot";
                Console.WriteLine(message);
            }

            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LabConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int degrees;
            double radian;

            WriteLine("Enter an angel in degrees: ");
            degrees = Convert.ToInt32(ReadLine());

            radian = degrees * Math.PI / 180;

            WriteLine($"{degrees} degrees are equal to {radian} radians");
            ReadKey();
           
        }
    }
}

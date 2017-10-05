using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your height in inches: ");

            double height = Difference();
            
            if (height < 54)
            {
                Console.WriteLine("I'm sorry, you aren't tall enough to ride the Raptor. You need " + height + " more inches!" );
            }

        }



        static double Difference()
        {
            double height = double.Parse(Console.ReadLine());
            double heightDifference = 54 - height;

            return heightDifference;
        }
            




        
    }
}

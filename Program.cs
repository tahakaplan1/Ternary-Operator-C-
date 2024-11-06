using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ehliyet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age : ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Education Status");
            var education = Console.ReadLine();
            var decision = (age >= 18 && education == "High School" || education == "University") ? "You Can Get a Driving License" : "You Can't Get a Driving License";
            Console.WriteLine(decision);
            Console.ReadLine();


        }



    }
}

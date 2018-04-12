using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equality
{
    class Program
    {
        static void Main(string[] args)
        {
            Food banana = new Food("banana");
            Food banana2 = new Food("banana");
            Food chocolate = new Food("chocolate");

            Console.WriteLine(banana.Equals(chocolate));
            Console.WriteLine(banana.Equals(banana2)); // it is evaluating REFERENCE equality, not VALUE equality
        }
    }
}

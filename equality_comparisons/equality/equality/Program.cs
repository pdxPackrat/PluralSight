﻿using System;
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
            FoodItem banana = new FoodItem("banana");
            FoodItem banana2 = new FoodItem("banana");
            FoodItem chocolate = new FoodItem("chocolate");

            Console.WriteLine(banana.Equals(chocolate));
            Console.WriteLine(banana.Equals(banana2)); // Comparing a class is evaluating REFERENCE equality, not VALUE equality
            Console.WriteLine(banana.Equals(null));
            Console.WriteLine(object.Equals(null, banana));
            Console.WriteLine(object.Equals(null, null));
        }
    }
}

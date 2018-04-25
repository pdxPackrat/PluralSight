using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using equality.Classes;
using equality.Struct;

namespace equality
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            FoodItem banana = new FoodItem("banana");
            FoodItem banana2 = new FoodItem("banana");
            FoodItem chocolate = new FoodItem("chocolate");

            Console.WriteLine(banana.Equals(chocolate));
            Console.WriteLine(banana.Equals(banana2)); // Comparing a class is evaluating REFERENCE equality, not VALUE equality
            Console.WriteLine(banana.Equals(null));
            Console.WriteLine(object.Equals(null, banana));
            Console.WriteLine(object.Equals(null, null));


            Console.WriteLine("Now it is time for playing with the classes");

            Food apple = new Food("apple", FoodGroup.Fruit);
            CookedFood stewedApple = new CookedFood("stewed", "apple", FoodGroup.Fruit);
            CookedFood bakedApple = new CookedFood("baked", "apple", FoodGroup.Fruit);
            CookedFood stewedApple2 = new CookedFood("stewed", "apple", FoodGroup.Fruit);
            Food apple2 = new Food("apple", FoodGroup.Fruit);

            DisplayWhetherEqual(apple, stewedApple);
            DisplayWhetherEqual(stewedApple, bakedApple);
            DisplayWhetherEqual(stewedApple, stewedApple2);
            DisplayWhetherEqual(apple, apple2);
            DisplayWhetherEqual(apple, apple);
            */

            string apple = "apple";
            string pear = "pear";

            DisplayOrder(apple, pear);
            DisplayOrder(pear, apple);
            DisplayOrder(apple, apple);
            DisplayOrder(1, 3);
            DisplayOrder(5.5d, 4.5d);
        }

        static void DisplayWhetherEqual(Food food1, Food food2)
        {
            if (food1 == food2)
                Console.WriteLine(string.Format("{0,12} == {1}", food1, food2));
            else
                Console.WriteLine(string.Format("{0,12} != {1}", food1, food2));
        }

        static void DisplayOrder<T>(T x, T y) where T: IComparable<T>
        {
            int result = x.CompareTo(y);

            if (result == 0) // equal to
                Console.WriteLine("{0,12} = {1}", x, y);
            else if (result > 0) // greater than
                Console.WriteLine("{0,12} > {1}", x, y);
            else
                Console.WriteLine("{0,12} < {1}", x, y);
        }
    }
}

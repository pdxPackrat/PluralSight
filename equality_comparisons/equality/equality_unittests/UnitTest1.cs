using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using equality.Struct;
using equality.Classes;


namespace equality_unittests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CompareButtonObjects()
        {
            Button button1 = new Button
            {
                Text = "Click me now!"
            };

            Button button2 = new Button
            {
                Text = "Click me now!"
            };

            bool result = (button1 == button2); // we expect this to be FALSE because this is a reference-type object we are comparing

            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void CompareIntValues()
        {
            int three = 3;
            int threeAgain = 3;
            bool intCmp = (three == threeAgain);

            Assert.AreEqual(true, intCmp); // we expect TRUE because this is a value-type compare

        }
        [TestMethod]
        public void JustATest()
        {
            string name1 = "Johnny Appleseed ";
            string name2 = "Johnny Appleseed";

            bool result = (name1.Trim() == name2.Trim());

            Assert.AreEqual(true, result); // proving that if I trim both names, the comparison is equal

        }

        [TestMethod]
        public void TestFloatingPoint()
        {
            float six = 6.0000000f;
            float nearlySix = 6.0000001f;

            bool result = (six == nearlySix);

            Assert.AreEqual(true, result); // I would expect this to be false but it is true
        }

        [TestMethod]
        public void TestFloatingPointAdd()
        {
            float x = 5.05f;
            float y = 0.95f;

            Assert.AreEqual(6f, x + y);  // expect this to be true

        }

        [TestMethod]
        public void TestFloatingPointAddToBool()
        {
            float x = 5.05f;
            float y = 0.95f;

            bool result = (x + y == 6f);

            Assert.AreEqual(false, result); // you would expect it to be TRUE but it is FALSE 

        }

        [TestMethod]
        public void TestBoxing()
        {
            int i = 123;
            // the following line boxes i.
            object o = i;
            o = 123;
            i = (int)o;  // unboxing

            Assert.AreEqual(123, i); // checking if this behaves as expected 
        }

        [TestMethod]
        public void TestFoodClassEquality()
        {
            FoodItem banana = new FoodItem("banana");
            FoodItem banana2 = new FoodItem("banana");

            bool result = banana.Equals(banana2); //  with the changes to the equality override we can now prove that the two are equal

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestEqualityOpInheritance()
        {
            string str1 = "apple";
            string str2 = string.Copy(str1);

            bool resultRef = ReferenceEquals(str1, str2);  // Expected to be FALSE as this is a reference comparison
            bool resultMethod = str1.Equals(str2);  // Expected to be TRUE as this should be a value comparison
            bool resultOp = (str1 == str2);  // Expected to be TRUE as this should be a value comparison
            bool resultStatic = object.Equals(str1, str2);  // Expected to be FALSE as this is a reference comparison

            Assert.AreEqual(false, resultRef);
            Assert.AreEqual(true, resultMethod);
            Assert.AreEqual(true, resultOp);
            Assert.AreEqual(true, resultStatic);

        }

        [TestMethod]
        public void TestReferenceEqualsOnString()
        {
            string banana = "banana";
            string banana2 = string.Copy(banana);

            bool result = (ReferenceEquals(banana, banana2));

            Assert.AreEqual(false, result);  // I would expect in this case that banana and banana2 are two separate instances of a string
        }

        [TestMethod]
        public void TestIntIEquatable()
        {
            int three = 3;
            int threeAgain = 3;
            int four = 4;

            bool result = (three.Equals(threeAgain)); // expected to be TRUE
            bool result2 = (three.Equals(four));  // expected to be FALSE

            Assert.AreEqual(true, result);
            Assert.AreEqual(false, result2);
        }

        [TestMethod]
        public void TestOperatorOverload()
        {
            FoodItem banana = new FoodItem("banana", FoodType.Fruit);
            FoodItem banana2 = new FoodItem("banana", FoodType.Fruit);
            FoodItem chocolate = new FoodItem("chocolate", FoodType.Sweets);

            bool result1 = (banana == banana2);  // expect result to be TRUE
            Assert.AreEqual(true, result1);  // expect result to be TRUE

            bool result2 = (banana2 == chocolate); // expect result to be FALSE
            Assert.AreEqual(false, result2);  // expect result to be FALSE
            
            bool result3 = (banana == chocolate); // expect result to be FALSE
            Assert.AreEqual(false, result3);  // expect result to be FALSE
        }

        [TestMethod]
        public void TestFoodItemEqualsMethod()
        {
            FoodItem banana = new FoodItem("banana", FoodType.Fruit);
            FoodItem banana2 = new FoodItem("banana", FoodType.Fruit);
            FoodItem chocolate = new FoodItem("chocolate", FoodType.Sweets);

            bool result1 = banana.Equals(banana2);  // expect result to be TRUE
            Assert.AreEqual(true, result1);  // expect result to be TRUE

            bool result2 = banana2.Equals(chocolate); // expect result to be FALSE
            Assert.AreEqual(false, result2);  // expect result to be FALSE

            bool result3 = chocolate.Equals(banana); // expect result to be FALSE
            Assert.AreEqual(false, result3);  // expect result to be FALSE
        }

        [TestMethod]
        public void TestFoodEqualityAgainstCookedFood()
        {
            Food apple = new Food("apple", FoodGroup.Fruit);
            CookedFood stewedApple = new CookedFood("stewed", "apple", FoodGroup.Fruit);
            CookedFood bakedApple = new CookedFood("baked", "apple", FoodGroup.Fruit);
            CookedFood stewedApple2 = new CookedFood("stewed", "apple", FoodGroup.Fruit);
            Food apple2 = new Food("apple", FoodGroup.Fruit);

            bool result1 = ((Food)apple == (Food)stewedApple);  // false
            bool result2 = ((Food)stewedApple == (Food)bakedApple); // false
            bool result3 = ((Food)stewedApple == (Food)stewedApple2);  // true
            bool result4 = ((Food)apple == (Food)apple2);  // true
            bool result5 = ((Food)apple == (Food)apple);  // true

            Assert.AreEqual(false, result1);
            Assert.AreEqual(false, result2);
            Assert.AreEqual(true, result3);
            Assert.AreEqual(true, result4);
            Assert.AreEqual(true, result5);
        }
    }
}

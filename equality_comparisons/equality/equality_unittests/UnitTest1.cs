using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using equality;


namespace equality_unittests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CompareButtonObjects()
        {
            Button button1 = new Button();
            button1.Text = "Click me now!";

            Button button2 = new Button();
            button2.Text = "Click me now!";

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
            Food banana = new Food("banana");
            Food banana2 = new Food("banana");

            bool result = banana.Equals(banana2); // We WANT this to be TRUE

            Assert.AreEqual(true, result);

        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace EqualButton_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CompareReferenceEqualityButtons()
        {
			Button button1 = new Button();
			button1.Text = "Click me now!";

			Button button2 = new Button();
			button2.Text = "Click me now!";

            bool result = (button1 == button2);

            Assert.AreEqual(false, result);
        }
    }
}

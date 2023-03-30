
using UnitTest3;
namespace CalculateTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PositiveTest_Condition1() //a < 0 && c != 0
        {
            // Arrange
            double a = -1;
            double b = 2.0;
            double c = 3.5;
            double x = 0.5;
            double act = a * x * x + b + c;
            var calc = new Calculate();
            // Act
            calc.Calc(a, b, c, x);
            double initial = calc.GetResult();

            // Assert
            Assert.AreEqual(act, initial, 0.001);
        }

        [TestMethod]
        public void PositiveTest_Condition2() // a > 0 && c == 0
        {
            // Arrange
            double a = 2.0;
            double b = 2.0;
            double c = 0.0;
            double x = 2.0;
            double act = -a / (x - c);
            var calc = new Calculate();
            // Act
            calc.Calc(a, b, c, x);
            double initial = calc.GetResult();

            // Assert
            Assert.AreEqual(act, initial, 0.001);

        }

        [TestMethod]
        public void PositiveTest_Condition3_1() //else (example:a<0 && c==0)
        {
            // Arrange
            double a = -1;
            double b = 2.0;
            double c = 0.0;
            double x = 0.5;
            double act = a * (x + c);
            var calc = new Calculate();
            // Act
            calc.Calc(a, b, c, x);
            double initial = calc.GetResult();

            // Assert
            Assert.AreEqual(act, initial, 0.001);

        }


        [TestMethod]
        public void PositiveTest_Condition3_2() //else (example:a>0 && c!=0)
        {
            // Arrange
            double a = 1.5;
            double b = 4.0;
            double c = 2.0;
            double x = 2.5;
            double act = a * (x + c);
            var calc = new Calculate();
            // Act
            calc.Calc(a, b, c, x);
            double initial = calc.GetResult();

            // Assert
            Assert.AreEqual(act, initial, 0.001);

        }

        [TestMethod]
        public void NegativeTest_Condition1()
        {
            // Arrange
            double a = 1.5;
            double b = 2.0;
            double c = 3.5;
            double x = 0.5;
            double act = a * x * x + b + c;
            var calc = new Calculate();
            // Act
            calc.Calc(a, b, c, x);
            double initial = calc.GetResult();

            // Assert
            Assert.AreNotEqual(act, initial, 0.001);

        }

    }
}
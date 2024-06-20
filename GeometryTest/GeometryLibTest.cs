using GeometryLib;

namespace GeometryTest
{
    [TestClass]
    public class GeometryLibTest
    {
        [TestMethod]
        public void TestTriangleSquareIsValid()
        {
            Triangle triangle = new Triangle(3,4,5);

            Assert.AreEqual(6,triangle.GetSquare());

        }
        
        [TestMethod]
        public void TestTriangleSquareIsValid2()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(()=>new Triangle(30, 4, 5));
        }
        
        [TestMethod]
        public void TestIsRight()
        {
            Assert.IsTrue((new Triangle(3, 4, 5)).IsRight());
        }

        [TestMethod]
        public void TestCircleSquareIsValid()
        {
            Circle circle = new Circle(1);

            Assert.AreEqual(3.14f,circle.GetSquare());
        }

        [TestMethod]
        public void TestCircleCreateException()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Circle(0));
        }
    }
}



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
        public void TestCircleSquareIsValid()
        {
            Circle circle = new Circle(1);

            Assert.AreEqual(3.14f,circle.GetSquare());
        }
    }
}



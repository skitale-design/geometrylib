using GeometryLib;

namespace GeometryTest
{
    [TestClass]
    public class GeometryLibTest
    {
        [TestMethod]
        public void TestSquareIsValid()
        {
            Triangle triangle = new Triangle(3,4,5);

            Assert.AreEqual(6,triangle.GetSquare());

        }
    }
}



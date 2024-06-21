using GeometryLib;

namespace GeometryTest
{
    [TestClass]
    public class GeometryLibTest
    {
        [TestMethod]
        public void TestTriangleSquareIsValid()
        {
            Triangle triangle = new Triangle([3,4,5]);

            Assert.AreEqual(6,triangle.GetArea());

        }
        
        [TestMethod]
        public void TestTriangleSquareIsValid2()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(()=>new Triangle([30, 4, 5]));
        }
        
        [DataTestMethod]
        [DataRow(3,4,5,true)]
        [DataRow(4,4,5,false)]
        public void TestIsRight(float s1, float s2, float s3, bool expected)
        {
            Assert.AreEqual(expected,new Triangle([s1, s2, s3]).IsRight());
        }

        [TestMethod]
        public void TestCircleSquareIsValid()
        {
            Circle circle = new Circle([1]);

            Assert.AreEqual(3.14f,circle.GetArea());
        }

        [TestMethod]
        public void TestCircleCreateException()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Circle([0]));
        }
    }
}



using System.Numerics;
using Vector;

namespace TestVector3D
{
    [TestClass]
    public class TestVector3D
    {

        [TestMethod]
        public void TestAddition()
        {

            Vector3D A = new Vector3D(1, 2, 3);
            Vector3D B = new Vector3D(4, 5, 6);

            Vector3D C = A + B;

            Vector3D expected = new Vector3D(5, 7, 9);

            Assert.AreEqual(expected, C, $"wrong answer {C.X} {C.Y} {C.Z} , {expected.X} {expected.Y} {expected.Z} ");
        }

        [TestMethod]
        public void TestSubtraction()
        {

            Vector3D A = new Vector3D(4, 5, 3);
            Vector3D B = new Vector3D(1, 2, 6);


            Vector3D expected = new Vector3D(3, 3, -3);

            Vector3D C = A - B;

            Assert.AreEqual(expected, C, $"wrong answer {C.X} {C.Y} {C.Z} , {expected.X} {expected.Y} {expected.Z} ");
        }

        [TestMethod]
        [DataRow(4, 5, 6, 7, 8, 9, 11, 13, 15)]
        [DataRow(4, 5, 6, 0, 0, 0, 4, 5, 6)]
        [DataRow(0, 0, 0, 7, 8, 9, 7, 8, 9)]
        public void TestAnotherAddition(int x, int y, int z, int x2, int y2, int z2, int ex1, int ex2, int ex3)
        {

            Vector3D A = new Vector3D(x, y, z);
            Vector3D B = new Vector3D(x2, y2, z2);

            Vector3D C = A + B;

            Vector3D expected = new Vector3D(ex1, ex2, ex3);

            Assert.AreEqual(expected, C, $"wrong answer {C.X} {C.Y} {C.Z} , {expected.X} {expected.Y} {expected.Z} ");
        }

        [TestMethod]
        [DataRow(4, 5, 6, 7, 8, 9, -3, -3, -3)]
        [DataRow(4, 5, 6, 0, 0, 0, 4, 5, 6)]
        [DataRow(0, 0, 0, 7, 8, 9, -7, -8, -9)]
        [DataRow(7, 8, 9, 7, 8, 9, 0, 0, 0)]
        public void TestAnotherSubtraction(int x, int y, int z, int x2, int y2, int z2, int ex1, int ex2, int ex3)
        {

            Vector3D A = new Vector3D(x, y, z);
            Vector3D B = new Vector3D(x2, y2, z2);

            Vector3D C = A - B;

            Vector3D expected = new Vector3D(ex1, ex2, ex3);

            Assert.AreEqual(expected, C, $"wrong answer {C.X} {C.Y} {C.Z} , {expected.X} {expected.Y} {expected.Z} ");
        }

    }
}
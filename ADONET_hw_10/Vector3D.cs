using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Vector
{
    public class Vector3D : IEquatable<Vector3D>
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Vector3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Vector3D() { }

        public static Vector3D operator +(Vector3D A, Vector3D B)
        {
            Vector3D C = new Vector3D();

            C.X = A.X + B.X;
            C.Y = A.Y + B.Y;
            C.Z = A.Z + B.Z;

            return C;
        }

        public static Vector3D operator -(Vector3D A, Vector3D B)
        {
            Vector3D C = new Vector3D();

            C.X = A.X - B.X;
            C.Y = A.Y - B.Y;
            C.Z = A.Z - B.Z;

            return C;
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Vector3D);
        }

        public bool Equals(Vector3D other)
        {
            return X == other.X && Y == other.Y && Z == other.Z;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}

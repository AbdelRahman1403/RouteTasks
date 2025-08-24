using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne
{
    public class Point3D
    {
        private int x;
        private int y;
        private int z;

        public int X
        {
            //get { return X; }
            set { x = value; }
        }
        public int Y
        {
            //get { return X; }
            set { y = value; }
        }
        public int Z
        {
            //get { return X; }
            set { z = value; }
        }

        public Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public Point3D(int x , int y): this(x , y , 0)
        {

        }
        public Point3D(int x) : this(x, 0, 0)
        {

        }

        override public string ToString()
        {
            return $"Point Coordinates : ({x},{y},{z})";
        }

        public static bool operator==(Point3D p1 , Point3D p2)
        {
            return ((p1.x == p2.x) && (p1.y == p2.y) && (p1.z == p2.z));
        }
        public static bool operator !=(Point3D p1, Point3D p2)
        {
            return !(p1 == p2);
        }
    }
}

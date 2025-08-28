using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task06.Question1.Interfaces;

namespace Task06.Question1.Classes
{
    public class myRectangle : Irectangle
    {
        private int length;
        private int width;
        private int area;
        public int Length { 
            get { return length; }
            set
            {
                length = value < 0 ? 0 : value;
            }
        }
        public int Width { 
            get { return width; }
            set
            {
                width = value < 0 ? 0 : value;
            }
        }
        public int Area { 
            set {
                area = length * width;
            }
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"The width is : {width} and the length is : {length}\nThen the area is {area}");
        }
    }
}

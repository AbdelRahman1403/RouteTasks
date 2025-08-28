using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task06.Question1.Interfaces;

namespace Task06.Question1.Classes
{
    internal class myCyrcle : ICyrcle
    {
        private int radius;
        private int area;
        public int Radius {
            get
            {
                return radius;
            }
            set
            {
                radius = value < 0 ? 0 : value;
            }
        }
        public int Area { 
            set
            {
                area = (int)(Math.PI * radius * radius);
            } 
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"The radius of cyrcle is : {radius}\nThen the area is : {area}");
        }
    }
}

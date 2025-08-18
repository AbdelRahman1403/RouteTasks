using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOOP2
{
    internal struct Point
    {
        private int x;
        private int y;
        public int X{
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public int Y{ 
            get
            {
                return y;
            } 
            set
            {
                y = value; 
            }
        }
        public override string ToString()
        {
            return $"The Point Coordinates {x},{y}";
        }
    }
}

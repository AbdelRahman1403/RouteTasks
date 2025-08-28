using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06.Question1.Interfaces
{
    internal interface Irectangle : IShape
    {
        public int Length { set; get; }
        public int Width  { set; get; }
    }
}

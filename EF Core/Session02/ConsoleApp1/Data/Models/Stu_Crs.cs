using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data.Models
{
    internal class Stu_Crs
    {
        public int Stu_ID { get; set; }
        public Student student { get; set; } = null!;
        public int Crs_ID { get; set; }
        public Course course { get; set; } = null!;
        public int Grade { get; set; }
    }
}

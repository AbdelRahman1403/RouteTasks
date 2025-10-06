using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data.Models
{
    internal class Instructor
    {
        public int InstructorId { get; set; }
        public required string InstructorName { get; set; }
        public decimal Salary { get; set; }
        public decimal Bonus { get; set; }
        public string Address { get; set; }
        public int HiringDate { get; set; }

        public int DeptId { get; set; }
        public Department dept { get; set; } = null!;

        public Department ManagedDepartment { get; set; }
    }
}

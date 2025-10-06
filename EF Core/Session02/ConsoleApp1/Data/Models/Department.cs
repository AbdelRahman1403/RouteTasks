using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data.Models
{
    internal class Department
    {
        public int DepartmentId { get; set; }
        public required string DepartmentName { get; set; }
        public int HiringDate { get; set; }

        public int ManagerId { get; set; }
        public Instructor Manager { get; set; } = null!;

        public List <Instructor> Instructors { get; set; } = new List<Instructor>();

        public List<Student> Students { get; set; } = new List<Student>();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOOP2.Company
{
    public enum  Gender
    {
        Female = 1,
        Male = 2,
        F = 1,
        M = 2,
        f = 1,
        m = 2,
        female = 1,
        male = 2,
    }

    internal class HireDate
    {
        protected int year;
        protected int month;
        protected int day;

        internal HireDate(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }
        override public string ToString()
        {
            return $"{day}/{month}/{year}";
        }
    }
    internal class Employee
    {
        private int ID;
        private HireDate hireDate;
        private Gender type;
        private decimal salary;
        private string department;
        public string Name;

        public Employee(int id , string name, decimal salary, Gender type, string department)
        {
            ID = id;
            Name = name;
            this.salary = salary >= 6000 ? salary : 6000;
            this.type = type;
            hireDate = new HireDate(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);            this.department = department;
        }

        override public string ToString()
        {
            return $"Employee ID : {ID} , Employee Name {Name} , Gender {type}"+
                   $"\nThe Department is : {department}Salary : {salary}\nHireDate : {hireDate.ToString()}";
        }
    }
}

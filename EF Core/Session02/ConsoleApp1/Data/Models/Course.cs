using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data.Models
{
    internal class Course
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Column(TypeName = "CourseID")]
        //public int Crs_Id { get; set; }
        //[Required]
        //[StringLength(50 , MinimumLength = 20)]
        //[Column(TypeName = "CourseName")]
        //public required string Crs_Name { get; set; }
        //[Range(10, 20)]
        //[Column(TypeName = "CourseDuration")]
        //public required int Crs_Duration { get; set; }
        //[Column(TypeName = "CourseDescription")]
        //public string? Crs_Description { get; set; }
        //public int Topic_ID { get; set; }

        public int Crs_Id { get; set; }
        public required string Crs_Name { get; set; }
        [Range(10 , 20)]
        public required int Crs_Duration { get; set; }
        public string? Crs_Description { get; set; }
        public int Topic_ID { get; set; }
    }
}

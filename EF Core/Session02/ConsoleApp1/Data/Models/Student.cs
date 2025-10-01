using Microsoft.EntityFrameworkCore.Update.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data.Models
{
    /// <summary>
    /// 1. Data Annotaiton
    /// </summary>
    class DecimalNumberAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if(value is null)
            {
                return new ValidationResult(ErrorMessage ?? "ERROR , this value must not be null");
            }

            if(value is int)
            {
                if((int)value % 10 == 0) {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult(ErrorMessage ?? "ERROR , this value must be multiple of 10");
                }
            }
            else
            {
                return new ValidationResult(ErrorMessage ?? "ERROR , this value must be integer");  
            }
        }
    }
    /*
    [Table("Students" , Schema = "dbo")]
    internal class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StuID { get; set; }
        [Column("FirstName" , TypeName = "varchar(50)")]
        [StringLength(50 , MinimumLength = 20)]
        [Required]
        public string FName{ get; set; }
        [Column ("LastName" , TypeName = "varchar(50)")]
        [MaxLength(50)]
        [MinLength(20)]
        public string? LName{ get; set; }
        [Column(TypeName = "varchar(50)")]
        [MaxLength(50)]
        [MinLength(20)]
        public string? Address { get; set; }
        [Range(18 , 60)]
        [Required]
        public int Age{ get; set; }
        [DecimalNumber]
        public int DeptID { get; set; }
    }*/
    internal class Student
    {
        public int StuID { get; set; }
        public string FName { get; set; }
        public string? LName { get; set; }
        public string? Address { get; set; }
        [Range(20 , 50)]
        public int Age { get; set; }
        [DecimalNumber]
        public int DeptID { get; set; }
    }
}

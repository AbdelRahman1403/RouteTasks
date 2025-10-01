using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data.Models
{
    internal class Topic
    {
        [Key]
        public int Topic_ID { get; set; }
        [Required]
        [StringLength(50 , MinimumLength = 20)]
        public required string Topic_Name { get; set; }
    }
}

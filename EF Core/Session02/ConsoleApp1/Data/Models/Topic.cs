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
        public int TopicId { get; set; }
        public required string Topic_Name { get; set; }
        public int Crs_Id { get; set; }
        public Course crs { get; set; }
    }
}

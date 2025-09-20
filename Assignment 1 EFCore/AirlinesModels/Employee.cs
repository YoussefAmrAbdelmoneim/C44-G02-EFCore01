using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_EFCore.AirlinesModels
{
    internal class Employee
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(40)]
        [MinLength(3)]
        public string Name { get; set; }
        public string Address { get; set; }
        public char Gender { get; set; }
        public string Position { get; set; }
        [MaxLength(4)]
        public string BD_Year { get; set; }
        [MaxLength(2)]
        public string BD_Month { get; set; }
        [MaxLength(2)]
        public string BD_Day { get; set; }
        public int Al_Id { get; set; }
    }
}

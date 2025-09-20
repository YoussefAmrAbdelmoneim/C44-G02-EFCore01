using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_EFCore.ITIModels
{
    internal class Instructor
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(40)]
        [MinLength(3)]
        public string Name { get; set; }
        public string Address { get; set; }
        public decimal Bonus { get; set; }
        public decimal Salary { get; set; }
        public int Hour_Rate { get; set; }
        public int Dep_Id { get; set; }

    }
}

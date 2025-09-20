using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_EFCore.ITIModels
{
    internal class Department
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(40)]
        [MinLength(3)]
        public string Name { get; set; }
        public DateTime Hiring_Date { get; set; }
        public int Ins_Id { get; set; }
    }
}

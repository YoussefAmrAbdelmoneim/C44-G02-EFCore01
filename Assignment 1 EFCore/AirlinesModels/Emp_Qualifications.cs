using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_EFCore.AirlinesModels
{
    internal class Emp_Qualifications
    {
        [Key]
        public int Emp_Id { get; set; }
        public string Qualifications { get; set; }
    }
}

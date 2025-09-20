using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_EFCore.ITIModels
{
    internal class Course_Instructor
    {
        [Key]
        public int Course_Id { get; set; }
        public int Ins_Id { get; set; }
        public string Evaluation { get; set; }
    }
}

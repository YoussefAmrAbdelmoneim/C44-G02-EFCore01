using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_EFCore.AirlinesModels
{
    internal class Aircraft
    {
        [Key]
        public int Id { get; set; }
        public int Capacity { get; set; }
        public string Model { get; set; }
        public int Maj_Pilot { get; set; }
        [MaxLength(40)]
        [MinLength(3)]
        public string Assistant { get; set; }
        [MaxLength(40)]
        [MinLength(3)]
        public string Host1 { get; set; }
        [MaxLength(40)]
        [MinLength(3)]
        public string Host2 { get; set; }
        public int Al_Id { get; set; }
    }
}

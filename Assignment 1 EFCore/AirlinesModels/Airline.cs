using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_EFCore.AirlinesModels
{
    internal class Airline
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(40)]
        [MinLength(3)]
        public string Name { get; set; }
        public string Address { get; set; }
        public int Cont_Person { get; set; }

    }
}

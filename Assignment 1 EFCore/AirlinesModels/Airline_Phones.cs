using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_EFCore.AirlinesModels
{
    internal class Airline_Phones
    {
        [Key]
        public int Al_Id { get; set; }
        [Phone]
        [DataType(DataType.PhoneNumber)]
        public int Phones { get; set; }
    }
}

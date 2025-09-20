using System.ComponentModel.DataAnnotations;

namespace Assignment_1_EFCore.ITIModels
{
    internal class Student
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(20)]
        [MinLength(3)]
        public string FName { get; set; }
        [MaxLength(20)]
        [MinLength(3)]
        public string LName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public int DepId { get; set; }
    }
}

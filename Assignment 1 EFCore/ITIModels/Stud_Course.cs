using System.ComponentModel.DataAnnotations;

namespace Assignment_1_EFCore.ITIModels
{
    internal class Stud_Course
    {
        [Key]
        public int Stud_Id { get; set; }
        public int Course_Id { get; set; }
        public char Grade { get; set; }

    }
}

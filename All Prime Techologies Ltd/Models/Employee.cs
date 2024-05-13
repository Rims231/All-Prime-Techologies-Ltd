using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace All_Prime_Techologies_Ltd.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } = 0;
        public string FirstName { get; set; } = "King";
        public string MiddleName { get; set; } = "London";
        public string LastName { get; set; } = "France";
        public string Email { get; set; } = "uk@gmail.com";
        public string MaritalStatus { get; set; } = "Married";
        public Gender Class { get; set; } = Gender.Male;
    }
}

using All_Prime_Techologies_Ltd.Models;

namespace All_Prime_Techologies_Ltd.Dtos
{
    public class AddEmployeesDtos
    {


        public string FirstName { get; set; } = "King";
        public string MiddleName { get; set; } = "London";
        public string LastName { get; set; } = "France";
        public string Email { get; set; } = "uk@gmail.com";
        public string MaritalStatus { get; set; } = "Married";
        public Gender Class { get; set; } = Gender.Male;
    }
}

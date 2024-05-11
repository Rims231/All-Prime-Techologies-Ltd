using All_Prime_Techologies_Ltd.Models;

namespace All_Prime_Techologies_Ltd.Dtos
{
    public class UpDateEmployeesDtos
    {
        public int Id { get; set; } = 0;
        public string FirstName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string MaritalStatus { get; set; } = string.Empty;
        public Gender Class { get; set; } = Gender.Male;

    }
}

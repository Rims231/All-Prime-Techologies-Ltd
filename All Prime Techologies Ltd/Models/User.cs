namespace All_Prime_Techologies_Ltd.Models
{
    public class User
    {
        public string UserName1 { get; set; }= string.Empty;
        
        public string Password { get; set; } = string.Empty;
        public string PasswordHash { get; internal set; }
    }
}

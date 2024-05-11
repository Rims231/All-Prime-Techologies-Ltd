namespace All_Prime_Techologies_Ltd.Models
{
     
     public class ServiceResponse<T>
	{
        public T? Data { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; } = string.Empty;
    }

}


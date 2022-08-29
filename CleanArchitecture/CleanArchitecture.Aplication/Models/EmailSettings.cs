namespace CleanArchitecture.Application.Models
{
    public class EmailSettings
    {
        public string ApiKey { get; set; } = "1";
        public string FromAddress { get; set; } = string.Empty;
        public string FromName { get; set; } = string.Empty;
    }
}

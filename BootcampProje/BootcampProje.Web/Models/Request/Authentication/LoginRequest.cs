namespace BootcampProje.Web.Models.Request.Authentication
{
    public class LoginRequest
    {
        public string Agency { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
    }
}

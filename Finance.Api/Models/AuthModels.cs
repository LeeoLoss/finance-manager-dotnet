namespace Finance.Api.Models
{
    // 1.- RegisterModel for user registration
    public class RegisterModel
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }

    // 2.- LoginModel for user login
    public class LoginModel
    {
        public string Email { get; set; } = string.Empty;   
        public string Password { get; set; } = string.Empty;
    }
}
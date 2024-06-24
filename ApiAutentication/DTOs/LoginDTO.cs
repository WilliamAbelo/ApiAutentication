namespace ApiAuthentication.DTOs
{
    public class LoginRequestDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class LoginResponseDTO
    {
        public UserDTO user { get; set; }
        public string token { get; set; }
    }

    public class UserDTO
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string[] Roles { get; set; }
    }
}

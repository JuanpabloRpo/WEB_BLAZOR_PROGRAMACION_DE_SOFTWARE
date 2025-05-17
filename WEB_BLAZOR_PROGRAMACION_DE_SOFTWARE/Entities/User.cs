using WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Enumerations;


namespace WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Entities
{
    public class User : Person
    {
        public User() : base() { }
        public bool EstaAutenticado => Id > 0;
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public UserType TypeUser { get; set; }
        public UserRole Role { get; set; } = UserRole.Guest;
        public int Arrears { get; set; } = 0;
        public bool IsActive { get; set; } = true;
        
    }
}

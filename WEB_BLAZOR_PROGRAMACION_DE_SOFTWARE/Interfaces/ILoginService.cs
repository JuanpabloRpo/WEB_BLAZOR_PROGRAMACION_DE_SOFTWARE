using WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Entities;
namespace WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Interfaces
{
    public interface ILoginService
    {
        public Task<User> check (string UserName, string Password);
    }
}

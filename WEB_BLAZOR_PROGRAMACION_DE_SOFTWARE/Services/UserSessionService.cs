using WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Entities;

namespace WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Services
{
    public class UserSessionService
    {
        

        public User user { get; private set; } = new User { Id = 0};

        public event Action? OnUsuarioCambiado;

        public void IniciarSesion(User usuario)
        {
            user = usuario;
            OnUsuarioCambiado?.Invoke();
        }

        public void CerrarSesion()
        {
            user = new();
            OnUsuarioCambiado?.Invoke();
        }
    }
}

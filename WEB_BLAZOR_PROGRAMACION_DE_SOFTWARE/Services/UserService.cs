using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Entities;
using WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Interfaces;


namespace WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseApiUrl = "https://localhost:7213/api/User";
        private readonly ILogger <UserService> _logger;

        public UserService(HttpClient httpClient, ILogger<UserService> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }
        /*
        public async Task<List<User>> ListUsers()
        {
            List<User> result = await _userDAO.ListUsers();


            return result;
        }

        public async Task<User> GetUser(int userId)
        {
            
            var user = await _userDAO.GetUser(userId);
            if (user != null)
            {
                _logger.LogInformation($"Usuario con ID: {userId} encontrado.");
            }
            else
            {
                _logger.LogWarning($"No se encontró el usuario con ID: {userId}.");
            }
            return user;
        }*/

        
        public async Task<Boolean> CreateUser(User user)
        {
            try
            {
                _logger.LogInformation($"Iniciando la llamada para guardar el usuario: {JsonSerializer.Serialize(user)}");
                var response = await _httpClient.PostAsJsonAsync($"{_baseApiUrl}/Crear", user);
                _logger.LogInformation($"Respuesta de CreateUser: Status Code - {response.StatusCode}");
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al guardar materia: {ex.Message}");
                return false; // O lanza una excepción más específica
            }
        }
        /*
        public async Task<Boolean> UpdateUser(User user)
        {
            var resultado = await _userDAO.UpdateUser(user);
            if (resultado)
            {
                _logger.LogInformation("Usuario actualizado de manera exitosa.");
                return true;
            }
            else
            {
                _logger.LogError($"Error al actualizar el usuario con ID: {user.Id}.");
                return false;
            }
        }

        public async Task<Boolean> DeleteUser(int userId)
        {
          
            var resultado = await _userDAO.DeleteUser(userId);
            if (resultado)
            {
                _logger.LogInformation($"Usuario con ID: {userId} eliminado de manera exitosa.");
                return true;
            }
            else
            {
                _logger.LogError($"Error al eliminar el usuario con ID: {userId}.");
                return false;
            }
        }*/
    }
}
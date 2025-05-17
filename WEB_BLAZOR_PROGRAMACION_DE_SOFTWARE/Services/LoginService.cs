using System.Text.Json;
using WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Entities;
using WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Interfaces;


namespace API_PROGRAMACION_DE_SOFTWARE.Services
{
    public class LoginService: ILoginService
    {


        private readonly HttpClient _httpClient;
        private readonly string _baseApiUrl = "https://localhost:7213/api/Login";
        private readonly ILogger<LoginService> _logger;

        public LoginService(HttpClient httpClient, ILogger<LoginService> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        public async Task<User> check(string UserName, string Password)
        {
            Console.WriteLine("LoginService.check() llamado.");
            try
            {

                var response = await _httpClient.GetAsync($"{_baseApiUrl}/VerificarUsuario?userName={UserName}&password={Password}");
                Console.WriteLine($"Respuesta de ListMaterials: Status Code - {response.StatusCode}");

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    var usuario = JsonSerializer.Deserialize<User>(content, options);
                    return usuario;
                }
                else
                {
                    Console.WriteLine($"Error al listar materias: Status Code - {response.StatusCode}");
                    return null; // O lanza una excepción más específica
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al listar materias: {ex.Message}");
                return null; // O lanza una excepción más específica
            }
            
        }
    }

}

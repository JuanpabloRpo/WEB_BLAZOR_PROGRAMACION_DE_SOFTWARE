using System.Net.Http.Json;
using System.Text.Json;
using WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Entities;
using WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Interfaces;
using WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Pages;


namespace WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Services
{
    public class MaterialService : IMaterialService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseApiUrl = "https://localhost:7213/api/Material";
        private readonly ILogger <MaterialService> _logger;

        public MaterialService(HttpClient httpClient, ILogger<MaterialService> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        public async Task<List<Material>> ListMaterials()
        {
            Console.WriteLine("MaterialService.ListMaterials() llamado.");
            try
            {

                var response = await _httpClient.GetAsync($"{_baseApiUrl}/Listar");
                Console.WriteLine($"Respuesta de ListMaterials: Status Code - {response.StatusCode}");

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    var materias = JsonSerializer.Deserialize<List<Material>>(content, options);
                    Console.WriteLine($"Materias listadas exitosamente: {materias?.Count ?? 0} encontradas.");
                    return materias;
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

        public async Task<List<Material>> ListAvailableMaterials()
        {
            Console.WriteLine("MaterialService.ListMaterials() llamado.");
            try
            {

                var response = await _httpClient.GetAsync($"{_baseApiUrl}/MaterialesDisponibles");
                Console.WriteLine($"Respuesta de ListAvailableMaterials: Status Code - {response.StatusCode}");

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    var materias = JsonSerializer.Deserialize<List<Material>>(content, options);
                    Console.WriteLine($"Materias listadas exitosamente: {materias?.Count ?? 0} encontradas.");
                    return materias;
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
    
        
        public async Task<Material> GetMaterial(int materialId)
        {

            Console.WriteLine("MaterialService.GetMaterial() llamado.");
            try
            {

                var response = await _httpClient.GetAsync($"{_baseApiUrl}/Buscar?materialId={materialId}");
                Console.WriteLine($"Respuesta de GetMaterial: Status Code - {response.StatusCode}");

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    var material = JsonSerializer.Deserialize<Material>(content, options);
                    return material;
                }
                else
                {
                    Console.WriteLine($"Error al obtener el  material: Status Code - {response.StatusCode}");
                    return null; // O lanza una excepción más específica
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener el material: {ex.Message}");
                return null; // O lanza una excepción más específica
            }
        }

        public async Task<Boolean> CreateMaterial(Book material)
        {

            Console.WriteLine("MaterialService.CreateMaterial() llamado.");
            try
            {

                var response = await _httpClient.PostAsJsonAsync($"{_baseApiUrl}/CrearLibro", material);
                Console.WriteLine($"Respuesta de CreateReservation: Status Code - {response.StatusCode}");

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine($"Error al crear el material: Status Code - {response.StatusCode}");
                    return false; // O lanza una excepción más específica
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al crear el material: {ex.Message}");
                return false; // O lanza una excepción más específica
            }
        }
        public async Task<Boolean> CreateMaterial(Audiovisual material)
        {

            Console.WriteLine("MaterialService.CreateMaterial() llamado.");
            try
            {

                var response = await _httpClient.PostAsJsonAsync($"{_baseApiUrl}/CrearAudioVisual", material);
                Console.WriteLine($"Respuesta de CreateReservation: Status Code - {response.StatusCode}");

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine($"Error al crear el material: Status Code - {response.StatusCode}");
                    return false; // O lanza una excepción más específica
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al crear el material: {ex.Message}");
                return false; // O lanza una excepción más específica
            }
        }
        /*
        public async Task<Boolean> UpdateMaterial(Material material)
        {
            
            var result = await _materialDAO.UpdateMaterial(material);
            if (result)
            {
                _logger.LogInformation($"Material con ID: {material.MaterialId} actualizado exitosamente.");
                return true;
            }
            else
            {
                _logger.LogError($"Error al actualizar el material con ID: {material.MaterialId}.");
                return false;
            }
        }

        public async Task<Boolean> DeleteMaterial(int materialId)
        {
            var result = await _materialDAO.DeleteMaterial(materialId);
            if (result)
            {
                _logger.LogInformation($"Material con ID: {materialId} eliminado exitosamente.");
                return true;
            }
            else
            {
                _logger.LogError($"Error al eliminar el material con ID: {materialId}.");
                return false;
            }
        }*/

    }
}

using System.Resources;
using System.Text.Json;
using WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Entities;
using WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Interfaces;
using WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Pages;


namespace WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Services
{
    public class ReservationService : IReservationService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseApiUrl = "https://localhost:7213/api/Reservation";
        private readonly ILogger<ReservationService> _logger;

        public ReservationService(HttpClient httpClient, ILogger<ReservationService> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        public async Task<List<Reservation>> ListReservations()
        {
            Console.WriteLine("ReservationService.ListReservations() llamado.");
            try
            {

                var response = await _httpClient.GetAsync($"{_baseApiUrl}/Listar");
                Console.WriteLine($"Respuesta de ListReservations: Status Code - {response.StatusCode}");

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    var reservas = JsonSerializer.Deserialize<List<Reservation>>(content, options);
                    Console.WriteLine($"Reservas listadas exitosamente: {reservas?.Count ?? 0} encontradas.");
                    return reservas;
                }
                else
                {
                    Console.WriteLine($"Error al listar las reservas: Status Code - {response.StatusCode}");
                    return null; // O lanza una excepción más específica
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al listar las reservas: {ex.Message}");
                return null; // O lanza una excepción más específica
            }
        }
        
        public async Task<Reservation> GetReservation(int reservationId)
        {
            Console.WriteLine("MaterialService.GetMaterial() llamado.");
            try
            {

                var response = await _httpClient.GetAsync($"{_baseApiUrl}/Buscar?reservationId={reservationId}");
                Console.WriteLine($"Respuesta de GetMaterial: Status Code - {response.StatusCode}");

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    var reserva = JsonSerializer.Deserialize<Reservation>(content, options);
                    return reserva;
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

        public async Task<List<Reservation>> GetReservationsUser(int UserId)
        {
            Console.WriteLine("ReservationService.GetReservationsUser() llamado.");
            Console.WriteLine("userId = "+UserId);
            try
            {

                var response = await _httpClient.GetAsync($"{_baseApiUrl}/ReservacionesUsuario?userId={UserId}");
                Console.WriteLine($"Respuesta de GetReservationsUser: Status Code - {response.StatusCode}");

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    var reservas = JsonSerializer.Deserialize<List<Reservation>>(content, options);
                    Console.WriteLine($"Reservas listadas exitosamente: {reservas?.Count ?? 0} encontradas.");
                    return reservas;
                }
                else
                {
                    Console.WriteLine($"Error al listar las reservas: Status Code - {response.StatusCode}");
                    return null; // O lanza una excepción más específica
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al listar las reservas: {ex.Message}");
                return null; // O lanza una excepción más específica
            }
        }
        

        public async Task<Boolean> CreateReservation(int materialId, int userId)
        {

            Console.WriteLine("ReservationService.CreateReservation() llamado.");
            try
            {

                var response = await _httpClient.PostAsync($"{_baseApiUrl}/Crear?materialId={materialId}&userId={userId}",null);
                Console.WriteLine($"Respuesta de CreateReservation: Status Code - {response.StatusCode}");

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine($"Error al crear la reserva materias: Status Code - {response.StatusCode}");
                    return false; // O lanza una excepción más específica
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al listar materias: {ex.Message}");
                return false; // O lanza una excepción más específica
            }
        }

        /*public async Task<Boolean> ExtendReservation(int reservationId, int userId) 
        {
            var reservation = await _reservationDAO.GetReservation(reservationId);
            if (reservation == null)
            {
                _logger.LogError($"No se encontró la reserva con ID: {reservationId}.");
                return false;
            }

            if (reservation.UserId != userId)
            {
                _logger.LogError($"La reserva con ID: {reservationId} no pertenece al usuario con ID: {userId}.");
                return false;
            }
            if (reservation.Status == ReservationStatus.Extended)
            {
                _logger.LogWarning($"La reserva con ID: {reservationId} ya fue extendida previamente.");
                return false;
            }
            reservation.RequestDate = DateTime.Now;
            reservation.ExpirationDate = reservation.RequestDate.AddDays(7);
            reservation.Status = ReservationStatus.Extended;
            var resultado = await _reservationDAO.ExtendReservation(reservation);
            if (resultado)
            {
                _logger.LogInformation("Reserva extendida de manera exitosa.");
                return true;
            }
            else
            {
                _logger.LogError($"Error al extender la reserva con ID: {reservation.ReservationId}.");
                return false;
            }
        }*/

        public async Task<Boolean> RejectReservation(int reservationId, int userId) 
        {
            Console.WriteLine("ReservationService.RejectReservation() llamado.");
            try
            {

                var response = await _httpClient.PutAsync($"{_baseApiUrl}/Rechazar?reservationId={reservationId}&userId={userId}", null);
                Console.WriteLine($"Respuesta de RejectReservation: Status Code - {response.StatusCode}");

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine($"Error al rechazar la reserva: Status Code - {response.StatusCode}");
                    return false; // O lanza una excepción más específica
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al rechazar la reserva: {ex.Message}");
                return false; // O lanza una excepción más específica
            }
        }

        public async Task<Boolean> CancelReservation(int reservationId, int userId)
        {
            Console.WriteLine("ReservationService.CancelReservation() llamado.");
            try
            {

                var response = await _httpClient.PutAsync($"{_baseApiUrl}/Cancelar?reservationId={reservationId}&userId={userId}", null);
                Console.WriteLine($"Respuesta de cancelReservation: Status Code - {response.StatusCode}");

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine($"Error al cancelar la reservacion: Status Code - {response.StatusCode}");
                    return false; // O lanza una excepción más específica
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al al cancelar la reservacion: {ex.Message}");
                return false; // O lanza una excepción más específica
            }
        }
        /*
        public async Task<Boolean> DeleteReservation(int reservationId)
        {
            
            var resultado = await _reservationDAO.DeleteReservation(reservationId);
            if (resultado)
            {
                _logger.LogInformation($"Reserva con ID: {reservationId} eliminada de manera exitosa.");
                return true;
            }
            else
            {
                _logger.LogError($"Error al eliminar la reserva con ID: {reservationId}.");
                return false;
            }
        }*/
    }
}

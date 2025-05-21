
using System.Text.Json;
using WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Entities;
using WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Interfaces;


namespace WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Services
{
    public class LoanService : ILoanService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseApiUrl = "https://localhost:7213/api/Loan";
        private readonly ILogger<LoanService> _logger;

        public LoanService(HttpClient httpClient, ILogger<LoanService> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        /*

        public async Task<List<Loan>> ListLoans()
        {
            List<Loan> result = await _loanDAO.ListLoans();
            return result;
        }*/
        public async Task<List<Loan>> GetLoansUser(int UserId)
        {
            Console.WriteLine("LoanService.GetLoansUser() llamado.");
            Console.WriteLine("userId = " + UserId);
            try
            {

                var response = await _httpClient.GetAsync($"{_baseApiUrl}/PrestamosUsuario?userId={UserId}");
                Console.WriteLine($"Respuesta de GetReservationsUser: Status Code - {response.StatusCode}");

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    var loans = JsonSerializer.Deserialize<List<Loan>>(content, options);
                    Console.WriteLine($"Reservas listadas exitosamente: {loans?.Count ?? 0} encontradas.");
                    return loans;
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

        /*
        public async Task<Loan> GetLoan(int loanId)
        {
            
            var loan = await _loanDAO.GetLoan(loanId);
            if (loan != null)
            {
                _logger.LogInformation($"Préstamo con ID: {loanId} encontrado.");
                
            }
            else
            {
                _logger.LogWarning($"No se encontró el préstamo con ID: {loanId}.");
                
            }
            return loan;
        }

        public async Task<Boolean> CreateLoan(int reservationId, int userId)
        {
            // la reservacion tiene que estar en pendiente 
            if (!await _reservationDAO.CheckReservationPending(reservationId))
            {
                _logger.LogError("Reservacion NO Pendiente/Existe");
                return false;
            }

            // Se crea el nuevo prestamo
            var resultado = await _loanDAO.CreateLoan(reservationId, userId);

            // Se actualiza la reservacion de pending a accepted
            var reservationActualizado = await _reservationDAO.UpdateReservationStatus(reservationId, 1);

            // Se trae la reservacion para saber el Id del material para cambiar su Status
            var reservacion = await _reservationDAO.GetReservation(reservationId);
            var materialActualizado = await _materialDAO.UpdateMaterialStatus(reservacion.MaterialId, 2);

            if (resultado && reservationActualizado && materialActualizado)
            {
                _logger.LogInformation("Préstamo creado de manera exitosa.");
                return true;
            }
            else
            {
                _logger.LogError("Error al crear el préstamo.");
                return false;
            }

        }*/

        public async Task<Boolean> ReturnLoan(int loanId, int userId)
        {
            Console.WriteLine("ReservationService.CreateReservation() llamado.");
            try
            {

                var response = await _httpClient.PutAsync($"{_baseApiUrl}/Devolver?loanId={loanId}&userId={userId}", null);
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
        /*
        public async Task<Boolean> CancelLoan(int loanId, int userId)
        {
            var loan = await _loanDAO.GetLoan(loanId);
            if (loan == null)
            {
                _logger.LogError($"No se encontró el préstamo con ID: {loanId}.");
                return false;
            }
            if (loan.UserId != userId)
            {
                _logger.LogError($"El préstamo con ID: {loanId} no pertenece al usuario con ID: {userId}.");
                return false;
            }
            bool resultado = await _loanDAO.CancelLoan(loan);
            if (resultado)
            {
                var reservacion = await _reservationDAO.GetReservation(loan.ReservationId);
                var materialActualizado = await _materialDAO.UpdateMaterialStatus(reservacion.MaterialId, 0);
                if (materialActualizado)
                {
                    _logger.LogInformation("Préstamo cancelado de manera exitosa.");
                    return true;
                }
                else
                {
                    _logger.LogError("Error al actualizar el estado del material.");
                    return false;
                }
            }
            else
            {
                _logger.LogError($"Error al cancelar el préstamo con ID: {loan.LoanId}.");
                return false;
            }
        }

        public async Task<Boolean> DeleteLoan(int loanId)
        {
            
            var resultado = await _loanDAO.DeleteLoan(loanId);
            if (resultado)
            {
                _logger.LogInformation($"Préstamo con ID: {loanId} eliminado de manera exitosa.");
                return true;
            }
            else
            {
                _logger.LogError($"Error al eliminar el préstamo con ID: {loanId}.");
                return false;
            }
        }*/
    }
}

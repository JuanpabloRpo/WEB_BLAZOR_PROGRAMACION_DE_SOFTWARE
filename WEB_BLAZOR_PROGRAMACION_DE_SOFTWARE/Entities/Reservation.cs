using WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Enumerations;

namespace WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Entities
{
    public class Reservation
    {
        
        public int ReservationId { get; set; }
        public int UserId { get; set; }
        public int MaterialId { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public ReservationStatus Status { get; set; }

        public Reservation() { }
    }
}

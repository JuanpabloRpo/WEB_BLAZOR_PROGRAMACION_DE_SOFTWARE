
using WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Enumerations;


namespace WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Entities
{
    public class Loan
    {
        
        public int LoanId { get; set; }
        
        public int UserId { get; set; }
        
        public int ReservationId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public LoanStatus Status { get; set; }
        public Loan () { }
    }
}

using System.ComponentModel.DataAnnotations;

namespace WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Enumerations
{
    public enum MaterialStatus
    {
        [Display(Name = "Disponible")]
        Available,
        [Display(Name = "Reservado")]
        Reserved,
        [Display(Name = "Prestado")]
        Loaned
    }
}

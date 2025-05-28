using System.ComponentModel.DataAnnotations;

namespace WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Enumerations
{
    public enum MaterialCondition
    {
        [Display(Name = "Nuevo")]
        New,
        [Display(Name = "Usado")]
        Used,
        [Display(Name = "Desgastado")]
        Worn,
        [Display(Name = "Dañado")]
        Damaged,
        [Display(Name = "Perdido")]
        Lost
    }
}

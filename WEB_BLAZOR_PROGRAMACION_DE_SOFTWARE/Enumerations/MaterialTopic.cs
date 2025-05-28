using System.ComponentModel.DataAnnotations;

namespace WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Enumerations
{
    public enum MaterialTopic
    {
        [Display(Name = "Ficción")]
        Fiction,

        [Display(Name = "No Ficción")]
        NonFiction,

        [Display(Name = "Ciencia")]
        Science,

        [Display(Name = "Historia")]
        History,

        [Display(Name = "Tecnología")]
        Technology,

        [Display(Name = "Arte")]
        Art,

        [Display(Name = "Literatura")]
        Literature,

        [Display(Name = "Filosofía")]
        Philosophy,

        [Display(Name = "Religión")]
        Religion,

        [Display(Name = "Viajes")]
        Travel,

        [Display(Name = "Salud")]
        Health,

        [Display(Name = "Negocios")]
        Business,

        [Display(Name = "Educación")]
        Education,

        [Display(Name = "Deportes")]
        Sports,

        [Display(Name = "Cocina")]
        Cooking
    }
}


namespace WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Entities
{
    public abstract class Person
    {
        public Person() { }
        public int Id { get; set; }
        public int Document { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public string MiddleName { get; set; } = string.Empty;
        public int Age { get; set; }
        
    }
}
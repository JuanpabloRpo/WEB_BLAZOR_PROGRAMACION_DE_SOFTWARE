
namespace WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Entities
{
    public abstract class Person
    {
        
        public int Id { get; set; }
        public string Document { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public string MiddleName { get; set; } = string.Empty;
        public int Age { get; set; }
        public Person() { }

        protected Person(string document, string firstName, string lastName, string middleName, int age)
        {
            Document = document;
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            Age = age;
        }
    }
}
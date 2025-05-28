using WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Enumerations;

namespace WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Entities
{
    public class Book:Material
    {
        public required int Pages { get; set; }
        public Book() { }

        public Book(string title, string author, int publicationYear, MaterialStatus status, MaterialCondition condition, MaterialTopic topic, string discriminator, int pages) : base(title, author, publicationYear, status, condition, topic, discriminator)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
            Status = status;
            Condition = condition;
            Topic = topic;
            Discriminator = discriminator;
            Pages = pages;
        }
    }
}

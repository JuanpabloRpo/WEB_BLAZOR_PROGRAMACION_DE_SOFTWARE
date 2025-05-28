using WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Enumerations;

namespace WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Entities
{
    public class Audiovisual : Material
    {
        public required string Format { get; set; }
        public required string Duration { get; set; }
        public Audiovisual() { }

        public Audiovisual(string title, string author, int publicationYear, MaterialStatus status, MaterialCondition condition, MaterialTopic topic, string discriminator, string format, string duration) : base(title, author, publicationYear, status, condition, topic, discriminator)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
            Status = status;
            Condition = condition;
            Topic = topic;
            Format = format;
            Duration = duration;
            Discriminator = discriminator;
        }
    }
}

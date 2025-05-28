using WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Enumerations;

namespace WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Entities
{
    public class Material
    {
        public int MaterialId { get; set; }
        public required string Title { get; set; }
        public required string Author { get; set; }
        public required int PublicationYear { get; set; }
        public MaterialStatus Status { get; set; }
        public MaterialCondition Condition { get; set; }
        public MaterialTopic Topic { get; set; }
        public string Discriminator { get; set; }
        public Material() { }

        public Material(string title, string author, int publicationYear, MaterialStatus status, MaterialCondition condition, MaterialTopic topic, string discriminator)
        {

            Title = title;
            Author = author;
            PublicationYear = publicationYear;
            Status = status;
            Condition = condition;
            Topic = topic;
            Discriminator = discriminator;
        }
    }
}

using System.Data;
using WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Enumerations;

namespace WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Utilities
{
    public class ConversorEnumInt
    {
        public static int UserTypeConver(string type)
        {
            switch (type)
            {
                case "Student":
                    return 0;
                case "Teacher":
                    return 1;
                case "Employee":
                    return 2;
                default: return 0;
            }
        }
        public static int UserRoleConver(string role)
        {
            switch (role)
            {
                case "Guest":
                    return 0;
                case "Librarian":
                    return 1;
                case "Administrator":
                    return 2;
                default: return 0;
            }
        }
        public static int MateriaConditionConver(string condition)
        {
            switch (condition)
            {
                case "New":
                    return 0;
                case "Used":
                    return 1;
                case "Worn":
                    return 2;
                case "Damaged":
                    return 2;
                case "Lost":
                    return 2;
                default: return 0;
            }
        }

        public static int MateriaTopicConver(string topic)
        {
            switch (topic)
            {
                case "Fiction":
                    return 0;
                case "NonFiction":
                    return 1;
                case "Science":
                    return 2;
                case "History":
                    return 3;
                case "Technology":
                    return 4;
                case "Art":
                    return 5;
                case "Literature":
                    return 6;
                case "Philosophy":
                    return 7;
                case "Religion":
                    return 8;
                case "Travel":
                    return 9;
                case "Health":
                    return 10;
                case "Business":
                    return 11;
                case "Education":
                    return 12;
                case "Sports":
                    return 13;
                case "Cooking":
                    return 14;
                default:
                    return -1; 
            }
        }
    }
}

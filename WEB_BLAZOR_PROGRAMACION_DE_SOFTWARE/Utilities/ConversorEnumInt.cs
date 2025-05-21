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
    }
}

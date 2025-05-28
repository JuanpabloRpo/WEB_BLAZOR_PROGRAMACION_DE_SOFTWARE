using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Utilities
{
    public class Conversor
    {

        public static string GetDisplayName(Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attr = field?.GetCustomAttribute<DisplayAttribute>();
            return attr?.Name ?? value.ToString();
        }
    }
}

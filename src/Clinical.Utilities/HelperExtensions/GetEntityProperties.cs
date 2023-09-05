using System.Reflection;

namespace Clinical.Utilities.HelperExtensions
{
    public static class GetEntityProperties
    {
        public static Dictionary<string, object> GetPropertiesWithValues<T>(this T entity)
        {
            PropertyInfo[] properties = typeof(T).GetProperties();
            var entityparams = new Dictionary<string, object>();
            foreach (PropertyInfo property in properties)
            {
                object velue = property.GetValue(entity)!;
                if (velue != null)
                {
                    entityparams[property.Name] = velue;
                }
            }
            return entityparams;
        }
    }
}

using System.Text.Json;

namespace StudentHouseMembershipCart.API.Service
{
    public static class SessionHelper
    {
        public static void SetObject<T>(this ISession session, string key, T value)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true // Để làm cho JSON đẹp hơn khi lưu trữ
            };
            var json = JsonSerializer.Serialize(value, options);
            session.SetString(key, json);
        }
        public static T GetObject<T>(this ISession session, string key)
        {
            var json = session.GetString(key);
            return string.IsNullOrEmpty(json) ? default : JsonSerializer.Deserialize<T>(json);
        }
        public static void DeleteObject<T>(this ISession session, string key)
        {
            var json = session.GetString(key);
            if(json != null)
            {
                session.Remove(key);
            }
            return;
        }
    }
}

using System.Text.Json.Serialization;
using System.Text.Json;

namespace EnergyManager.EnergyDataAPI.Serialisers
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class JsonSerialiser<T> where T : new()
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        public JsonSerialiser(ILogger logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// 
        /// </summary>
        private static readonly JsonSerializerOptions _options = new()
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            WriteIndented = true
        };
        private readonly ILogger _logger;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="jsonString"></param>
        /// <returns></returns>
        public static T DeserializeJsonData(string jsonString)
        {
            try
            {
                if (!string.IsNullOrEmpty(jsonString))
                {
                    T jsonData = JsonSerializer.Deserialize<T>(jsonString, _options)!;

                    return jsonData;
                }
                else
                {
                    return new T();
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return new T();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static string SerializeSettings(T model)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(model, _options);

                return jsonString;
            }
            catch (Exception ex)
            {
                string message = ex.Message;

                return string.Empty;
            }
        }
    }
}

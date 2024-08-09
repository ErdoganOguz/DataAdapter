using Newtonsoft.Json.Linq;

namespace DataAdapterExample.JsonConsumer
{
    public class JsonDataConsumer
    {
        public void ConsumeJsonData(string jsonData)
        {
            var jsonObject = JObject.Parse(jsonData);
            var employee = jsonObject["Employee"];

            if (employee != null)
            {
                Console.WriteLine("Name: " + employee["Name"]);
                Console.WriteLine("Position: " + employee["Position"]);
            }
            else
            {
                Console.WriteLine("Invalid JSON format.");
            }
        }
    }
}

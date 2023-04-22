using System.Text.Json.Nodes;
using Newtonsoft.Json.Linq;

namespace WeatherMap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string key = File.ReadAllText("appsettings.json");
            string APIkey = JObject.Parse(key).GetValue("DefaultKey").ToString();

            Console.WriteLine("Please enter your zipcode.");
            string zipCode = Console.ReadLine();

            string apiCall = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&appid={APIkey}&units=imperial";

            Console.WriteLine();
            Console.WriteLine($"It is currently {WeatherMap.GetTemp(apiCall)} degrees F");
        }
    }
}
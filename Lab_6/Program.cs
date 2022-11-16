using System.Text.Json;

namespace Lab_6
{
    public class Program
    {
        static void Main(string[] args)
        {
            var root = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
            var file = root + Path.DirectorySeparatorChar + "Eragon.json";

            string jsonString = string.Empty;

            using(var Sr = new StreamReader(file))
            {
                jsonString = Sr.ReadToEnd();
            }

            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            var eragon = JsonSerializer.Deserialize<Volumes>(jsonString, options);

            Console.WriteLine(eragon);
        }
    }
}
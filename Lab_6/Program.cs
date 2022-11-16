using System.Text.Json;

namespace Lab_6
{
    public class Program
    {
        static void Main(string[] args)
        {
            var root = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
            var file = root + Path.DirectorySeparatorChar + "Eragon.json";
            var file2 = root + Path.DirectorySeparatorChar + "Eldest.json";
            var file3 = root + Path.DirectorySeparatorChar + "Inheritance.json";
            var file4 = root + Path.DirectorySeparatorChar + "Fablehaven.json";
            var file5 = root + Path.DirectorySeparatorChar + "RiseOfTheEveningStar.json";

            string jsonString = string.Empty;

            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            //Book1
            //-------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------

            using (var Sr = new StreamReader(file))
            {
                jsonString = Sr.ReadToEnd();
            }

            var eragon = JsonSerializer.Deserialize<Books>(jsonString, options);

            Console.WriteLine(eragon);

            //-------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------

            //Book2
            //-------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------

            using (var Sr = new StreamReader(file2))
            {
                jsonString = Sr.ReadToEnd();
            }

            var eldest = JsonSerializer.Deserialize<Books>(jsonString, options);

            Console.WriteLine(eldest);

            //-------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------

            //Book3
            //-------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------

            using (var Sr = new StreamReader(file3))
            {
                jsonString = Sr.ReadToEnd();
            }

            var inheritance = JsonSerializer.Deserialize<Books>(jsonString, options);

            Console.WriteLine(inheritance);

            //-------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------

            //Book4
            //-------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------

            using (var Sr = new StreamReader(file4))
            {
                jsonString = Sr.ReadToEnd();
            }

            var fablehaven = JsonSerializer.Deserialize<Books>(jsonString, options);

            Console.WriteLine(fablehaven);

            //-------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------

            //Book5
            //-------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------

            using (var Sr = new StreamReader(file5))
            {
                jsonString = Sr.ReadToEnd();
            }

            var riseOfTheEveningStar = JsonSerializer.Deserialize<Books>(jsonString, options);

            Console.WriteLine(riseOfTheEveningStar);

            //-------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------
        }
    }
}
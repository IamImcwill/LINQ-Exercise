namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> namesOfCities = new List<string>()
            {
                "Atlanta",
                "Nashville",
                "Washington D.C.",
                "Austin",
                "Houston",
                "New York",
                "San Francisco"
            };
           
            var sortedCities = namesOfCities.OrderBy(name => name.Length);
            foreach (var name in sortedCities) 
            { 
                Console.WriteLine(name);            
            }

        }
    }
}

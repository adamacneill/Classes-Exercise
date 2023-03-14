using Microsoft.VisualBasic;

namespace Classes
{
    public class Program
    {

        static void Main(string[] args)
        {
            var myCar = new Car();

            myCar.Make = "Ford";

            myCar.Model = "Focus";

            myCar.Year = 2011;

            var subaru = new Car();
            {
                string Make = "Subaru";
                string Model = "Crosstrek";
                int Year = 2023;
            };

            var mazda = new Car("Mazda", "Miata", 2001);

            var carList = new List<Car>() { myCar, subaru, mazda };

            foreach(var vehicle in carList)

            {
                Console.WriteLine($"{vehicle.Make}, {vehicle.Model}, {vehicle.Year}");
            }

        }
    }
}

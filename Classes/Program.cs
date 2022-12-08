namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myCar = new car();
            myCar.Make = "Toyota";
            myCar.Model = "Pruis";
            myCar.year = "2010";

            var Ford = new car()
            {
                Make = "Ford",
                Model = "Raptar",
                year = "2013"
            };
            var BMW = new car("BMW", "M4", 2022);

            var carList = new List<car> { myCar, BMW, Ford };
            foreach(var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Model} {vehicle.Make} {vehicle.year}" );
            }
            
        }

        
    }
}

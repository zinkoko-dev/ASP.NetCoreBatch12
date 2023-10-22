using OOPDayOne;

internal class Program
{
    private static void Main(string[] args)
    {
        //StarUML //for create diagram
        try
        {
            Car car = new Car(); //Create a car object or instance of Car Class;
            car.Model = "M203";
            car.Type = "Truck";
            car.Color = "Black";
            car.LicenceNo = "YGN-200";
            car.Gear = "D";

            car.StartEngine();
            car.Drive();
            car.PlayHorn(3);
            car.ShowInfo();
            car.StopEngine();

            TruckCar truckCar = new TruckCar();
            truckCar.Type = "Truck Car";
            truckCar.Color = "red";
            truckCar.Model = "TRK5000";
            truckCar.LicenceNo = "YGN-300";
            truckCar.MaximunLoadInTon = 300;
            truckCar.ShowInfo();
            truckCar.LoadMaterial(100);
            truckCar.StartEngine();
            truckCar.Gear = "D";
            truckCar.Drive();
            truckCar.PlayHorn(4);
            truckCar.StopEngine();

            TruckCar truckCarOne = new TruckCar()
            {
                Type = "D",
                Color = "red",
                LicenceNo = "YGN-400",
                MaximunLoadInTon = 1000,
                NumberOfWheel = 6,
                Model = "TRK4000",
                Gear = "D",
            };

            truckCarOne.LoadMaterial(10);
            truckCarOne.LoadMaterial(20,"Generator");
            truckCarOne.ShowInfo();
            truckCarOne.Drive();

        }
        catch (Exception e)
        {
            Console.WriteLine($"Error occur because of {e.Message}");
        }
    }
} 
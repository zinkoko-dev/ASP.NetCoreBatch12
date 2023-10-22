namespace OOPDayOne
{
    public class Car
    {
        //state or member
        private string color;
        private string model;
        private string type;
        private string gear;
        private string licenceNo;

        #region Encapsulation
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Gear
        {
            get { return gear; }
            set { gear = value; }
        }
        public string LicenceNo
        {
            get { return licenceNo; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid Licence No");
                }
            }
        }
        #endregion

        //behavior
        public void Drive()
        {
            if (gear.Equals("p", StringComparison.OrdinalIgnoreCase))
            {
                this.ChangePinion(0);
            }
            else if (gear.Equals("d", StringComparison.OrdinalIgnoreCase))
            {
                this.ChangePinion(3);
            }
            else if (gear.Equals("r", StringComparison.OrdinalIgnoreCase))
            {
                this.ChangePinion(5);
            }
            Console.WriteLine("drive the car");
        }

        public void StartEngine() => Console.WriteLine("Start the engine");

        public void StopEngine() => Console.WriteLine("Stop the engine");

        /// <summary>
        /// Insert number of time to play horn
        /// </summary>
        /// <param name="count"></param>
        public void PlayHorn(int count)
        {
            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Show the parent car info.
        /// </summary>
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Car Model {Model}");
            Console.WriteLine($"Color {Color}");
            Console.WriteLine($"Type {Type}");
            Console.WriteLine($"LicenceNo {LicenceNo}");
            Console.WriteLine($"Gear {Gear}");
        }

        private void ChangePinion(int pinion)
        {
            Console.WriteLine("Change pinion "+pinion);
        }
    }
}

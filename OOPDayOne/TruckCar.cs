namespace OOPDayOne
{
    public class TruckCar : Car //Inheritance >> is-a-relationship by OOD
    {
        public int MaximunLoadInTon { get; set; }
        public int NumberOfWheel { get; set; }

        public void LoadMaterial(int ton)
        {
            if (ton < MaximunLoadInTon)
            {
                Console.WriteLine("Load a material : " + ton);
            }
            else
            {
                throw new Exception("Overload in ton!! maximun load is : " + MaximunLoadInTon);
            }
        }

        #region Runtime polymorphism >> method overloading
        public void LoadMaterial(int ton, string itemType)
        {
            if (ton < MaximunLoadInTon)
            {
                Console.WriteLine($"Load a {itemType} with ton {ton}");
            }
            else
            {
                throw new Exception("Overload in ton!! maximun load is : " + MaximunLoadInTon);
            }
        }
        #endregion

        #region runtime poloymorphism >> Method override
        /// <summary>
        /// Show the TruckCar info
        /// </summary>
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Maximun Load is : " + MaximunLoadInTon);
            Console.WriteLine("Wheels : " + NumberOfWheel);
        }
        #endregion
    }
}

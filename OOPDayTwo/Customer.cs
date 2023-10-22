namespace OOPDayTwo
{
    public class Customer
    {
        private string nrc;
        private string phoneNumber;

        public string Name { get; set; }
        public string Address { get; set; }
        public string Nrc
        {
            get { return nrc; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid NRC number!!");
                }
            }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                if (value.Length < 0 || value.Length > 11)
                {
                    throw new ArgumentException("Invalid Phone Number!!");
                    phoneNumber = value;
                }
            }
        }

        //Has-A relationship
        public BankAccount BankAccount { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine("Customer Information");
            Console.WriteLine("Name : "+Name);
            Console.WriteLine("Nrc No : "+Nrc);
            Console.WriteLine("Phone Number : "+PhoneNumber);
            Console.WriteLine("Address : "+Address);
        }
    }
}

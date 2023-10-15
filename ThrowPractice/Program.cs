internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Throw Practice");

        isNextTime:
        try
        {
            Console.Write("Enter your name : ");
            string name = Console.ReadLine();

            Console.Write("Enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            isValidAge(age);
            Console.WriteLine($"Hello {name}. You can vote");
        }
        catch (Exception e)
        {
            Console.WriteLine("error occurs please read the following message");
            Console.WriteLine(e.Message);
            goto isNextTime;
        }
    }

    public static void isValidAge(int age)
    {
        if (age < 0 || age > 100)
        {
            throw new Exception("invalid age input age value should be between 1 and 100.");
        }
        else if (age < 18)
        {
            throw new Exception("invalid age input you should be over 19 year old.");
        }
    }
}
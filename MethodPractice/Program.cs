internal class Program
{
    private static void Main(string[] args)
    {
        //access modifier
        //return
        //method name
        //parameter(optional)
        //body

        Console.WriteLine("Method Practice");

        //SayHello();

        //int result = TotalVowelCountInWord("Hello, How are you? Today is Sunday");
        //Console.WriteLine($"Total vowel is : {result}");

        ExceptionTest();
    }

    public static void SayHello()
    {
        Console.Write("Hello World!! ");
        DateTime now = DateTime.Now;

        if (now.Hour < 12)
        {
            Console.WriteLine("Good Morning");
        }
        else
        {
            Console.WriteLine("Good Afternoon");
        }
    }

    public static int TotalVowelCountInWord(string word) 
    {
        string finalWord = word.ToLower();
        int totalCount = 0;

        char[] chars = finalWord.ToArray();

        for (int i = 0; i<chars.Length; i++)
        {
            switch (chars[i])
            { 
                case 'a': totalCount++; break;
                case 'e': totalCount++; break;
                case 'i': totalCount++; break;
                case 'o': totalCount++; break;
                case 'u': totalCount++; break;
            }
        }
        return totalCount;
    }

    public static void ExceptionTest()
    {
        nextTime:
        try
        {
            Console.Write("Please Enter Number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            string message = num % 2 is 0 ? $"{num} is Even Number." : $"{num} is Odd Number.";

            Console.WriteLine(message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Oh!! sorry, we only accept number");
            goto nextTime;
        }
    }
}
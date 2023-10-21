internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Lopping Practice");

        #region While Looping
        int count = 1;
        while (count < 100)
        {
            if (count % 2 == 0)
            {
                Console.WriteLine($"Even number : {count}");
            }
            count++;
        }
        #endregion

        #region Do While Loop
        int i = 1;
        do
        {
            Console.WriteLine($"Number is : {i}");
            i++;
        }
        while (i <= 20);
        #endregion

        #region For Loop
        for (int i2 = 1; i2 <= 10; i2++)
        {
            for (int j = 1; j <= 7; j++)
            {
                Console.Write($"{i2 * j} ");
            }

            Console.WriteLine();
        }
        #endregion

        #region Array
        int[] marks = new int[10];
        marks[0] = 30;
        marks[9] = 20;

        Random random = new Random();

        for (int i3 = 0; i3 < marks.Length; i3++)
        {
            marks[i3] = random.Next(100);
        }

        for (int i4 = 0; i4 < marks.Length; i4++)
        {
            Console.Write($"{marks[i4]} ");
        }

        Console.WriteLine();

        foreach (int mark in marks)
        {
            Console.Write($"{mark} ");
        }
        #endregion

        #region Two Dimensional Array
        int row = 5;
        int col = 5;
        int[,] num = new int[row, col];
        Random random1 = new Random();

        for (int i = 0; i < num.GetLength(0); i++)
        {
            for (int j = 0; j < num.GetLength(1); j++)
            {
                num[i, j] = random.Next(100);
            }
        }

        foreach (int result in num)
        {
            Console.Write(result + " ");
        }
        #endregion
    }
}
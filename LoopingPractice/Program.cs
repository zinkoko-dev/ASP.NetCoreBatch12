
Console.WriteLine("Lopping Practice");

/*// While Looping
int count = 1;
while (count < 100)
{
    if (count % 2 == 0)
    {
        Console.WriteLine($"Even number : {count}");
    }
    count++;
}*/

/*// Do While Loop
int i = 1;
do
{
    Console.WriteLine($"Number is : {i}");
    i++;
}
while (i <= 20);*/

/*// For Loop
for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 7; j++)
    {
        Console.Write($"{i*j} ");
    }

    Console.WriteLine();
}*/

/*// Array
int[] marks = new int[10];
marks[0] = 30;
marks[9] = 20;

Random random = new Random();

for (int i = 0; i < marks.Length; i++)
{
    marks[i] = random.Next(100);
}

for (int i = 0; i < marks.Length; i++)
{
    Console.Write($"{marks[i]} ");
}

Console.WriteLine();

foreach (int mark in marks)
{
    Console.Write($"{mark} ");
}*/

/*// Two Dimensional Array
int row = 5;
int col = 5;
int[,] num = new int[row, col];
Random random = new Random();

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
}*/


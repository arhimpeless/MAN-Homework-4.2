namespace Задание_4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m;
            int n;
            Random rnd = new Random();
            while (true)
            {
                Console.WriteLine("Введите два целых одинаковых числа. ");
                Console.Write("Введите M: ");
                m = int.Parse(Console.ReadLine());
                Console.Write("Введите N: ");
                n = int.Parse(Console.ReadLine());
                int[,] array1 = new int[m, n];  //задали размерность нашего вводимого массива
                int[,] array2 = new int[m, n];  //задали размерность для зеркального массива
                if (m == n)
                {
                    for (int x = 0; x < m; x++)     //перебор по х
                    {
                        for (int y = 0; y < n; y++)  //перебор по y
                        {
                            array1[x, y] = rnd.Next(1, 20);
                            Console.Write(array1[x, y] + "\t");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("Отзеркаливаем относительно главной диагонали: ");
                    for (int x = 0; x < m; x++)
                    {
                        for (int y = 0; y < n; y++)
                        {
                            array2[x, y] = array1[y, x];
                            Console.Write(array2[x, y] + " \t");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("Процесс завершён!");
                    Console.ReadKey();
                }
                if (m != n)
                {
                    Console.WriteLine("Неквадратно!\n");
                }
            }
        }
    }
}
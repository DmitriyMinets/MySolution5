namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3]
            {
                {65, 32, 96},
                {32, 41, 9},
                {3, 8, 15}
            };

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int maxValue = int.MinValue;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > maxValue)
                    {
                        maxValue = matrix[i, j];
                    }
                }
                Console.WriteLine($"Максимальный элемент {i + 1} ряда {maxValue}");
            }
        }
    }
}
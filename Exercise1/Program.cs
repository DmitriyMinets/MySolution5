namespace Exercise1

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNuмbers = new int[6];

            for (int i = 0; i < arrayNuмbers.Length; i++)
            {
                Console.Write($"Введите значения {i + 1} элемента массива: ");
                int.TryParse(Console.ReadLine(), out arrayNuмbers[i]);

            }

            Array.Sort(arrayNuмbers);
            Array.Reverse(arrayNuмbers);
            foreach (int i in arrayNuмbers)
            {
                Console.Write(i + " ");
            }

        }
    }
}
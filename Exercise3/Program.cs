using System.Text;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenghtArray;
            Random random = new Random();
            StringBuilder valueIndex = new StringBuilder();
            int indexMinValue, indexMaxValue, lastIndex;
            Console.Write("Введите длинну массива: ");
            int.TryParse(Console.ReadLine(), out lenghtArray);
            double[] arrayNubmers = new double[lenghtArray];
            double lastElement;
            for (int i = 0; i < lenghtArray; i++)
            {
                arrayNubmers[i] = random.Next(1, 100) + random.NextDouble();
            }
            Console.Write("Массив элементов: ");
            foreach (double d in arrayNubmers)
            {
                Console.Write($"{d:f2} ");
            }
            Console.WriteLine();

            for (int i = 0, count = 1; i < lenghtArray / 2; count++, i++)
            {
                double maxValue = 0.00D, minValue = double.MaxValue;
                for (int j = 0; j < lenghtArray; j++)
                {
                    if (arrayNubmers[j] < minValue & arrayNubmers[j] != 0.00D)
                    {
                        minValue = arrayNubmers[j];
                    }

                    if (arrayNubmers[j] > maxValue & arrayNubmers[j] != 0.00D)
                    {
                        maxValue = arrayNubmers[j];
                    }

                }
                indexMinValue = Array.IndexOf(arrayNubmers, minValue);
                valueIndex.Append($"{minValue:F2} - {indexMinValue}; ");
                arrayNubmers[indexMinValue] = 0;

                if (i + 1 == lenghtArray / 2 & lenghtArray % 2 == 0)
                {
                    break;
                }
                else
                {
                    indexMaxValue = Array.IndexOf(arrayNubmers, maxValue);
                    valueIndex.Append($"{maxValue:F2} - {indexMaxValue}; ");
                    arrayNubmers[indexMaxValue] = 0;
                }


            }

            lastElement = arrayNubmers.Max();
            lastIndex = Array.IndexOf(arrayNubmers, lastElement);


            Console.Write("Массив с обнулёнными значениями: ");
            foreach (double d in arrayNubmers)
            {
                Console.Write($"{d:f2}; ");
            }
            Console.WriteLine();
            Console.Write(@"Строка в формате {значение} - {индекс}: ");
            Console.WriteLine(valueIndex);
            Console.Write($"Последний элемент в массиве: {lastElement:f2} c индексом {lastIndex}");



            
            

        }
    }
}
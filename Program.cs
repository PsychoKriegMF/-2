using System.Diagnostics.Metrics;
using System.Numerics;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Массивы и строки
            int[] asd = new int[] { 1, 2, 3 }; //создание инициализированного массива
            int[] asd2 = new int[3]; // не инициализированный массив
            Console.WriteLine(asd[0]);
            int[,] asd3 = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } }; // двумерный массив (3 строки 2 столбца)
            Console.WriteLine(asd3[2, 1]);
            int[][] asd4 = new int[3][]; //зубчатый массив(массив с массивами) 
            asd4[0] = new int[] { };

            int[] ss = new int[] { 1, 2, 3 };
            foreach (var i in ss)
            {
                Console.WriteLine(i);
            }

            //задача 1

            int chet = 0, nechet = 0, unique = 0;
            int[] arr = new int[] { 1, 2, 3, 1, 6, 7, 8, 9, 6, 8 };
            foreach (var i in arr)
            {
                if (i % 2 == 0)
                {
                    chet++;
                }
                else
                {
                    nechet++;
                }
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != arr[j])
                    {
                        unique++;
                    }
                }
            }

            Console.WriteLine(chet);
            Console.WriteLine(nechet);
            Console.WriteLine(unique);


            for (int i = 0; i < arr.Length; i++)
            {
                bool isUnique = true;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j && arr[i] == arr[j])
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique) unique++;
            }
            Console.WriteLine(chet);
            Console.WriteLine(nechet);
            Console.WriteLine(unique);

            //задача 2

            int counter = 0;
            int[] arr2 = new int[] { 1, 2, 3, 1, 2, 3, 4 };
            Console.WriteLine("Введите число ->");
            int n = Convert.ToInt32(Console.ReadLine());
            foreach (int i in arr2)
            {
                if (i < n) counter++;
            }

            Console.WriteLine(counter);

            //задача 3

            int[,] arr3 = new int[3, 3] { { 2, 0, 3 }, { 1, 2, 3 }, { 4, 7, 8 } };
            int min = arr3[0, 0], max = arr3[0, 0];
            foreach (int i in arr3)
            {
                foreach (int j in arr3)
                {
                    if (i < min) { min = i; }
                    if (j < min) { min = j; }
                    if (i > max) { max = i; }
                    if (j > max) { max = j; }
                }
            }
            Console.WriteLine(min);
            Console.WriteLine(max);

            //2 вариант решения задачи 3

            int rows = arr3.GetLength(0);
            int cols = arr3.GetLength(1);

            int min2 = arr3[0, 0], max2 = arr3[0, 0];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (arr3[i, j] > max) { max = arr3[i, j]; }
                    if (arr3[i, j] < min) { min = arr3[i, j]; }
                }

            }
            Console.WriteLine(min);
            Console.WriteLine(max);


            //Строки


            string str = "asdasd";
            char[] a = str.ToCharArray();
            str = "kljgkljgl";
            Console.WriteLine(str);


            Console.WriteLine("Введите предложение:");
            string str2 = Console.ReadLine();
            string[] words = str2.Split(' ');
            Console.WriteLine(words.Length);


            //задача 4  переворот слов в строке
            Console.WriteLine("Введите предложение:");
            string str3 = Console.ReadLine();
            string[] words2 = str3.Split(' ');
           

            for (int i = 0; i < words2.Length; i++)
            {
                words2[i] = new string (words2[i].Reverse().ToArray());
                Console.Write(words2[i] + ' ');
            }


            //1. Интерполяция строк
            int num1 = 10;
            string str4 = $"цена: {num1}";

            //2. Метод string.Format
            string str5 = String.Format ("sklfjhl {0}, {1}", num1,str4);

            //3. Concat
            string str6 = String.Concat("asdasd", num1);

            //4. Сложение строк
            string str7 = str4 + num1;


















        }
        enum En { el1, el2 };  // enum живет в классах, использовать моветон
    }
}

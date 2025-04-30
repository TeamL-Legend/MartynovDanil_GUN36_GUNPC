//// See https://aka.ms/new-console-template for more information
//int[] array1 = new[] { 32, 111, 25, 17 };
//float[] array2 = new[] { 12.22f, 13f, 15.87f, 25.44f };
//var results = Array.CreateInstance(typeof(float), 4);
//results.SetValue(array1[0] * array2[0], 0);
//results.SetValue(array1[0] / array2[0], 1);
//Console.WriteLine(results.GetValue(0));
//Console.WriteLine(results.GetValue(1));
//Array.Sort(array2, 4, 0);
//Console.WriteLine(array2.Max());
//int[] a = new int[5] {2,3,5,1,4};
//Array.Sort(a, 0,5);
//Console.WriteLine(a[0]);
//Console.WriteLine(a[1]);
//Console.WriteLine(a[2]);
//Console.WriteLine(a[3]);
//Console.WriteLine(a[4]);
//Array.Reverse(a);
//Console.WriteLine(a[0]);
//Console.WriteLine(a[1]);
//Console.WriteLine(a[2]);
//Console.WriteLine(a[3]);
//Console.WriteLine(a[4]);
//var a2 = new int[,] { { 5, 7, 3, 1, 9 }, { 5, 7, 3, 8, 9 }, { 5, 7, 3, 5, 3 } };
//var a3 = a2[0, 2];
//    Console.WriteLine(a3);

namespace Arrays2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Здесь массивы заданий 1-4
            int[] a = new int[8] { 0, 1, 1, 2, 3, 5, 8, 13 };
            string[] b = new string[12] {"January", "February", "March", "April", "May", "June", "July", "August","September", "October", "November", "December"};
            int[,] c = new int[3, 3]{{2,3,4},{2,3,4},{2,3,4}};
            c[1, 0] = c[1, 0] * c[1, 0];
            c[1, 1] = c[1, 1] * c[1, 1];
            c[1, 2] = c[1, 2] * c[1, 2];
            c[2, 0] = c[2, 0] * c[2, 0] * c[2, 0];
            c[2, 1] = c[2, 1] * c[2, 1] * c[2, 1];
            c[2, 2] = c[2, 2] * c[2, 2] * c[2, 2];
            double[][] jaggedArray = new double[3][]
            {
                new double[] {1,2,3,4,5},
                new double[] {Math.E, Math.PI},
                new double[] {Math.Log10(1), Math.Log10(10), Math.Log10(100), Math.Log10(1000)}
            };

            // массивы для заданий 5 и 6.
            int[] array = { 1, 2, 3, 4, 5 };
            int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };
            Array.Copy(array, 0, array2, 0, 3);
            Array.Resize(ref array, 10);
            // Выведите результат
            foreach( int i in array)
                Console.WriteLine(i);
                Console.ReadKey();
            foreach (int i in array2)
                Console.WriteLine(i);




            // Не понял что тут просят

            string[] sample = { "", "" };
            ResizeArray(ref array, /* подставьте число вторым аргументов  */ );
            // Что же будет выведено?

            // Не понял что тут просят


        }
    }
}
using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Найти произведение положительных элементов одномерного массива A размера N.
            int n, num, sum = 1;
            Massiv mas = new Massiv();
            Console.Write("Введите размер массива: ");
            n = int.Parse(Console.ReadLine());
            mas.Lenght = n;
            Console.WriteLine("Заполните массив числами");
            for(int i = 0; i < n; i++)
            {
                Console.Write("");
                num = int.Parse(Console.ReadLine());
                mas.posNum[i] = num;
                if (num > 0)
                {
                    sum *= num;
                }
                
            }
            Console.WriteLine("Произведение всех положительных чисел в одномерном массиве: {0}", sum);
            
           
        }
    }
}

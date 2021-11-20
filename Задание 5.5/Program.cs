using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Запись текста и ввод с клавиатуры
            Console.Write("Введите размерность массива: ");
            int N = Convert.ToInt32(Console.ReadLine());

            //Определяем массив(инициализируем)
            int[,] my_array = new int[N,N];
            //то что будет менятся в ячейке
            int Res = 1;

            for (int i = 0; i <= N - 1; i++)
            {

                for (int j = 0; j <= N - 1; j++)
                {
                    my_array[i, j] = Res; // 0 или 1 присваеваем значение

                    if (Res == 0)  //меняем 0 на 1, 1 на 0
                    { Res = 1; }
                    else
                    { Res = 0; }

                }

            }
            Console.Write("Массив сформирован");

            Console.ReadKey();
        }
    }
}

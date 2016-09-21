using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZTornArray
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Random rRnd = new Random();//для заполнения массива случайными значениям
                Console.Write("Enter number of rows:");//просим ввести количество строк
                //создаём рваный массив с количеством строк введенным пользователем
                int[][] iTornArr = new int[Convert.ToInt32(Console.ReadLine())][];

                //цикл определения длинны каждой строки в рваном массиве
                for (int i = 0; i < iTornArr.Length; i++)//идём по количеству строк
                {
                    //для каждой строки выполняем следующие действия:
                    //просим ввести длинну строки
                    Console.Write("Enter Length " + (i + 1).ToString() + " row:");
                    //создаём строку длинной введенной пользователем
                    iTornArr[i] = new int[Convert.ToInt32(Console.ReadLine())];
                    //заполняем каждую созданную строку случайным занчением от 10 до 99
                    for (int j = 0; j < iTornArr[i].Length; j++)
                    {
                        iTornArr[i][j] = rRnd.Next(10, 99);
                    }
                }

                Program.ShowArr(iTornArr);//показываем получившейся массив на консоли
                Console.Write("Enter the line number to sort:");//просим ввести номер строки которую хотим отсортировать
                Array.Sort(iTornArr[(Convert.ToInt32(Console.ReadLine())) - 1]);//сортируем строку с введенным номером
                Console.WriteLine("Sorted line:");
                Program.ShowArr(iTornArr);//выводим результат на консоль
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Read();
            }
        }//конец Main

        static public void ShowArr(int[][] itArr)//метод вывода массива на консоль(принимает рваный массив)
        {
            for (int i = 0; i < itArr.Length; i++)
            {
                Console.Write("Array №" + (i + 1).ToString() + ": ");//выводим номер строки
                for (int j = 0; j < itArr[i].Length; j++)
                {
                    Console.Write(itArr[i][j].ToString() + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(new String('*', 75));//разделитель для маркирования конца вывода
        }

    }//конец class Program
}//конец namespace DZTornArray

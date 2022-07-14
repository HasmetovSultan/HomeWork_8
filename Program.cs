using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_8
{
    internal class Program
    {
       static Random rnd = new Random();
        
        /// <summary>
        /// Метод для заполнения интового листа рандомными числами
        /// </summary>
        /// <param name="RandomFillingList"></param>
        static void RandomFillingList(List<int> list)
        {
            while (list.Count != 100)
            {
                list.Add(rnd.Next(0, 100));
            }
        }

        /// <summary>
        /// Метод для вывода интового листа на консоль
        /// </summary>
        /// <param name="OutputOnConsoleList"></param>
        static void OutputOnConsoleList(List<int> list)
        {            
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]} ");                
                if (i%10 == 0 && i != 0) Console.WriteLine("\n");                
            }
        }

        /// <summary>
        /// Метод для удаления из интового листа чисел что > 25 но < 50
        /// </summary>
        /// <param name="DeleteOnTheList"></param>
        static void DeleteOnTheList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)               //Удаление чисел что больше 25 но меньше 50
            {
                if (list[i] > 25 && list[i] < 50)
                {
                    list.Remove(list[i]);
                    i--;
                }
            }
        }
        


        
        static void Main(string[] args)
        {           
            
            List<int> list = new List<int>();  // Объявил новый лист типа <int>
                                               
            RandomFillingList(list);

            OutputOnConsoleList(list);

            Console.WriteLine("\n\nУдаляем числа которые > 25 но < 50 \n и выводим остаток на консоль\n\n");

            DeleteOnTheList(list);
            
            OutputOnConsoleList(list);
            
            Console.ReadLine();
        }
    }
}

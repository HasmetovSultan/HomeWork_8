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
        #region Методы для первого задания с интовым листом
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
        #endregion


        static Dictionary<string,string> DictKeyValue()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            string key = "";
            string value = "";
            for (; ; )
            {

                Console.WriteLine($"Введите номер телефона");
                key = Console.ReadLine();
                if (key == "" || key == " ") { break; }
                Console.WriteLine($"Введите Ф.И.О владельца");
                value = Console.ReadLine();
                dict.Add(key, value);
            }
            return dict;
        }

        static void PrintDictOnConsole(Dictionary<string,string> dict)
        {
            string key = "";
            string value = "";
            Console.WriteLine("Введите ключ (Номер телефона)");
            key = Console.ReadLine();
            while (!dict.TryGetValue(key, out value))
            {
                Console.WriteLine($"Не верный ключ");
                Console.WriteLine("Введите снова");
                key = Console.ReadLine();
            }
            Console.WriteLine(value);
        }
        static void Main(string[] args)
        {          

            PrintDictOnConsole(DictKeyValue());
            Console.ReadLine();
        }
    }
}

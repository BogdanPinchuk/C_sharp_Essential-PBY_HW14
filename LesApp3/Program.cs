using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp3
{
    class Program
    {
        static void Main()
        {
            // Join Unicode
            Console.OutputEncoding = Encoding.Unicode;

            // випадкові числа
            Random rnd = new Random();

            // створення колекції
            MyList<int> list = new MyList<int>();

            // Заповнення значеннями
            for (int i = 0; i < rnd.Next(27, 101); i++)
            {
                list.Add(rnd.Next(sbyte.MinValue, sbyte.MaxValue));
            }

            // перетворення колекції в матрицю
            int[] array = list.GetArray();

            // виведення значень
            Console.Write("\n\tВиведення значень через for:\n\t");
            var s = new StringBuilder();
            for (int i = 0; i < array.Length; i++)
            {
                s.Append(i + " ");
            }
            Console.WriteLine(s.ToString());

            // repeat
            DoExitOrRepeat();
        }

        /// <summary>
        /// Метод виходу або повторення методу Main()
        /// </summary>
        static void DoExitOrRepeat()
        {
            Console.WriteLine("\n\nСпробувати ще раз: [т, н]");
            Console.Write("\t");
            var button = Console.ReadKey(true);

            if ((button.KeyChar.ToString().ToLower() == "т") ||
                (button.KeyChar.ToString().ToLower() == "n")) // можливо забули переключити розкладку клавіатури
            {
                Console.Clear();
                Main();
                // без використання рекурсії
                //Process.Start(Assembly.GetExecutingAssembly().Location);
                //Environment.Exit(0);
            }
            else
            {
                // закриває консоль
                Environment.Exit(0);
            }
        }
    }
}

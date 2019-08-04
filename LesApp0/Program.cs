using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp0
{
    class Program
    {
        static void Main()
        {
            // Join Unicode
            Console.OutputEncoding = Encoding.Unicode;

            #region ручний варіант
#if false
            // масив для цілих чисел
            int[] array = new int[new Random().Next(27, 101)];

            // заповнення даними
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            } 
#endif 
            #endregion

            // економ варіант
            int[] array = Enumerable.Range(0, new Random().Next(27, 101)).ToArray();

            // вивід результатів
            Console.Write("\tПарні числа:\n\t");
            // парні числа
            foreach (int i in array.ToListEven())
            {
                Console.Write(i + " ");
            }

            Console.Write("\n\n\tНепарні числа:\n\t");
            // непарні числа
            foreach (int i in array.ToListOdd())
            {
                Console.Write(i + " ");
            }

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

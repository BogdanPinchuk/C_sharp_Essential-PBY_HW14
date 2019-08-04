using System;
using System.Collections;
using System.Linq;

// https://metanit.com/sharp/tutorial/4.12.php

namespace LesApp0
{
    /// <summary>
    /// Клас методів розширення
    /// </summary>
    static partial class Extention
    {
        /// <summary>
        /// масив цілих чисел
        /// </summary>
        private static int[] array;

        /// <summary>
        /// Повернення колекції всіх парних чисел
        /// </summary>
        /// <param name="data">масив цілих чисел</param>
        /// <returns></returns>
        public static IEnumerable ToListEven(this int[] data)
        {
            #region ручний варіант, за умови якщо не можна користуватися колекціями взагалі
#if false
            // кількість парних чисел
            int countEven = 0;
            // аналіз скільки парних чисел в масиві
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] % 2 == 0)
                {
                    countEven++;
                }
            }
            // створення масиву для парних чисел
            array = new int[countEven];
            // копіювання цих чисел
            for (int i = 0, j = 0; i < data.Length; i++)
            {
                if (data[i] % 2 == 0)
                {
                    array[j++] = data[i];
                }
            } 
#endif
            #endregion

            // економ варіант з використанням фільтра, хоча можна було зразу повернути колекцію
            array = data.Where(t => t % 2 == 0).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                yield return array[i];
            }

#if false
            // ручний вивід через нумератор
            return new EONumbers(); 
#endif
        }
        /// <summary>
        /// Повернення колекції всіх непарних чисел
        /// </summary>
        /// <param name="data">масив цілих чисел</param>
        /// <returns></returns>
        public static IEnumerable ToListOdd(this int[] data)
        {
            // економ варіант з використанням фільтра, хоча можна було зразу повернути колекцію
            array = data.Where(t => t % 2 == 1).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                yield return array[i];
            }
#if false
            // ручний вивід через нумератор
            return new EONumbers(); 
#endif
        }

    }
}

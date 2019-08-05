using System.Collections;

// https://metanit.com/sharp/tutorial/4.12.php

namespace LesApp0
{
    static partial class Extention
    {
        /// <summary>
        /// Nested клас який повертає числа через нумератор
        /// </summary>
        internal class EONumbers : IEnumerable, IEnumerator
        {
            /// <summary>
            /// ітератор/енумератор
            /// </summary>
            private int state = -1;

            /// <summary>
            /// Повернення поточного значення
            /// </summary>
            object IEnumerator.Current
                => array[state];

            /// <summary>
            /// Крокування по масиву
            /// </summary>
            /// <returns></returns>
            public bool MoveNext()
            {
                if (state < array.Length - 1)
                {
                    state++;
                    return true;
                }
                else
                {
                    Reset();
                    return false;
                }
            }

            /// <summary>
            /// Скидання (лічильника) ітератора
            /// </summary>
            public void Reset() => state = -1;

            /// <summary>
            /// Повернення нумератора
            /// </summary>
            /// <returns></returns>
            public IEnumerator GetEnumerator() 
                => this as IEnumerator;
        }
    }
}

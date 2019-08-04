using System.Collections.Generic;
using System.Linq;

namespace LesApp3
{
    /// <summary>
    /// Клас методів розширення
    /// </summary>
    static class Extention
    {
        /// <summary>
        /// Повернення масиву
        /// </summary>
        /// <typeparam name="T">тип значень</typeparam>
        /// <param name="list">колекція</param>
        /// <returns></returns>
        public static T[] GetArray<T>(this IEnumerable<T> list)
            => (list as MyList<T>).ToArray2();
        // 2 - для перевірки чи справді цей метод визивається
    }
}

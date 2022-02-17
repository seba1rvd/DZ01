using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    /// <summary>
    /// класс, реализующий метод замены числителя или знаменателя
    /// </summary>
    class Method
    {
        /// <summary>
        /// изменение числителя
        /// </summary>
        /// <param name="a">дробь, в которой изменяем числитель</param>
        /// <param name="x">число для замены</param>
        public static void MyMethodCh(Drobi a, int x)
        {
            Console.WriteLine("Числитель изменён");
        }
        /// <summary>
        /// изменение знаменателя
        /// </summary>
        /// <param name="a">дробь, в которой заменяем знаменатель</param>
        /// <param name="x">число для замены</param>
        public static void MyMethodZn(Drobi a, int x)
        {
            Console.WriteLine("Знаменатель изменён");
        }
    }
}
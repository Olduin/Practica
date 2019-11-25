using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    /// <summary>
    /// Абстрактный класс контекста приложения
    /// </summary>
    public abstract class Context
    {
        /// <summary>
        /// Указатель приложения для контекста
        /// </summary>
        public TestApp App { get; set; }

        /// <summary>
        /// Метод инициирующий взаимодйствие с пользователем
        /// </summary>
        /// <returns>Следующий контекст для перехода или null для выхода</returns>
        public abstract Context Display();
    }
}

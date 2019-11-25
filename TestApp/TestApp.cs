using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    /// <summary>
    /// Основной класс приложения
    /// </summary>
    public class TestApp
    {
        /// <summary>
        /// Метод запуска приложения
        /// </summary>
        public void Run()
        {
            Console.WriteLine("Hello world!");
            Console.ReadKey();
        }

        /// <summary>
        /// Метод создает экземпляр приложения и запускает его.
        /// </summary>
        public static void Main()
        {
            TestApp app = new TestApp();
            app.Run();
        }
    }
}

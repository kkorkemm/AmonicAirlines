using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmonicSession1.Base
{
    /// <summary>
    /// Работа с БД
    /// </summary>
    public class AppData
    {
        private static AmonicSession1Entities context;

        /// <summary>
        /// Получение контекста данных
        /// </summary>
        /// <returns> Модель данных </returns>
        public static AmonicSession1Entities GetContext()
        {
            if (context == null)
                context = new AmonicSession1Entities();
            return context;
        }

        /// <summary>
        /// Текущий пользователь системы
        /// </summary>
        public static Users CurrentUser { get; set; }
    }
}

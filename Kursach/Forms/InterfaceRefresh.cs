using System;
using System.Collections.Generic;
using Kursach.Class;

namespace Kursach.Forms
{
    interface InterfaceRefresh
    {
        /// <summary>
        /// Робить оновлення класа
        /// </summary>
        void Refresh();

        /// <summary>
        /// Добавляє компоненти в форму
        /// </summary>
        void AddFunction( Type type = null, List<Value> results = null);

        /// <summary>
        /// Відображає форму
        /// </summary>
        void Show();

        /// <summary>
        /// Повертає значення, яке вказує, чи був видалений елемент управління.
        /// </summary>
        bool IsDisposed();

        /// <summary>
        /// Закриває форму
        /// </summary>
        void Close();
    }
}

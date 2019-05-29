using System;
using System.Collections.Generic;
using Kursach.Class;

namespace Kursach.Forms
{
    interface InterfaceRefresh
    {
        void Refresh();
        void AddFunction( Type type = null, List<Value> results = null);
        void Show();
        bool IsDisposed();
        void Close();
    }
}

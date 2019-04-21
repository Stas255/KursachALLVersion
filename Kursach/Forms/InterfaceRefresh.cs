using System;
using System.Collections.Generic;
using Kursach.Class;

namespace Kursach.Forms
{
    interface InterfaceRefresh
    {
        void Refresh();
        void AddFunction(List<Value> results = null, Type type = null);
        void Show();
        bool IsDisposed();
    }
}

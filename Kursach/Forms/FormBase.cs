using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Kursach.Class;
using Kursach.Forms;

namespace Kursach
{
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
        }
        public void Show()
        {
            base.Show();
        }

        public bool  IsDisposed()
        {
            return base.IsDisposed;
        }
    }
}

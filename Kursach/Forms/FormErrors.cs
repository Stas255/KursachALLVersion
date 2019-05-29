using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kursach.Class;

namespace Kursach.Forms
{
    partial class FormErrors : FormBase, InterfaceRefresh
    {
        private ListBox listBox1;
        private List<Value> results;
        public FormErrors()
        {
            InitializeComponent();
        }
        public void AddFunction(Type type, List<Value> results)
        {
            this.Text = Lang.language.TextErrorForMesanger;
            this.Size = new System.Drawing.Size(390, 205);
            this.results = results;
            listBox1 = new ListBox();
            listBox1.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom);
            listBox1.Size = new System.Drawing.Size(350, 150);
            listBox1.Location = new System.Drawing.Point(10, 10);
            listBox1.Items.AddRange(results.Where(e => e.error != -1).Select(e => e.GetInfo()).ToArray());
            this.Controls.Add(listBox1);
        }
        public void Refresh()
        {
            this.Text = Lang.language.TextErrorForMesanger;
            listBox1.Items.Clear();
            listBox1.Items.AddRange(results.Where(e => e.error != -1).Select(e => e.GetInfo()).ToArray());
        }

    }
}

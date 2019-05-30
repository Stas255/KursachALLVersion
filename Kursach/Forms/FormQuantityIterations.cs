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
    partial class FormQuantityIterations : FormBase, InterfaceRefresh
    {
        private Type type;
        private List<Value> results;
        private Label label;
        public FormQuantityIterations()
        {
            InitializeComponent();
        }
        public void AddFunction(Type type, List<Value> results)
        {
            this.type = type;
            var name = type == typeof(Funtion1) ? Lang.language.TextMenuF1 : Lang.language.TextMenuF2;
            this.Text = name;
            this.Size = new System.Drawing.Size(250, 100);

            this.results = results;
            this.Controls.Add(label);
        }
        public void Refresh()
        {
            var name = type == typeof(Funtion1) ? Lang.language.TextMenuF1 : Lang.language.TextMenuF2;
            this.Text = name;
            label.Text = $"{Lang.language.TextIteration}: {results.Count}";
        }
    }
}

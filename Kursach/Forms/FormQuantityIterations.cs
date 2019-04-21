﻿using System;
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
        public void AddFunction(List<Value> results, Type type)
        {
            this.type = type;
            var name = type == typeof(Funtion1) ? Lang.language.TextMenuF1 : Lang.language.TextMenuF2;
            this.Text = name;
            this.Size = new System.Drawing.Size(250, 100);
            this.results = results;
            label = new Label();
            label.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom);
            label.Size = new System.Drawing.Size(350, 150);
            label.Location = new System.Drawing.Point(10, 10);
            label.Text = Lang.language.TextIteration + results.Count;
            this.Controls.Add(label);
        }
        public void Refresh()
        {
            var name = type == typeof(Funtion1) ? Lang.language.TextMenuF1 : Lang.language.TextMenuF2;
            this.Text = name;
            label.Text = Lang.language.TextIteration + results.Count;
        }
    }
}

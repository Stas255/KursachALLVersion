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
    partial class FormAboutStudent : FormBase, InterfaceRefresh
    {
        private Label label;

        public FormAboutStudent()
        {
            InitializeComponent();
        }

        public void AddFunction(Type type, List<Value> results)
        {
            this.Text = Lang.language.TextStudent;
            this.Size = new Size(400, 180); 
            
            Size = new Size(300, 250);
            label = CreateLabel(new Point(0, 160), new Size(300, 30), Lang.language.NameStudnet, (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left));
            this.Controls.Add(label);

            PictureBox pictureBox1 = CreatePicture(new Point(75, 0), new Size(150, 150));
            pictureBox1.Image = Lang.language.Student;
            this.Controls.Add(pictureBox1);

            Show();
        }

        public void Refresh()
        {
            var name = Lang.language.TextStudent;
            this.Text = name;
            label.Text = Lang.language.NameStudnet;
        }
    }
}

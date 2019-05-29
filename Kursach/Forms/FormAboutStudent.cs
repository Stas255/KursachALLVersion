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

            PictureBox pictureBox1 = new PictureBox();
            Size = new Size(300, 250);
            label = new Label();
            label.Text = Lang.language.NameStudnet;
            label.Size = new Size(300, 30);
            label.Location = new Point(0, 160);
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left);
            this.Controls.Add(label);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Lang.language.Student;
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.Location = new Point(75, 0);
            pictureBox1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
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

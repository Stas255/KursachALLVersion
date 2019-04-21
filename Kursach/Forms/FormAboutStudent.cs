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
        public void AddFunction(List<Value> results, Type type)
        {
            this.Text = Lang.language.TextStudent;
            this.Size = new System.Drawing.Size(400, 180);

            PictureBox pictureBox1 = new PictureBox();
            Size = new System.Drawing.Size(300, 250);
            label = new Label();
            label.Text = Lang.language.NameStudnet + Environment.NewLine + Lang.language.GroupStudent;
            label.Size = new System.Drawing.Size(300, 30);
            label.Location = new System.Drawing.Point(0, 160);
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left);
            this.Controls.Add(label);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Lang.language._1Funtion;
            pictureBox1.Size = new System.Drawing.Size(150, 150);
            pictureBox1.Location = new System.Drawing.Point(75, 0);
            pictureBox1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            this.Controls.Add(pictureBox1);
            Show();
        }

        public void Refresh()
        {
            var name = Lang.language.TextStudent;
            this.Text = name;
            label.Text = Lang.language.NameStudnet + Environment.NewLine + Lang.language.GroupStudent;
        }
    }
}

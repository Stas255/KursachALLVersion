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
    partial class FormBase : Form
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
        public void AddPicture(string name, Type type)
        {
            this.Text = name;
            this.Size = new System.Drawing.Size(400, 180);

            PictureBox pictureBox1 = new PictureBox();

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            pictureBox1.Size = new System.Drawing.Size(390, 140);
            pictureBox1.Location = new System.Drawing.Point(0, 0);
            if (type == typeof(Funtion1))
            {
                pictureBox1.Image = Lang.language._1Funtion;
            }
            else
            {
                pictureBox1.Image = Lang.language._2Funtion;
            }
            this.Controls.Add(pictureBox1);
            Show();
        }

        public void AddPicture(string name)
        {
            this.Text = name;
            this.Size = new System.Drawing.Size(400, 180);

            PictureBox pictureBox1 = new PictureBox();
            Size = new System.Drawing.Size(300, 250);
            Label label = new Label();
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

        public void AddError(string name, List<Value> results)
        {
            this.Text = name;
            this.Size = new System.Drawing.Size(450, 550);

            ListBox listBox1 = new ListBox();
            listBox1.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom);
            listBox1.Size = new System.Drawing.Size(300, 450);
            listBox1.Location = new System.Drawing.Point(10, 50);
            results.Where(e => e.error != -1).ToList();
            listBox1.Items.AddRange(results.Select(e => e.GetError()).ToArray());
            this.Controls.Add(listBox1);
        }
    }
}

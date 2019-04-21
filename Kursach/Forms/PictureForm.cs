using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Kursach.Class;

namespace Kursach.Forms
{
    partial class PictureForm : FormBase, InterfaceRefresh
    {
        private int number;

        public void AddFunction(int number, List<Value> results, Type type)
        {
            this.number = number;
            var name = number == 1 ? Lang.language.TextMenuF1 + Lang.language.TextMenuFormula.ToLower() : Lang.language.TextMenuF2 + Lang.language.TextMenuFormula.ToLower();
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

        public void Refresh()
        {
            var name = number == 1 ? Lang.language.TextMenuF1 + Lang.language.TextMenuFormula.ToLower() : Lang.language.TextMenuF2 + Lang.language.TextMenuFormula.ToLower();
            this.Text = name;
        }
    }
}

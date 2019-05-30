using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Kursach.Class;
using System.Drawing;

namespace Kursach.Forms
{
    partial class PictureForm : FormBase, InterfaceRefresh
    {
        private Type type;

        public void AddFunction(Type type, List<Value> results)
        { 
            this.type = type;
            var name = type == typeof(Funtion1) ? Lang.language.TextMenuF1 : Lang.language.TextMenuF2;
            this.Text = name;
            this.Size = new Size(400, 180);

            PictureBox pictureBox1 = CreatePicture(new Point(0, 0), new Size(390, 140));
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
            var name = type == typeof(Funtion1) ? Lang.language.TextMenuF1 : Lang.language.TextMenuF2;
            this.Text = name;
        }
    }
}

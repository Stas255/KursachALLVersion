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

        public bool IsDisposed()
        {
            return base.IsDisposed;
        }

        public void Close()
        {
            base.Close();
        }

        /// <summary>
        /// Створює тип Label
        /// </summary>
        public Label CreateLabel(Point point, Size size, string text, AnchorStyles anchorStyles = AnchorStyles.None)
        {
            Label label = new Label();
            label.Text = text;
            label.Size = size;
            label.Location = point;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Anchor = anchorStyles;
            return label;
        }

        /// <summary>
        /// Створює тип PictureBox
        /// </summary>
        public PictureBox CreatePicture(Point point, Size size)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Location = point;
            pictureBox.Size = size;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            return pictureBox;
        }

        /// <summary>
        /// Створює тип ListBox
        /// </summary>
        public ListBox CreateListBox(Point point, Size size)
        {
            ListBox listBox1 = new ListBox();
            listBox1.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom);
            listBox1.Size = size;
            listBox1.Location = point;
            return listBox1;
        }

        /// <summary>
        /// Створює тип Chart
        /// </summary>
        public Chart CreateChart(Point point, Size size)
        {
            Chart chart1 = new Chart();
            Legend legend1 = new Legend(); //Легенда під графіком
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.TabIndex = 1;
            chart1.Location = point;
            chart1.Size = size;
            ChartArea chartArea1 = new ChartArea(); //Представляє область діаграми на зображенні діаграми.
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            chart1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            return chart1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kursach.Class;
using System.Media;
using WMPLib;

namespace Kursach
{
    public partial class FormMain : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        private DataBase dataBase;
        public FormMain()
        {
            InitializeComponent();
            CreatePicture();
        }
        public void CreatePicture()
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\stast\\Desktop\\123.png");
        }

        public bool Check()
        {
            if(string.IsNullOrWhiteSpace(textBoxXMin.Text) || string.IsNullOrWhiteSpace(textBoxXMax.Text) || string.IsNullOrWhiteSpace(textBoxDx.Text))
            {
                return false;
            }
            if (Convert.ToDouble(textBoxXMin.Text) > Convert.ToDouble(textBoxXMax.Text))
            {
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBoxA.Text);
            double xMin = Convert.ToDouble(textBoxXMin.Text);
            double xMax = Convert.ToDouble(textBoxXMax.Text);
            double dx = Convert.ToDouble(textBoxDx.Text);
            dataBase = new DataBase(a,xMax,xMin,dx);
            dataBase.Start(progressBar);
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != ',' && number != '-')
            {
                e.Handled = true;
            }

            if(number == ',' && ((sender as TextBox).Text.IndexOf(',')) > -1) {
                e.Handled = true;
            }
            if (number == '-' && ((sender as TextBox).Text.IndexOf('-')) > -1)
            {
                e.Handled = true;
            }
        }

        private void grafictToolStripMenuItemGraph1_Click(object sender, EventArgs e)
        {
            FormBase formGraf1 = new FormBase();
            formGraf1.AddFunction(Lang.language.TextMenuF1,dataBase.GetResult(typeof(Funtion1)));
        }









        private void ukrainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("uk");
            Refresh();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("es");
            Refresh();
        }
        private void Refresh()
        {
            labelNameStudent.Text = Lang.language.NameStudnet + Environment.NewLine + Lang.language.GroupStudent;
            labelInputeData.Text = Lang.language.TextInputeData;
            buttonStart.Text = Lang.language.TextButtomStart;
            toolStripStatusLabelErrors.Text = Lang.language.TextError;
            toolStripStatusLabelTime.Text = Lang.language.TextTimeWork;
            ToolStripMenuItemF1.Text = Lang.language.TextMenuF1;
            ToolStripMenuItemF2.Text = Lang.language.TextMenuF2;
            ToolStripMenuItemGraphF1.Text = ToolStripMenuItemGraphF2.Text = Lang.language.TextMenuGraf;
            ToolStripMenuItemFormulaF1.Text = ToolStripMenuItemFormulaF2.Text = Lang.language.TextMenuFormula;
            languagesToolStripMenuItem.Text = Lang.language.TextMenuLang;
            ukrainToolStripMenuItem.Text = Lang.language.TextMenuLangUkr;
            englishToolStripMenuItem.Text = Lang.language.TextMenuLangEng;
        }
        private void ricardoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelNameStudent.Text = "Ricardo Milos";
            pictureBox1.Image = Properties.Resources.ricardo1;
            player.URL = "ricardo.mp3";
            player.controls.play();
        }
    }
}

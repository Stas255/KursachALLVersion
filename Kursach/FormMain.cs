using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Kursach.Class;
using Kursach.Forms;

namespace Kursach
{
    public partial class FormMain : Form
    {
        //FormBase formGraf1, formGraf2;
        //FormBase formPicture1, formPicture2;
        //FormBase formSudent;
        //FormBase FormError;
        enum enumFoms { FormGraf1, FormGraf2, FormPicture1, FormPicture2,FormStudent, FormError, FormIteration1, FormIteration2 };
        Dictionary<enumFoms, InterfaceRefresh> dictionary = new Dictionary<enumFoms, InterfaceRefresh>();
        private DataBase dataBase;
        public FormMain()
        {
            InitializeComponent();
            Refresh();
            CreatePicture();
        }
        public void CreatePicture()
        {
            pictureBox1.Image = Lang.language._1Funtion;
        }

        public bool Check()
        {
            if(string.IsNullOrWhiteSpace(textBoxXMin.Text) || string.IsNullOrWhiteSpace(textBoxXMax.Text) || string.IsNullOrWhiteSpace(textBoxDx.Text))
            {
                MessageBox.Show(Lang.language.ErrorTextIsNull, Lang.language.TextErrorForMesanger,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Convert.ToDouble(textBoxXMin.Text) > Convert.ToDouble(textBoxXMax.Text))
            {
                MessageBox.Show(Lang.language.ErrorMaxLowMin, Lang.language.TextErrorForMesanger,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Convert.ToDouble(textBoxDx.Text) == 0.0)
            {
                MessageBox.Show(Lang.language.ErrorDxIs0, Lang.language.TextErrorForMesanger,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Check()) {
                double a = Convert.ToDouble(textBoxA.Text);
                double xMin = Convert.ToDouble(textBoxXMin.Text);
                double xMax = Convert.ToDouble(textBoxXMax.Text);
                double dx = Convert.ToDouble(textBoxDx.Text);
                dataBase = new DataBase(a, xMax, xMin, dx);
                dataBase.Start(progressBar);
                toolStripStatusLabelErrorCout.Text = DataBase.ErrorCout.ToString();
            }
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
            if (number == '-' && (sender as TextBox).Text != string.Empty)
            {
                e.Handled = true;
            }
        }

        private void grafictToolStripMenuItemGraph1_Click(object sender, EventArgs e)
        {
            if (!dictionary.ContainsKey(enumFoms.FormGraf1)) {
                dictionary.Add(enumFoms.FormGraf1, new FormGraf());
            }
            else if (dictionary[enumFoms.FormGraf1].IsDisposed())
            {
                dictionary[enumFoms.FormGraf1] = new FormGraf();
            }

            dictionary[enumFoms.FormGraf1].AddFunction(dataBase.GetResult(typeof(Funtion1)));
            dictionary[enumFoms.FormGraf1].Show();
        }
        private void ToolStripMenuItemGraphF2_Click(object sender, EventArgs e)
        {
            if (!dictionary.ContainsKey(enumFoms.FormGraf2))
            {
                dictionary.Add(enumFoms.FormGraf2, new FormGraf());
            }
            else if (dictionary[enumFoms.FormGraf2].IsDisposed())
            {
                dictionary[enumFoms.FormGraf2] = new FormGraf();
            }

            dictionary[enumFoms.FormGraf2].AddFunction(dataBase.GetResult(typeof(Funtion2)));
            dictionary[enumFoms.FormGraf2].Show();
        }
        private void ToolStripMenuItemFormulaF1_Click(object sender, EventArgs e)
        {
            if (!dictionary.ContainsKey(enumFoms.FormPicture1))
            {
                dictionary.Add(enumFoms.FormPicture1, new PictureForm());
            }
            else if (dictionary[enumFoms.FormPicture1].IsDisposed())
            {
                dictionary[enumFoms.FormPicture1] = new PictureForm();
            }
            dictionary[enumFoms.FormPicture1].AddFunction(null, typeof(Funtion1));
            dictionary[enumFoms.FormPicture1].Show();
        }
        private void ToolStripMenuItemFormulaF2_Click(object sender, EventArgs e)
        {
            if (!dictionary.ContainsKey(enumFoms.FormPicture2))
            {
                dictionary.Add(enumFoms.FormPicture2, new PictureForm());
            }
            else if (dictionary[enumFoms.FormPicture2].IsDisposed())
            {
                dictionary[enumFoms.FormPicture2] = new PictureForm();
            }
            dictionary[enumFoms.FormPicture2].AddFunction(null, typeof(Funtion2));
            dictionary[enumFoms.FormPicture2].Show();
        }
        //private bool CheckForm(FormBase formBase)
        //{
        //    //if (formBase == null || formBase.IsDisposed)
        //    //{
        //    //    return true;
        //    //}
        //    //else
        //    //{
        //    //    MessageBox.Show(formBase.Text + Lang.language.ErrorIsOpenForm, Lang.language.TextErrorForMesanger,
        //    //    MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    //    return false;
        //    //}
        //}

        private void ukrainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("uk");
            Refresh();
        }

        private void ToolStripMenuItemGraph_EnabledChanged(object sender, EventArgs e)
        {
            (sender as ToolStripMenuItem).DropDownItems[0].Enabled = (dataBase != null);
            (sender as ToolStripMenuItem).DropDownItems[2].Enabled = (dataBase != null);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString("h:mm:ss tt");
        }

        private void інформаціяПроСтудентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!dictionary.ContainsKey(enumFoms.FormStudent))
            {
                dictionary.Add(enumFoms.FormStudent, new FormAboutStudent());
            }
            else if (dictionary[enumFoms.FormStudent].IsDisposed())
            {
                dictionary[enumFoms.FormStudent] = new FormAboutStudent();
            }
            dictionary[enumFoms.FormStudent].AddFunction();
            dictionary[enumFoms.FormStudent].Show();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("es");
            Refresh();
        }

        private void toolStripStatusLabelErrorCout_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(toolStripStatusLabelErrorCout.Text) != 0)
            {
                if (!dictionary.ContainsKey(enumFoms.FormError))
                {
                    dictionary.Add(enumFoms.FormError, new FormErrors());
                }
                else if (dictionary[enumFoms.FormError].IsDisposed())
                {
                    dictionary[enumFoms.FormError] = new FormErrors();
                }

                dictionary[enumFoms.FormError].AddFunction(dataBase.GetResult(typeof(Funtion1)));
                dictionary[enumFoms.FormError].Show();
            }
            else
            {
                //ошибка помилок незнайдено
            }
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

            dictionary.Values.ToList().ForEach(e=> e.Refresh());

        }

        private void QuantityIterationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!dictionary.ContainsKey(enumFoms.FormIteration1))
            {
                dictionary.Add(enumFoms.FormIteration1, new FormQuantityIterations());
            }
            else if (dictionary[enumFoms.FormIteration1].IsDisposed())
            {
                dictionary[enumFoms.FormIteration1] = new FormQuantityIterations();
            }
            dictionary[enumFoms.FormIteration1].AddFunction(dataBase.GetResult(typeof(Funtion1)), typeof(Funtion1));
            dictionary[enumFoms.FormIteration1].Show();
        }

        private void QuantityIterationToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (!dictionary.ContainsKey(enumFoms.FormIteration2))
            {
                dictionary.Add(enumFoms.FormIteration2, new FormQuantityIterations());
            }
            else if (dictionary[enumFoms.FormIteration2].IsDisposed())
            {
                dictionary[enumFoms.FormIteration2] = new FormQuantityIterations();
            }
            dictionary[enumFoms.FormIteration2].AddFunction(dataBase.GetResult(typeof(Funtion2)), typeof(Funtion2));
            dictionary[enumFoms.FormIteration2].Show();
        }
    }
}

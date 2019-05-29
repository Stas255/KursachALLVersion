﻿using System;
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

        enum enumFoms { FormGraf1, FormGraf2, FormPicture1, FormPicture2,FormStudent, FormError, FormIteration1, FormIteration2 };
        Dictionary<enumFoms, InterfaceRefresh> dictionary = new Dictionary<enumFoms, InterfaceRefresh>();
        private DataBase dataBase;
        public FormMain()
        {
            InitializeComponent();
            Refresh();
        }

        public bool Check()
        {
            try
            {
                if (new[] {textBoxXMin, textBoxXMax, textBoxDx, textBoxA}.Any(c => string.IsNullOrWhiteSpace(c.Text)))  //Перевіряє чи немає незаповнених значень
                {
                    MessageBox.Show(Lang.language.ErrorTextIsNull, Lang.language.TextErrorForMesanger,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (Convert.ToDouble(textBoxDx.Text) == 0.0)    //Перевіряє крок на значення 0
                {
                    MessageBox.Show(Lang.language.ErrorDxIs0, Lang.language.TextErrorForMesanger,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if ((Convert.ToDouble(textBoxXMax.Text) - Convert.ToDouble(textBoxXMin.Text)) *
                    Convert.ToDouble(textBoxDx.Text) < 0)   //Перевіряє чи правильно введений крок
                {
                    MessageBox.Show(Lang.language.ErrorDx, Lang.language.TextErrorForMesanger,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxDx.Text = String.Empty;
                    return false;
                }
                foreach (var keyValuePair in dictionary)
                {
                    if (!IsShow(keyValuePair.Key))  //Перевіряє чи відкриті побічні форми
                    {
                        DialogResult result = MessageBox.Show(Lang.language.TextErrorOpenForm, Lang.language.TextErrorForMesanger,
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        if (result == DialogResult.OK)
                        {
                            dictionary.Values.ToList().ForEach(e => e.Close()); //Закриває всі форми кроми головної
                            dictionary.Clear(); //Видаляє всі ключі і значення
                            break;
                        }
                        return false;
                    }
                }
                return true;
            }
            catch (Exception e) //Приймає інші помилки
            {
                MessageBox.Show(e.ToString(), Lang.language.TextErrorForMesanger,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
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
            if (!Char.IsDigit(number) && number != 8 && number != ',' && number != '-') //Перевіряє чи є нажатий символ чиcлом, Backspace, (,), (-)
            {
                e.Handled = true;
            }

            if (number == ',' && ((sender as TextBox).Text.IndexOf(',')) > -1)  //Перевіряє щоб неповторялась кома
            {
                e.Handled = true;
            }
            if (number == '-' && (sender as TextBox).Text != string.Empty)  //Перевіряє щоб (-) був спочатку
            {
                e.Handled = true;
            }
        }

        private void grafictToolStripMenuItemGraph1_Click(object sender, EventArgs e)
        {
            CheckAndCreateFuntion(enumFoms.FormGraf1, typeof(Funtion1), new FormGraf());
        }
        private void ToolStripMenuItemGraphF2_Click(object sender, EventArgs e)
        {
            CheckAndCreateFuntion(enumFoms.FormGraf2, typeof(Funtion2), new FormGraf());
        }
        private void ToolStripMenuItemFormulaF1_Click(object sender, EventArgs e)
        {
            CheckAndCreateFuntion(enumFoms.FormPicture1, typeof(Funtion1), new PictureForm());
        }
        private void ToolStripMenuItemFormulaF2_Click(object sender, EventArgs e)
        {
            CheckAndCreateFuntion(enumFoms.FormPicture2, typeof(Funtion2), new PictureForm());
        }
        private void QuantityIterationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CheckAndCreateFuntion(enumFoms.FormIteration1, typeof(Funtion1), new FormQuantityIterations());
        }

        private void QuantityIterationToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CheckAndCreateFuntion(enumFoms.FormIteration1, typeof(Funtion1), new FormQuantityIterations());
        }
        private void CheckAndCreateFuntion(enumFoms enumFuntion, Type type, Forms.InterfaceRefresh newForm)
        {
            if (!dictionary.ContainsKey(enumFuntion))
            {
                dictionary.Add(enumFuntion, newForm);
            }
            else if (dictionary[enumFuntion].IsDisposed())
            {
                dictionary[enumFuntion] = newForm;
            }

            dictionary[enumFuntion].AddFunction(type,dataBase == null? null: dataBase.GetResult(type));
            dictionary[enumFuntion].Show();
        }
        private void ukrainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("uk");
            Refresh();
        }

        private bool IsShow(enumFoms enumFom)
        {
            return (!dictionary.ContainsKey(enumFom) || dictionary[enumFom].IsDisposed());
        }

        private void ToolStripMenuItemGraph_EnabledChanged1(object sender, EventArgs e)
        {
            (sender as ToolStripMenuItem).DropDownItems[0].Enabled = (dataBase != null && IsShow(enumFoms.FormGraf1));
            (sender as ToolStripMenuItem).DropDownItems[1].Enabled = IsShow(enumFoms.FormPicture1);
            (sender as ToolStripMenuItem).DropDownItems[2].Enabled = (dataBase != null && IsShow(enumFoms.FormIteration1));
        }
        private void ToolStripMenuItemGraph_EnabledChanged2(object sender, EventArgs e)
        {
            (sender as ToolStripMenuItem).DropDownItems[0].Enabled = (dataBase != null && IsShow(enumFoms.FormGraf2));
            (sender as ToolStripMenuItem).DropDownItems[1].Enabled = IsShow(enumFoms.FormPicture2);
            (sender as ToolStripMenuItem).DropDownItems[2].Enabled = (dataBase != null && IsShow(enumFoms.FormIteration2));
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

                dictionary[enumFoms.FormError].AddFunction(null, dataBase.GetResult(typeof(Funtion1)));
                dictionary[enumFoms.FormError].Show();
            }
        }

        private void Refresh()
        {
            this.Text = Lang.language.TextNameMainForm;
            labelInformation.Text = Lang.language.TextInformation;
            labelStudent.Text = Lang.language.TextStudentLabel;
            labelInputeData.Text = Lang.language.TextInputeData;
            buttonStart.Text = Lang.language.TextButtomStart;
            toolStripStatusLabelErrors.Text = Lang.language.TextError;
            toolStripStatusLabelTime.Text = Lang.language.TextTimeWork;
            ToolStripMenuItemF1.Text = Lang.language.TextMenuF1;
            ToolStripMenuItemF2.Text = Lang.language.TextMenuF2;
            ToolStripMenuItemGraphF1.Text = ToolStripMenuItemGraphF2.Text = Lang.language.TextMenuGraf;
            ToolStripMenuItemFormulaF1.Text = ToolStripMenuItemFormulaF2.Text = Lang.language.TextMenuFormula;
            QuantityIterationToolStripMenuItem1.Text =
                QuantityIterationToolStripMenuItem2.Text = Lang.language.TextIteration;
            languagesToolStripMenuItem.Text = Lang.language.TextMenuLang;
            ukrainToolStripMenuItem.Text = Lang.language.TextMenuLangUkr;
            englishToolStripMenuItem.Text = Lang.language.TextMenuLangEng;

            dictionary.Values.Where(e=> !e.IsDisposed()).ToList().ForEach(e => e.Refresh());

        }
    }
    
}

using System;

namespace Kursach
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ToolStripMenuItemF1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemGraphF1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFormulaF1 = new System.Windows.Forms.ToolStripMenuItem();
            this.QuantityIterationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemF2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemGraphF2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFormulaF2 = new System.Windows.Forms.ToolStripMenuItem();
            this.QuantityIterationToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.languagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ukrainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelErrors = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelErrorCout = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelStudent = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelInformation = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxDx = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxXMax = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxXMin = new System.Windows.Forms.TextBox();
            this.labelInputeData = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolStripMenuItemF1
            // 
            this.ToolStripMenuItemF1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemGraphF1,
            this.ToolStripMenuItemFormulaF1,
            this.QuantityIterationToolStripMenuItem1});
            this.ToolStripMenuItemF1.Name = "ToolStripMenuItemF1";
            resources.ApplyResources(this.ToolStripMenuItemF1, "ToolStripMenuItemF1");
            this.ToolStripMenuItemF1.DropDownOpened += new System.EventHandler(this.ToolStripMenuItemGraph_EnabledChanged);
            // 
            // ToolStripMenuItemGraphF1
            // 
            resources.ApplyResources(this.ToolStripMenuItemGraphF1, "ToolStripMenuItemGraphF1");
            this.ToolStripMenuItemGraphF1.Name = "ToolStripMenuItemGraphF1";
            this.ToolStripMenuItemGraphF1.Click += new System.EventHandler(this.grafictToolStripMenuItemGraph1_Click);
            // 
            // ToolStripMenuItemFormulaF1
            // 
            this.ToolStripMenuItemFormulaF1.Name = "ToolStripMenuItemFormulaF1";
            resources.ApplyResources(this.ToolStripMenuItemFormulaF1, "ToolStripMenuItemFormulaF1");
            this.ToolStripMenuItemFormulaF1.Click += new System.EventHandler(this.ToolStripMenuItemFormulaF1_Click);
            // 
            // QuantityIterationToolStripMenuItem1
            // 
            resources.ApplyResources(this.QuantityIterationToolStripMenuItem1, "QuantityIterationToolStripMenuItem1");
            this.QuantityIterationToolStripMenuItem1.Name = "QuantityIterationToolStripMenuItem1";
            this.QuantityIterationToolStripMenuItem1.Click += new System.EventHandler(this.QuantityIterationToolStripMenuItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemF1,
            this.ToolStripMenuItemF2,
            this.languagesToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // ToolStripMenuItemF2
            // 
            this.ToolStripMenuItemF2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemGraphF2,
            this.ToolStripMenuItemFormulaF2,
            this.QuantityIterationToolStripMenuItem2});
            this.ToolStripMenuItemF2.Name = "ToolStripMenuItemF2";
            resources.ApplyResources(this.ToolStripMenuItemF2, "ToolStripMenuItemF2");
            this.ToolStripMenuItemF2.DropDownOpened += new System.EventHandler(this.ToolStripMenuItemGraph_EnabledChanged);
            // 
            // ToolStripMenuItemGraphF2
            // 
            resources.ApplyResources(this.ToolStripMenuItemGraphF2, "ToolStripMenuItemGraphF2");
            this.ToolStripMenuItemGraphF2.Name = "ToolStripMenuItemGraphF2";
            this.ToolStripMenuItemGraphF2.Click += new System.EventHandler(this.ToolStripMenuItemGraphF2_Click);
            // 
            // ToolStripMenuItemFormulaF2
            // 
            this.ToolStripMenuItemFormulaF2.Name = "ToolStripMenuItemFormulaF2";
            resources.ApplyResources(this.ToolStripMenuItemFormulaF2, "ToolStripMenuItemFormulaF2");
            this.ToolStripMenuItemFormulaF2.Click += new System.EventHandler(this.ToolStripMenuItemFormulaF2_Click);
            // 
            // QuantityIterationToolStripMenuItem2
            // 
            resources.ApplyResources(this.QuantityIterationToolStripMenuItem2, "QuantityIterationToolStripMenuItem2");
            this.QuantityIterationToolStripMenuItem2.Name = "QuantityIterationToolStripMenuItem2";
            this.QuantityIterationToolStripMenuItem2.Click += new System.EventHandler(this.QuantityIterationToolStripMenuItem2_Click);
            // 
            // languagesToolStripMenuItem
            // 
            this.languagesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ukrainToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.languagesToolStripMenuItem.Name = "languagesToolStripMenuItem";
            resources.ApplyResources(this.languagesToolStripMenuItem, "languagesToolStripMenuItem");
            // 
            // ukrainToolStripMenuItem
            // 
            this.ukrainToolStripMenuItem.Name = "ukrainToolStripMenuItem";
            resources.ApplyResources(this.ukrainToolStripMenuItem, "ukrainToolStripMenuItem");
            this.ukrainToolStripMenuItem.Click += new System.EventHandler(this.LanguageToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.LanguageToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelErrors,
            this.toolStripStatusLabelErrorCout,
            this.toolStripStatusLabelTime,
            this.toolStripStatusLabel1});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabelErrors
            // 
            this.toolStripStatusLabelErrors.Name = "toolStripStatusLabelErrors";
            resources.ApplyResources(this.toolStripStatusLabelErrors, "toolStripStatusLabelErrors");
            this.toolStripStatusLabelErrors.Click += new System.EventHandler(this.toolStripStatusLabelErrorCout_Click);
            // 
            // toolStripStatusLabelErrorCout
            // 
            this.toolStripStatusLabelErrorCout.Name = "toolStripStatusLabelErrorCout";
            resources.ApplyResources(this.toolStripStatusLabelErrorCout, "toolStripStatusLabelErrorCout");
            this.toolStripStatusLabelErrorCout.Click += new System.EventHandler(this.toolStripStatusLabelErrorCout_Click);
            // 
            // toolStripStatusLabelTime
            // 
            this.toolStripStatusLabelTime.Name = "toolStripStatusLabelTime";
            resources.ApplyResources(this.toolStripStatusLabelTime, "toolStripStatusLabelTime");
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.progressBar);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelStudent);
            this.panel3.Controls.Add(this.buttonStart);
            this.panel3.Controls.Add(this.labelInformation);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // labelStudent
            // 
            resources.ApplyResources(this.labelStudent, "labelStudent");
            this.labelStudent.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelStudent.Name = "labelStudent";
            this.labelStudent.Click += new System.EventHandler(this.InformationAboutStudentToolStripMenuItem_Click);
            // 
            // buttonStart
            // 
            resources.ApplyResources(this.buttonStart, "buttonStart");
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelInformation
            // 
            resources.ApplyResources(this.labelInformation, "labelInformation");
            this.labelInformation.Name = "labelInformation";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.labelInputeData);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxDx);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // textBoxDx
            // 
            resources.ApplyResources(this.textBoxDx, "textBoxDx");
            this.textBoxDx.Name = "textBoxDx";
            this.textBoxDx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxA);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // textBoxA
            // 
            resources.ApplyResources(this.textBoxA, "textBoxA");
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxXMax);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // textBoxXMax
            // 
            resources.ApplyResources(this.textBoxXMax, "textBoxXMax");
            this.textBoxXMax.Name = "textBoxXMax";
            this.textBoxXMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxXMin);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // textBoxXMin
            // 
            resources.ApplyResources(this.textBoxXMin, "textBoxXMin");
            this.textBoxXMin.Name = "textBoxXMin";
            this.textBoxXMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // labelInputeData
            // 
            resources.ApplyResources(this.labelInputeData, "labelInputeData");
            this.labelInputeData.Name = "labelInputeData";
            // 
            // progressBar
            // 
            resources.ApplyResources(this.progressBar, "progressBar");
            this.progressBar.Name = "progressBar";
            this.progressBar.Step = 100;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemF1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemGraphF1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFormulaF1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemF2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemGraphF2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFormulaF2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelErrors;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelInputeData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxXMin;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxDx;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxXMax;
        private System.Windows.Forms.ToolStripMenuItem languagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ukrainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        internal System.Windows.Forms.Label labelInformation;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelErrorCout;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem QuantityIterationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem QuantityIterationToolStripMenuItem2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label labelStudent;
    }
}


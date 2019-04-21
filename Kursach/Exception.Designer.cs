namespace Kursach
{
    partial class Exception
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttom_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // buttom_OK
            // 
            this.buttom_OK.AutoSize = true;
            this.buttom_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttom_OK.Location = new System.Drawing.Point(382, 103);
            this.buttom_OK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttom_OK.Name = "buttom_OK";
            this.buttom_OK.Size = new System.Drawing.Size(56, 23);
            this.buttom_OK.TabIndex = 1;
            this.buttom_OK.Text = "OK";
            this.buttom_OK.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttom_OK.UseVisualStyleBackColor = true;
            this.buttom_OK.Click += new System.EventHandler(this.buttom_OK_Click);
            // 
            // Exception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(452, 132);
            this.Controls.Add(this.buttom_OK);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Exception";
            this.Text = "Exception";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttom_OK;
        public System.Windows.Forms.Label label1;
    }
}
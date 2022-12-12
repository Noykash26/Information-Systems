namespace scouts
{
    partial class FormToFill
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
            this.label_FillForm = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_selectForm = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_FillForm
            // 
            this.label_FillForm.AutoSize = true;
            this.label_FillForm.Location = new System.Drawing.Point(688, 81);
            this.label_FillForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_FillForm.Name = "label_FillForm";
            this.label_FillForm.Size = new System.Drawing.Size(88, 17);
            this.label_FillForm.TabIndex = 0;
            this.label_FillForm.Text = "טפסים פתוחים";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 74);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_selectForm
            // 
            this.comboBox_selectForm.FormattingEnabled = true;
            this.comboBox_selectForm.Location = new System.Drawing.Point(402, 74);
            this.comboBox_selectForm.Name = "comboBox_selectForm";
            this.comboBox_selectForm.Size = new System.Drawing.Size(121, 24);
            this.comboBox_selectForm.TabIndex = 2;
            // 
            // FormToFill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.comboBox_selectForm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_FillForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormToFill";
            this.Text = "FormToFill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_FillForm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_selectForm;
    }
}
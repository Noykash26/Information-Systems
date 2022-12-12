namespace scouts
{
    partial class CreateForm
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
            this.button_ganerate = new System.Windows.Forms.Button();
            this.textBox_boolean = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelCreateForm = new System.Windows.Forms.Panel();
            this.textBox_FreeText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_ganerate
            // 
            this.button_ganerate.Location = new System.Drawing.Point(576, 75);
            this.button_ganerate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_ganerate.Name = "button_ganerate";
            this.button_ganerate.Size = new System.Drawing.Size(75, 23);
            this.button_ganerate.TabIndex = 13;
            this.button_ganerate.Text = "create";
            this.button_ganerate.UseVisualStyleBackColor = true;
            this.button_ganerate.Click += new System.EventHandler(this.button_ganerate_Click);
            // 
            // textBox_boolean
            // 
            this.textBox_boolean.Location = new System.Drawing.Point(432, 103);
            this.textBox_boolean.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_boolean.Name = "textBox_boolean";
            this.textBox_boolean.Size = new System.Drawing.Size(97, 20);
            this.textBox_boolean.TabIndex = 12;
            this.textBox_boolean.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_boolean_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(27, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(289, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "how many free text fields would you like";
            // 
            // panelCreateForm
            // 
            this.panelCreateForm.Location = new System.Drawing.Point(12, 127);
            this.panelCreateForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCreateForm.Name = "panelCreateForm";
            this.panelCreateForm.Size = new System.Drawing.Size(862, 396);
            this.panelCreateForm.TabIndex = 9;
            // 
            // textBox_FreeText
            // 
            this.textBox_FreeText.Location = new System.Drawing.Point(432, 61);
            this.textBox_FreeText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_FreeText.Name = "textBox_FreeText";
            this.textBox_FreeText.Size = new System.Drawing.Size(97, 20);
            this.textBox_FreeText.TabIndex = 8;
            this.textBox_FreeText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_FreeText_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "create form";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(27, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "how many checkBox fields would you like";
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 596);
            this.Controls.Add(this.button_ganerate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_boolean);
            this.Controls.Add(this.panelCreateForm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_FreeText);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateForm";
            this.Text = "CreateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ganerate;
        private System.Windows.Forms.TextBox textBox_boolean;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelCreateForm;
        private System.Windows.Forms.TextBox textBox_FreeText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}
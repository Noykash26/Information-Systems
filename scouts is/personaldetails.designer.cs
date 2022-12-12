namespace scouts
{
    partial class personaldetails
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
            this.lbl_nameHeb = new System.Windows.Forms.Label();
            this.lbl_nameEng = new System.Windows.Forms.Label();
            this.panel_nameheb = new System.Windows.Forms.Panel();
            this.button_updateDet = new System.Windows.Forms.Button();
            this.textbox_phone = new System.Windows.Forms.TextBox();
            this.TextBox_nameHeb = new System.Windows.Forms.TextBox();
            this.TextBox_nameENG = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.dateTimePicker_birth = new System.Windows.Forms.DateTimePicker();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.panel_nameheb.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_nameHeb
            // 
            this.lbl_nameHeb.AutoSize = true;
            this.lbl_nameHeb.Location = new System.Drawing.Point(22, 69);
            this.lbl_nameHeb.Name = "lbl_nameHeb";
            this.lbl_nameHeb.Size = new System.Drawing.Size(87, 17);
            this.lbl_nameHeb.TabIndex = 0;
            this.lbl_nameHeb.Text = "Name (HEB)";
            // 
            // lbl_nameEng
            // 
            this.lbl_nameEng.AutoSize = true;
            this.lbl_nameEng.Location = new System.Drawing.Point(22, 22);
            this.lbl_nameEng.Name = "lbl_nameEng";
            this.lbl_nameEng.Size = new System.Drawing.Size(89, 17);
            this.lbl_nameEng.TabIndex = 1;
            this.lbl_nameEng.Text = "Name (ENG)";
            // 
            // panel_nameheb
            // 
            this.panel_nameheb.Controls.Add(this.genderComboBox);
            this.panel_nameheb.Controls.Add(this.dateTimePicker_birth);
            this.panel_nameheb.Controls.Add(this.label_email);
            this.panel_nameheb.Controls.Add(this.button_updateDet);
            this.panel_nameheb.Controls.Add(this.textbox_phone);
            this.panel_nameheb.Controls.Add(this.TextBox_nameHeb);
            this.panel_nameheb.Controls.Add(this.TextBox_nameENG);
            this.panel_nameheb.Controls.Add(this.label4);
            this.panel_nameheb.Controls.Add(this.label3);
            this.panel_nameheb.Controls.Add(this.label2);
            this.panel_nameheb.Controls.Add(this.label1);
            this.panel_nameheb.Controls.Add(this.lbl_nameHeb);
            this.panel_nameheb.Controls.Add(this.lbl_nameEng);
            this.panel_nameheb.Location = new System.Drawing.Point(376, 7);
            this.panel_nameheb.Name = "panel_nameheb";
            this.panel_nameheb.Size = new System.Drawing.Size(404, 385);
            this.panel_nameheb.TabIndex = 2;
            this.panel_nameheb.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_nameheb_Paint);
            // 
            // button_updateDet
            // 
            this.button_updateDet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_updateDet.Location = new System.Drawing.Point(162, 306);
            this.button_updateDet.Name = "button_updateDet";
            this.button_updateDet.Size = new System.Drawing.Size(92, 40);
            this.button_updateDet.TabIndex = 3;
            this.button_updateDet.Text = "Update";
            this.button_updateDet.UseVisualStyleBackColor = false;
            this.button_updateDet.Click += new System.EventHandler(this.button_updateDet_Click);
            // 
            // textbox_phone
            // 
            this.textbox_phone.Location = new System.Drawing.Point(162, 248);
            this.textbox_phone.MaxLength = 10;
            this.textbox_phone.Name = "textbox_phone";
            this.textbox_phone.Size = new System.Drawing.Size(237, 22);
            this.textbox_phone.TabIndex = 11;
            this.textbox_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_phone_KeyPress);
            // 
            // TextBox_nameHeb
            // 
            this.TextBox_nameHeb.Location = new System.Drawing.Point(162, 69);
            this.TextBox_nameHeb.Name = "TextBox_nameHeb";
            this.TextBox_nameHeb.Size = new System.Drawing.Size(237, 22);
            this.TextBox_nameHeb.TabIndex = 7;
            // 
            // TextBox_nameENG
            // 
            this.TextBox_nameENG.Location = new System.Drawing.Point(162, 22);
            this.TextBox_nameENG.Name = "TextBox_nameENG";
            this.TextBox_nameENG.Size = new System.Drawing.Size(237, 22);
            this.TextBox_nameENG.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date of bIrth";
            // 
            // label_email
            // 
            this.label_email.Location = new System.Drawing.Point(162, 169);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(158, 23);
            this.label_email.TabIndex = 12;
            this.label_email.Text = "label5";
            // 
            // dateTimePicker_birth
            // 
            this.dateTimePicker_birth.Location = new System.Drawing.Point(163, 120);
            this.dateTimePicker_birth.Name = "dateTimePicker_birth";
            this.dateTimePicker_birth.Size = new System.Drawing.Size(236, 22);
            this.dateTimePicker_birth.TabIndex = 13;
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(165, 204);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(233, 24);
            this.genderComboBox.TabIndex = 14;
            // 
            // personaldetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 553);
            this.Controls.Add(this.panel_nameheb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "personaldetails";
            this.Text = "personaldetails";
            this.Load += new System.EventHandler(this.personaldetails_Load);
            this.panel_nameheb.ResumeLayout(false);
            this.panel_nameheb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_nameHeb;
        private System.Windows.Forms.Label lbl_nameEng;
        private System.Windows.Forms.Panel panel_nameheb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox_nameENG;
        private System.Windows.Forms.TextBox textbox_phone;
        private System.Windows.Forms.TextBox TextBox_nameHeb;
        private System.Windows.Forms.Button button_updateDet;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.DateTimePicker dateTimePicker_birth;
        private System.Windows.Forms.ComboBox genderComboBox;
    }
}
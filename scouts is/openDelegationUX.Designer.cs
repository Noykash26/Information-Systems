namespace scouts
{
    partial class openDelegationUX
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lable_delname = new System.Windows.Forms.Label();
            this.lable_delinfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_register = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lable_delname
            // 
            this.lable_delname.AutoEllipsis = true;
            this.lable_delname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lable_delname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lable_delname.Location = new System.Drawing.Point(152, 18);
            this.lable_delname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable_delname.Name = "lable_delname";
            this.lable_delname.Size = new System.Drawing.Size(494, 34);
            this.lable_delname.TabIndex = 1;
            this.lable_delname.Text = "title text";
            this.lable_delname.MouseEnter += new System.EventHandler(this.openDelegationUX_MouseEnter);
            this.lable_delname.MouseLeave += new System.EventHandler(this.openDelegationUX_MouseLeave);
            // 
            // lable_delinfo
            // 
            this.lable_delinfo.AutoEllipsis = true;
            this.lable_delinfo.Location = new System.Drawing.Point(154, 58);
            this.lable_delinfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable_delinfo.Name = "lable_delinfo";
            this.lable_delinfo.Size = new System.Drawing.Size(514, 89);
            this.lable_delinfo.TabIndex = 2;
            this.lable_delinfo.Text = "some text here";
            this.lable_delinfo.MouseEnter += new System.EventHandler(this.openDelegationUX_MouseEnter);
            this.lable_delinfo.MouseLeave += new System.EventHandler(this.openDelegationUX_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 197);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 46);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(131, 196);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(556, 1);
            this.panel2.TabIndex = 1;
            // 
            // button_register
            // 
            this.button_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_register.Location = new System.Drawing.Point(347, 136);
            this.button_register.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(110, 34);
            this.button_register.TabIndex = 4;
            this.button_register.Text = "Register";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // openDelegationUX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lable_delinfo);
            this.Controls.Add(this.lable_delname);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "openDelegationUX";
            this.Size = new System.Drawing.Size(694, 195);
            this.MouseEnter += new System.EventHandler(this.openDelegationUX_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.openDelegationUX_MouseLeave);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lable_delname;
        private System.Windows.Forms.Label lable_delinfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_register;
    }
}

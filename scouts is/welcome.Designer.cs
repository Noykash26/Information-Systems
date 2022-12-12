namespace scouts
{
    partial class welcome
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_passport = new System.Windows.Forms.Button();
            this.button_logOut = new System.Windows.Forms.Button();
            this.button_coordinator = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_PersonalDetails = new System.Windows.Forms.Button();
            this.button_fillForms = new System.Windows.Forms.Button();
            this.button_OpenDelegations = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.welcomUserName = new System.Windows.Forms.Label();
            this.panel_content = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button_passport);
            this.panel1.Controls.Add(this.button_logOut);
            this.panel1.Controls.Add(this.button_coordinator);
            this.panel1.Controls.Add(this.button_exit);
            this.panel1.Controls.Add(this.button_PersonalDetails);
            this.panel1.Controls.Add(this.button_fillForms);
            this.panel1.Controls.Add(this.button_OpenDelegations);
            this.panel1.Location = new System.Drawing.Point(1, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 449);
            this.panel1.TabIndex = 0;
            // 
            // button_passport
            // 
            this.button_passport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_passport.Location = new System.Drawing.Point(46, 271);
            this.button_passport.Margin = new System.Windows.Forms.Padding(2);
            this.button_passport.Name = "button_passport";
            this.button_passport.Size = new System.Drawing.Size(142, 50);
            this.button_passport.TabIndex = 6;
            this.button_passport.Text = "Upload a Passport";
            this.button_passport.UseVisualStyleBackColor = true;
            this.button_passport.Click += new System.EventHandler(this.button_passport_Click);
            // 
            // button_logOut
            // 
            this.button_logOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_logOut.Location = new System.Drawing.Point(26, 374);
            this.button_logOut.Margin = new System.Windows.Forms.Padding(2);
            this.button_logOut.Name = "button_logOut";
            this.button_logOut.Size = new System.Drawing.Size(80, 40);
            this.button_logOut.TabIndex = 5;
            this.button_logOut.Text = "Log Out";
            this.button_logOut.UseVisualStyleBackColor = true;
            this.button_logOut.Click += new System.EventHandler(this.button_logOut_Click);
            // 
            // button_coordinator
            // 
            this.button_coordinator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_coordinator.Location = new System.Drawing.Point(44, 209);
            this.button_coordinator.Margin = new System.Windows.Forms.Padding(2);
            this.button_coordinator.Name = "button_coordinator";
            this.button_coordinator.Size = new System.Drawing.Size(145, 52);
            this.button_coordinator.TabIndex = 4;
            this.button_coordinator.Text = "Log In as Coordinator";
            this.button_coordinator.UseVisualStyleBackColor = true;
            this.button_coordinator.Click += new System.EventHandler(this.button_coordinator_Click);
            // 
            // button_exit
            // 
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_exit.Location = new System.Drawing.Point(123, 374);
            this.button_exit.Margin = new System.Windows.Forms.Padding(2);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(80, 40);
            this.button_exit.TabIndex = 3;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_PersonalDetails
            // 
            this.button_PersonalDetails.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_PersonalDetails.Location = new System.Drawing.Point(44, 164);
            this.button_PersonalDetails.Margin = new System.Windows.Forms.Padding(2);
            this.button_PersonalDetails.Name = "button_PersonalDetails";
            this.button_PersonalDetails.Size = new System.Drawing.Size(145, 40);
            this.button_PersonalDetails.TabIndex = 2;
            this.button_PersonalDetails.Text = "Personal Details";
            this.button_PersonalDetails.UseVisualStyleBackColor = true;
            this.button_PersonalDetails.Click += new System.EventHandler(this.button_PersonalDetails_Click);
            // 
            // button_fillForms
            // 
            this.button_fillForms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_fillForms.Location = new System.Drawing.Point(44, 119);
            this.button_fillForms.Margin = new System.Windows.Forms.Padding(2);
            this.button_fillForms.Name = "button_fillForms";
            this.button_fillForms.Size = new System.Drawing.Size(145, 40);
            this.button_fillForms.TabIndex = 1;
            this.button_fillForms.Text = "Fill Forms";
            this.button_fillForms.UseVisualStyleBackColor = true;
            this.button_fillForms.Click += new System.EventHandler(this.button_fillForms_Click);
            // 
            // button_OpenDelegations
            // 
            this.button_OpenDelegations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_OpenDelegations.Location = new System.Drawing.Point(44, 73);
            this.button_OpenDelegations.Margin = new System.Windows.Forms.Padding(2);
            this.button_OpenDelegations.Name = "button_OpenDelegations";
            this.button_OpenDelegations.Size = new System.Drawing.Size(145, 40);
            this.button_OpenDelegations.TabIndex = 0;
            this.button_OpenDelegations.Text = "Open Delegations";
            this.button_OpenDelegations.UseVisualStyleBackColor = true;
            this.button_OpenDelegations.UseWaitCursor = true;
            this.button_OpenDelegations.Click += new System.EventHandler(this.button_OpenDelegations_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel_content);
            this.panel2.Location = new System.Drawing.Point(245, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(841, 449);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.welcomUserName);
            this.panel3.Location = new System.Drawing.Point(-8, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(850, 73);
            this.panel3.TabIndex = 3;
            // 
            // welcomUserName
            // 
            this.welcomUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcomUserName.AutoSize = true;
            this.welcomUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.welcomUserName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.welcomUserName.Location = new System.Drawing.Point(183, 16);
            this.welcomUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomUserName.Name = "welcomUserName";
            this.welcomUserName.Size = new System.Drawing.Size(118, 29);
            this.welcomUserName.TabIndex = 0;
            this.welcomUserName.Text = "welcome";
            this.welcomUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.welcomUserName.UseWaitCursor = true;
            // 
            // panel_content
            // 
            this.panel_content.BackColor = System.Drawing.Color.LightGray;
            this.panel_content.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel_content.Location = new System.Drawing.Point(0, 71);
            this.panel_content.Margin = new System.Windows.Forms.Padding(2);
            this.panel_content.Name = "panel_content";
            this.panel_content.Size = new System.Drawing.Size(841, 372);
            this.panel_content.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 449);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(500, 500);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "welcome";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_PersonalDetails;
        private System.Windows.Forms.Button button_fillForms;
        private System.Windows.Forms.Button button_OpenDelegations;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label welcomUserName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel_content;
        private System.Windows.Forms.Button button_coordinator;
        private System.Windows.Forms.Button button_logOut;
        private System.Windows.Forms.Button button_passport;
        private System.Windows.Forms.Panel panel3;
    }
}
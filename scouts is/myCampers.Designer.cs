namespace scouts
{
    partial class myCampers
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
            this.dataGridView_Campers = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Campers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Campers
            // 
            this.dataGridView_Campers.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_Campers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Campers.Location = new System.Drawing.Point(8, 70);
            this.dataGridView_Campers.Name = "dataGridView_Campers";
            this.dataGridView_Campers.RowHeadersWidth = 51;
            this.dataGridView_Campers.RowTemplate.Height = 24;
            this.dataGridView_Campers.Size = new System.Drawing.Size(1055, 382);
            this.dataGridView_Campers.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(7, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1055, 60);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(376, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Campers";
            // 
            // myCampers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 455);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_Campers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "myCampers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "myCampers";
            this.Load += new System.EventHandler(this.myCampers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Campers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Campers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
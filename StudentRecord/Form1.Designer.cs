namespace StudentRecord
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ComputerScience = new System.Windows.Forms.Button();
            this.Electronics = new System.Windows.Forms.Button();
            this.Electrical = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(76, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(585, 215);
            this.dataGridView1.TabIndex = 0;
            // 
            // ComputerScience
            // 
            this.ComputerScience.Location = new System.Drawing.Point(142, 86);
            this.ComputerScience.Name = "ComputerScience";
            this.ComputerScience.Size = new System.Drawing.Size(75, 23);
            this.ComputerScience.TabIndex = 1;
            this.ComputerScience.Text = "CSE";
            this.ComputerScience.UseVisualStyleBackColor = true;
            this.ComputerScience.Click += new System.EventHandler(this.ComputerScience_Click);
            // 
            // Electronics
            // 
            this.Electronics.Location = new System.Drawing.Point(324, 85);
            this.Electronics.Name = "Electronics";
            this.Electronics.Size = new System.Drawing.Size(75, 23);
            this.Electronics.TabIndex = 2;
            this.Electronics.Text = "ECE";
            this.Electronics.UseVisualStyleBackColor = true;
            this.Electronics.Click += new System.EventHandler(this.Electronics_Click);
            // 
            // Electrical
            // 
            this.Electrical.Location = new System.Drawing.Point(522, 85);
            this.Electrical.Name = "Electrical";
            this.Electrical.Size = new System.Drawing.Size(75, 23);
            this.Electrical.TabIndex = 3;
            this.Electrical.Text = "EEE";
            this.Electrical.UseVisualStyleBackColor = true;
            this.Electrical.Click += new System.EventHandler(this.Electrical_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Electrical);
            this.Controls.Add(this.Electronics);
            this.Controls.Add(this.ComputerScience);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ComputerScience;
        private System.Windows.Forms.Button Electronics;
        private System.Windows.Forms.Button Electrical;
    }
}


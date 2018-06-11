namespace Masina
{
    partial class Arbore
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Venit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Putere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vechime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 302);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nume,
            this.Venit,
            this.Buget,
            this.Marime,
            this.Putere,
            this.Vechime});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(651, 302);
            this.dataGridView1.TabIndex = 1;
            // 
            // Nume
            // 
            this.Nume.HeaderText = "Nume";
            this.Nume.Name = "Nume";
            // 
            // Venit
            // 
            this.Venit.HeaderText = "Venit";
            this.Venit.Name = "Venit";
            // 
            // Buget
            // 
            this.Buget.HeaderText = "Buget";
            this.Buget.Name = "Buget";
            // 
            // Marime
            // 
            this.Marime.HeaderText = "Marime";
            this.Marime.Name = "Marime";
            // 
            // Putere
            // 
            this.Putere.HeaderText = "Putere";
            this.Putere.Name = "Putere";
            // 
            // Vechime
            // 
            this.Vechime.HeaderText = "Vechime";
            this.Vechime.Name = "Vechime";
            // 
            // Arbore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 302);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Arbore";
            this.Text = "Arbore";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Venit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Buget;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Putere;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vechime;
    }
}
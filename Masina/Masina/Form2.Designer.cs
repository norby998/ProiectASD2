namespace Masina
{
    partial class Form2
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
            this.Nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Venit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Putere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vechime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(650, 290);
            this.dataGridView1.TabIndex = 0;
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 288);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Venit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Buget;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Putere;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vechime;
    }
}
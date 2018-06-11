using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Masina
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(ref Lista<Selectie> l)
        {
            InitializeComponent();
            foreach(Selectie s in l)
            {
                dataGridView1.Rows.Add(s.Nume, s.Venit, s.Buget, s.Marime, s.Putere, s.Vechime);
            }
            
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

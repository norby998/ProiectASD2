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
    public partial class Arbore : Form
    {
        public Arbore(ref Tree<Selectie> l)
        {
            InitializeComponent();
            foreach (Selectie s in l)
            {
                dataGridView1.Rows.Add(s.Nume, s.Venit, s.Buget, s.Marime, s.Putere, s.Vechime);
            }
        }

        public Arbore()
        {
            InitializeComponent();
        }
    }
}

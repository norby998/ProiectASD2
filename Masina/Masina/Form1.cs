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
    public partial class Form1 : Form
    {
        int score;
        struct masina
        {
            public string n;
            public int id;
        };
        Selectie selectie = new Selectie();
        Lista<Selectie> istoric = new Lista<Selectie>();
        public Tree<Selectie> istoricSortat = new Tree<Selectie>();


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Lista<int> l = new Lista<int>();
            l.Adauga(1);
            l.Adauga(2);
            l.Adauga(3);
            String s = "";
            foreach(int el in l)
            {
                s += el.ToString();
            }
            MessageBox.Show(s);*/
            
            
            masina a41;
            masina a42;
            masina a43;
            masina a44;
            masina a31;
            masina a32;
            masina a33;
            masina a34;
            masina g7;
            masina g6;
            masina g5;
            masina g4;
            masina a61;
            masina a62;
            masina a63;
            masina a64;

            a41.n = "Audi A4 2013-2018";
            a41.id = 13265;

            a42.n = "Audi A4 2008-2013";
            a42.id = 23254;

            a43.n = "Audi A4 2003-2008";
            a43.id = 32223;

            a44.n = "Audi A4 1996-2003";
            a44.id = 42211;

            a31.n = "Audi A3 2013-2018";
            a31.id = 12154;

            a32.n = "Audi A3 2008-2013";
            a32.id = 22143;

            a33.n = "Audi A3 2003-2008";
            a33.id = 32132;

            a34.n = "Audi A3 1996-2003";
            a34.id = 41111;

            g7.n = "Volkswagen Golf 7 (2018-2013)";
            g7.id = 13164;

            g6.n = "Volskwagen Golf 6 (2008-2013)";
            g6.id = 22142;

            g5.n = "Volkswagen Golf 5 (2003-2008)";
            g5.id = 32122;

            g4.n = "Volkswagen Golf 4 (1998-2003)";
            g4.id = 42111;

            a61.n = "Audi A6 2018-2013";
            a61.id = 14366;

            a62.n = "Audi A6 2008-2013";
            a62.id = 23355;

            a63.n = "Audi A6 2003-2008";
            a63.id = 33344;

            a64.n = "Audi A6 1996-2003";
            a64.id = 42322;





            MessageBox.Show("Masina recomandata este:\n");
            if (a41.id == score) MessageBox.Show("\n" + a41.n);
            if (a42.id == score) MessageBox.Show("\n" + a42.n);
            if (a43.id == score) MessageBox.Show("\n" + a43.n);
            if (a44.id == score) MessageBox.Show("\n" + a44.n);
            if (a31.id == score) MessageBox.Show("\n" + a31.n);
            if (a32.id == score) MessageBox.Show("\n" + a32.n);
            if (a33.id == score) MessageBox.Show("\n" + a33.n);
            if (a34.id == score) MessageBox.Show("\n" + a34.n);
            if (g7.id == score) MessageBox.Show("\n" + g7.n);
            if (g6.id == score) MessageBox.Show("\n" + g6.n);
            if (g5.id == score) MessageBox.Show("\n" + g5.n);
            if (g4.id == score) MessageBox.Show("\n" + g4.n);
            if (a61.id == score) MessageBox.Show("\n" + a61.n);
            if (a62.id == score) MessageBox.Show("\n" + a62.n);
            if (a63.id == score) MessageBox.Show("\n" + a63.n);
            if (a64.id == score) MessageBox.Show("\n" + a64.n);
            else 
            MessageBox.Show("\n" + "Nu exista nici o masina cu aceste preferinte!");
            selectie.Nume = textBox1.Text;
            istoric.Adauga(new Selectie(selectie));
            istoricSortat.Add(new Selectie(selectie));
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) score += 1;
            selectie.Venit = checkBox1.Text;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true) score += 2;
			selectie.Venit = checkBox2.Text;
		}

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true) score += 3;
			selectie.Venit = checkBox3.Text;
		}

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true) score += 4;
			selectie.Venit = checkBox4.Text;
		}

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true) score += 5;
			selectie.Venit = checkBox5.Text;
		}

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true) score += 6;
			selectie.Venit = checkBox6.Text;
		}

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true) score += 10;
			selectie.Buget = checkBox7.Text;

		}

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true) score += 20;
			selectie.Buget = checkBox8.Text;
		}

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true) score += 30;
			selectie.Buget = checkBox9.Text;
		}

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true) score += 40;
			selectie.Buget = checkBox10.Text;
		}

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true) score += 50;
			selectie.Buget = checkBox11.Text;
		}

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true) score += 60;
			selectie.Buget = checkBox12.Text;
		}

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true) score += 100;
			selectie.Marime = checkBox13.Text;
		}

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked == true) score += 200;
			selectie.Marime = checkBox14.Text;
		}

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked == true) score += 300;
			selectie.Marime = checkBox15.Text;
		}

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked == true) score += 1000;
			selectie.Putere = checkBox16.Text;
		}

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked == true) score += 2000;
			selectie.Putere = checkBox17.Text;
		}

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked == true) score += 3000;
			selectie.Putere = checkBox18.Text;
		}

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox19.Checked == true) score += 4000;
			selectie.Putere = checkBox19.Text;
		}

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox20.Checked == true) score += 10000;
			selectie.Vechime = checkBox20.Text;
		}

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox21.Checked == true) score += 20000;
			selectie.Vechime = checkBox21.Text;
		}

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox22.Checked == true) score += 30000;
			selectie.Vechime = checkBox22.Text;
		}

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox23.Checked == true) score += 40000;
			selectie.Vechime = checkBox23.Text;
		}

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(ref istoric);
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Arbore f = new Arbore(ref istoricSortat);
            f.Show();
        }
    }
}

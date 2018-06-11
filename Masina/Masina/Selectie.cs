using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masina
{
    public class Selectie : IComparable
    {
        private String nume = "", venit = "", buget = "", marime = "", putere = "", vechime = "";
        public Selectie()
        {

        }

        public Selectie(Selectie s)
        {
            nume = s.nume;
            venit = s.venit;
            buget = s.buget;
            marime = s.marime;
            putere = s.putere;
            vechime = s.vechime;
        }

        public Selectie(String nume, String venit, String buget, String marime, String putere, String vechime)
        {
            Nume = nume;
            Venit = venit;
            Buget = buget;
            Marime = marime;
            Putere = putere;
            Vechime = vechime;
        }
        public String Nume
        {
            get
            {
                return this.nume;
            }
            set
            {
                this.nume = value;
            }
        }
        public String Venit
        {
            get
            {
                return this.venit;
            }
            set
            {
                this.venit = value;
            }
        }
        public String Buget
        {
            get
            {
                return this.buget;
            }
            set
            {
                this.buget = value;
            }
        }
        public String Marime
        {
            get
            {
                return this.marime;
            }
            set
            {
                this.marime = value;
            }
        }
        public String Putere
        {
            get
            {
                return this.putere;
            }
            set
            {
                this.putere = value;
            }
        }
        public String Vechime
        {
            get
            {
                return this.vechime;
            }
            set
            {
                this.vechime = value;
            }
        }

        public int CompareTo(object obj)
        {
            if (obj.GetType() != GetType())
                return -1;
            
            Selectie s = (Selectie)obj;
            return Nume.CompareTo(s.Nume);
                
        }
    }
}

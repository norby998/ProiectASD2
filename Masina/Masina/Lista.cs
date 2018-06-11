using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masina
{

    public class Lista<ElemType> : IEnumerable
    {
        public class Nod
        {
            public ElemType info;
            public Nod urm = null;
            public Nod(ElemType e)
            {
                this.info = e;
            }
        }
        private Nod prim = null, ultim = null;
        private int dimensiune = 0;
        public Lista()
        {
        }
        public int Dimensiune()
        {
            return dimensiune;
        }
        public void Adauga(ElemType e)
        {
            Nod n = new Nod(e);
            if(prim == null)
            {
                prim = n;
                ultim = n;
            }
            else
            {
                ultim.urm = n;
                ultim = n;
            }
            dimensiune++;
        }
        public void Sterge(ElemType e)
        {
            for (Nod p = prim; p != null; p = p.urm)
            {
                if(p.urm.info.Equals(e))
                {
                    p.urm = p.urm.urm;
                    dimensiune--;
                    break;
                }
            }
        }
        public IEnumerator GetEnumerator()
        {
            for (Nod p = prim; p != null; p = p.urm)
            {  
                yield return p.info;
            }
        }
    }
}

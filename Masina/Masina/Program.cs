using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Masina
{
    static class Program
    {
        static private void TestTree()
        {
            /*Tree<int> t = new Tree<int>();
            t.Add(1);
            t.Add(5);
            t.Add(3);
            t.Add(10);
            t.Add(-1);
            string s = "";
            foreach (int it in t)
                s += " " + it.ToString();
            MessageBox.Show(s);*/
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            TestTree();
    
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

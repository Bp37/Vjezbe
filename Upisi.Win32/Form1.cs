using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Upisi.Model;

namespace Upisi.Win32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Polaznik p = new Polaznik();
            p.Ime = "Pero";

            MessageBox.Show("Pozdravlja te " + p.Ime);
        }
    }
}

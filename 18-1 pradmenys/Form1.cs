using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_1_pradmenys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMygtukas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Labas");
        }

        private void buttonGautiReiksme_Click(object sender, EventArgs e)
        {
            var reiksme = textBoxReiksme.Text;
            labelReiksme.Text = reiksme;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var forma = new InformacijosLangas();
            forma.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var reiksme = textBoxSiusti.Text;
            var forma = new SkaiciavimuForma(reiksme);
            forma.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var forma = new IvedimoForma())
            {
                forma.ShowDialog();

                if (forma.DialogResult == DialogResult.OK)
                {
                    var zodis = forma.Zodis;
                    labelIvedimoFormos.Text = zodis;
                }
            }
        }
    }
}

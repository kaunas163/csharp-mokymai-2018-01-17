using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_2_Telefonai
{
    public partial class Skaiciavimai : Form
    {
        public Skaiciavimai(List<Telefonas> telefonai)
        {
            InitializeComponent();
            textBox1.Text = Seniausias(telefonai).Metai.ToString();
        }

        public Telefonas Seniausias(List<Telefonas> telefonai)
        {
            var seniausias = telefonai.First();

            foreach (var tel in telefonai)
            {
                if (tel.Metai < seniausias.Metai)
                {
                    seniausias = tel;
                }
            }

            return seniausias;
        }
    }
}

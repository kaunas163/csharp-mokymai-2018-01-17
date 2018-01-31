using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_2_Telefonai
{
    public partial class Form1 : Form
    {
        public List<Telefonas> Telefonai { get; private set; }

        public Form1()
        {
            InitializeComponent();
            Telefonai = new List<Telefonas>();
        }

        private void baigtiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nuskaitytiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var failoPasirinkoLangas = new OpenFileDialog())
            {
                failoPasirinkoLangas.Filter = "csv failai (*.csv)|*.csv";

                if (failoPasirinkoLangas.ShowDialog() == DialogResult.OK)
                {
                    //MessageBox.Show(failoPasirinkoLangas.FileName);

                    // nuskaitinejimas
                    using (var skaitytuvas = new StreamReader(failoPasirinkoLangas.FileName))
                    {
                        string eilute;
                        var eil = 0;

                        while ((eilute = skaitytuvas.ReadLine()) != null)
                        {
                            //MessageBox.Show(eilute);

                            if (eil == 0)
                            {
                                eil++;
                                continue; // soka i while pradzia
                            }

                            var telefonas = new Telefonas(eilute);
                            Telefonai.Add(telefonas);
                        }

                        dataGridView1.DataSource = Telefonai;
                    }
                }
            }
        }

        private void skaiciavimaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var forma = new Skaiciavimai(Telefonai);
            forma.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_1_pradmenys
{
    public partial class SkaiciavimuForma : Form
    {
        public SkaiciavimuForma()
        {
            InitializeComponent();
        }

        public SkaiciavimuForma(string zodis)
        {
            InitializeComponent();
            label1.Text = zodis;
        }
    }
}

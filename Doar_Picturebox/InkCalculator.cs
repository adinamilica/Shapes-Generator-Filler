using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doar_Picturebox
{
    public partial class InkCalculator : Form
    {
        public InkCalculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Linie l = new Linie(0, 1, 3, 4);

        }
    }
}

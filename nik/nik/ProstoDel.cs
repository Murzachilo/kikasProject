using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nik
{
    public partial class ProstoDel : Form
    {
        public ProstoDel()
        {
            InitializeComponent();
        }

        private void ProstoDel_Load(object sender, EventArgs e)
        {
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu2 dlg = new menu2();
            dlg.Show(this);
        }
    }
}

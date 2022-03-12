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
    public partial class advocats : Form
    {
        public advocats()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advokastkayaKontoraDataSet.Адвокат". При необходимости она может быть перемещена или удалена.
            this.адвокатTableAdapter.Fill(this.advokastkayaKontoraDataSet.Адвокат);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
             menu2 dlg = new menu2();
            dlg.Show(this);
        }
    }
}

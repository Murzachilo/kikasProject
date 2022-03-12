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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advokastkayaKontoraDataSet2.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter1.Fill(this.advokastkayaKontoraDataSet2.Клиент);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advokastkayaKontoraDataSet.Процедуры". При необходимости она может быть перемещена или удалена.
            this.процедурыTableAdapter.Fill(this.advokastkayaKontoraDataSet.Процедуры);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu2 dlg = new menu2();
            dlg.Show(this);
        }
    }
}

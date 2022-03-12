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
    public partial class Archive : Form
    {
        public Archive()
        {
            InitializeComponent();
        }

        private void Archive_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advokastkayaKontoraDataSet2.Дела". При необходимости она может быть перемещена или удалена.
            this.делаTableAdapter.Fill(this.advokastkayaKontoraDataSet2.Дела);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advokastkayaKontoraDataSet.Процедуры". При необходимости она может быть перемещена или удалена.
            this.процедурыTableAdapter.Fill(this.advokastkayaKontoraDataSet.Процедуры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advokastkayaKontoraDataSet.Процедуры". При необходимости она может быть перемещена или удалена.
            this.процедурыTableAdapter.Fill(this.advokastkayaKontoraDataSet.Процедуры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advokastkayaKontoraDataSet1.Дела". При необходимости она может быть перемещена или удалена.
            this.делаTableAdapter1.Fill(this.advokastkayaKontoraDataSet1.Дела);


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu2 dlg = new menu2();
            dlg.Show(this);
        }
    }
}

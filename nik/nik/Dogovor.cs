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
    public partial class Dogovor : Form
    {
        public Dogovor()
        {
            InitializeComponent();
        }

        private void Dogovor_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advokastkayaKontoraDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.advokastkayaKontoraDataSet.Клиент);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advokastkayaKontoraDataSet4.Договор". При необходимости она может быть перемещена или удалена.
            this.договорTableAdapter1.Fill(this.advokastkayaKontoraDataSet4.Договор);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advokastkayaKontoraDataSet.Договор". При необходимости она может быть перемещена или удалена.
            this.договорTableAdapter.Fill(this.advokastkayaKontoraDataSet.Договор);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu2 dlg = new menu2();
            dlg.Show(this);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.договорTableAdapter1.FillBy(this.advokastkayaKontoraDataSet4.Договор);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}

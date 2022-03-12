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
    public partial class menu2 : Form
    {
        public menu2()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            advocats dlg = new advocats();
            dlg.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Archive dlg = new Archive();
            dlg.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProstoDel dlg = new ProstoDel();
            dlg.Show(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 dlg = new Form2();
            dlg.Show(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dogovor dlg = new Dogovor();
            dlg.Show(this);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            zakdog dlg = new zakdog();
            dlg.Show(this);
        }
    }
}

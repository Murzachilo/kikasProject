using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace nik
{
    public partial class Autorization : Form
    {
        SqlConnection conn;

        bool fgood;
        public Autorization()
        {
            InitializeComponent();
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=MYMAGICBULLING\SQLEXPRESS;Initial Catalog=AdvokastkayaKontora;Integrated Security=True";
            fgood = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("логин или пароль пуст", textBox1.Text);
                return;
            }
            else
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                DataTable useresTable = new DataTable();
                SqlCommand comm = new SqlCommand("SELECT * FROM Адвокат WHERE Логин = '" + textBox1.Text + "' AND Пароль = '" + textBox2.Text + "'", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                comm.ExecuteNonQuery();
                adapter.Fill(useresTable);
                if (useresTable.Rows.Count > 0)
                {
                    this.Hide();
                    menu2 dlg = new menu2();
                    dlg.Show(this);
                    fgood = true;


                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
            }
        }
    
    }
}

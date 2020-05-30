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

namespace dashboard
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wald\source\repos\dashboard\dashboard\Database1.mdf;Integrated Security=True;");
            SqlDataAdapter sda = new SqlDataAdapter("select count (*) from user_app where username='" + textBox1.Text + "' and pass = '" + textBox2.Text +"'", cn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Form1 a = new Form1();
                
                this.Hide();

                a.Show();
            }
            else
            {
                MessageBox.Show("Cek Username dan Password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

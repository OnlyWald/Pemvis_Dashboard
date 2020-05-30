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
using System.Data.Sql;

namespace dashboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chart1.Series["c1"].Points.AddXY("OR3", "70");
            chart1.Series["c1"].Points.AddXY("OR3s", "10");
            chart1.Series["c1"].Points.AddXY("GoR", "100");
            chart1.Series["c1"].Points.AddXY("HT", "5");
            chart1.Series["c1"].Points.AddXY("CTS", "1");
        }



        private Form activeForm = null;
        
        private void openChileForm(Form childform)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panel1.Controls.Add(childform);
            panel1.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void but_das_Click(object sender, EventArgs e)
        {
            if (panel1 != null)
                activeForm.Close();
            else
                panel1.Show();
        }

        private void but_mas_Click(object sender, EventArgs e)
        {
            openChileForm(new Form2());
        }

        private void but_kel_Click(object sender, EventArgs e)
        {
            openChileForm(new Form3());
        }

        private void but_kar_Click(object sender, EventArgs e)
        {
            openChileForm(new Form4());
        }

        private void but_user_Click(object sender, EventArgs e)
        {
            openChileForm(new Form5());
        }

        private void openChileFor(Form childform)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panel12.Controls.Add(childform);
            panel12.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChileFor(new Form7());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
            private void button3_Click(object sender, EventArgs e)
        {
            openChileFor(new Form8());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 a = new Form6();
            a.Show();
            this.Close();
        }
    }
}

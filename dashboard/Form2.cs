using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dashboard
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void laporan_masukBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.laporan_masukBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.laporan_masuk' table. You can move, or remove it, as needed.
            this.laporan_masukTableAdapter.Fill(this.database1DataSet.laporan_masuk);

        }

        private void no_lapLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void laporan_keluarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.laporan_keluarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.laporan_keluar' table. You can move, or remove it, as needed.
            this.laporan_keluarTableAdapter.Fill(this.database1DataSet.laporan_keluar);

        }
    }
}

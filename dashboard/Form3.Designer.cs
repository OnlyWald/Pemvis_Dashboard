namespace dashboard
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            System.Windows.Forms.Label no_lapLabel;
            System.Windows.Forms.Label kode_barangLabel;
            System.Windows.Forms.Label nama_barangLabel;
            System.Windows.Forms.Label merk_barangLabel;
            System.Windows.Forms.Label jumlah_barangLabel;
            System.Windows.Forms.Label tgl_keluarLabel;
            System.Windows.Forms.Label keteranganLabel;
            System.Windows.Forms.Label noLabel;
            System.Windows.Forms.Label no_userLabel;
            this.database1DataSet = new dashboard.Database1DataSet();
            this.laporan_keluarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laporan_keluarTableAdapter = new dashboard.Database1DataSetTableAdapters.laporan_keluarTableAdapter();
            this.tableAdapterManager = new dashboard.Database1DataSetTableAdapters.TableAdapterManager();
            this.laporan_keluarBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.laporan_keluarBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.no_lapTextBox = new System.Windows.Forms.TextBox();
            this.kode_barangTextBox = new System.Windows.Forms.TextBox();
            this.nama_barangTextBox = new System.Windows.Forms.TextBox();
            this.merk_barangTextBox = new System.Windows.Forms.TextBox();
            this.jumlah_barangTextBox = new System.Windows.Forms.TextBox();
            this.tgl_keluarDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.keteranganTextBox = new System.Windows.Forms.TextBox();
            this.noTextBox = new System.Windows.Forms.TextBox();
            this.no_userTextBox = new System.Windows.Forms.TextBox();
            this.laporan_keluarDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            no_lapLabel = new System.Windows.Forms.Label();
            kode_barangLabel = new System.Windows.Forms.Label();
            nama_barangLabel = new System.Windows.Forms.Label();
            merk_barangLabel = new System.Windows.Forms.Label();
            jumlah_barangLabel = new System.Windows.Forms.Label();
            tgl_keluarLabel = new System.Windows.Forms.Label();
            keteranganLabel = new System.Windows.Forms.Label();
            noLabel = new System.Windows.Forms.Label();
            no_userLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laporan_keluarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laporan_keluarBindingNavigator)).BeginInit();
            this.laporan_keluarBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laporan_keluarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // laporan_keluarBindingSource
            // 
            this.laporan_keluarBindingSource.DataMember = "laporan_keluar";
            this.laporan_keluarBindingSource.DataSource = this.database1DataSet;
            // 
            // laporan_keluarTableAdapter
            // 
            this.laporan_keluarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.karyawanTableAdapter = null;
            this.tableAdapterManager.laporan_keluarTableAdapter = this.laporan_keluarTableAdapter;
            this.tableAdapterManager.laporan_masukTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = dashboard.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.user_appTableAdapter = null;
            // 
            // laporan_keluarBindingNavigator
            // 
            this.laporan_keluarBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.laporan_keluarBindingNavigator.BindingSource = this.laporan_keluarBindingSource;
            this.laporan_keluarBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.laporan_keluarBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.laporan_keluarBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.laporan_keluarBindingNavigatorSaveItem});
            this.laporan_keluarBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.laporan_keluarBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.laporan_keluarBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.laporan_keluarBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.laporan_keluarBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.laporan_keluarBindingNavigator.Name = "laporan_keluarBindingNavigator";
            this.laporan_keluarBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.laporan_keluarBindingNavigator.Size = new System.Drawing.Size(650, 25);
            this.laporan_keluarBindingNavigator.TabIndex = 0;
            this.laporan_keluarBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(58, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // laporan_keluarBindingNavigatorSaveItem
            // 
            this.laporan_keluarBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.laporan_keluarBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("laporan_keluarBindingNavigatorSaveItem.Image")));
            this.laporan_keluarBindingNavigatorSaveItem.Name = "laporan_keluarBindingNavigatorSaveItem";
            this.laporan_keluarBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.laporan_keluarBindingNavigatorSaveItem.Text = "Save Data";
            this.laporan_keluarBindingNavigatorSaveItem.Click += new System.EventHandler(this.laporan_keluarBindingNavigatorSaveItem_Click);
            // 
            // no_lapLabel
            // 
            no_lapLabel.AutoSize = true;
            no_lapLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            no_lapLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            no_lapLabel.Location = new System.Drawing.Point(8, 31);
            no_lapLabel.Name = "no_lapLabel";
            no_lapLabel.Size = new System.Drawing.Size(40, 12);
            no_lapLabel.TabIndex = 1;
            no_lapLabel.Text = "Nomor";
            // 
            // no_lapTextBox
            // 
            this.no_lapTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laporan_keluarBindingSource, "no_lap", true));
            this.no_lapTextBox.Location = new System.Drawing.Point(104, 29);
            this.no_lapTextBox.Name = "no_lapTextBox";
            this.no_lapTextBox.Size = new System.Drawing.Size(183, 20);
            this.no_lapTextBox.TabIndex = 2;
            // 
            // kode_barangLabel
            // 
            kode_barangLabel.AutoSize = true;
            kode_barangLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            kode_barangLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            kode_barangLabel.Location = new System.Drawing.Point(8, 55);
            kode_barangLabel.Name = "kode_barangLabel";
            kode_barangLabel.Size = new System.Drawing.Size(82, 12);
            kode_barangLabel.TabIndex = 3;
            kode_barangLabel.Text = "Kode Barang";
            // 
            // kode_barangTextBox
            // 
            this.kode_barangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laporan_keluarBindingSource, "kode_barang", true));
            this.kode_barangTextBox.Location = new System.Drawing.Point(104, 53);
            this.kode_barangTextBox.Name = "kode_barangTextBox";
            this.kode_barangTextBox.Size = new System.Drawing.Size(183, 20);
            this.kode_barangTextBox.TabIndex = 4;
            // 
            // nama_barangLabel
            // 
            nama_barangLabel.AutoSize = true;
            nama_barangLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nama_barangLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            nama_barangLabel.Location = new System.Drawing.Point(8, 79);
            nama_barangLabel.Name = "nama_barangLabel";
            nama_barangLabel.Size = new System.Drawing.Size(82, 12);
            nama_barangLabel.TabIndex = 5;
            nama_barangLabel.Text = "Nama Barang";
            // 
            // nama_barangTextBox
            // 
            this.nama_barangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laporan_keluarBindingSource, "nama_barang", true));
            this.nama_barangTextBox.Location = new System.Drawing.Point(104, 77);
            this.nama_barangTextBox.Name = "nama_barangTextBox";
            this.nama_barangTextBox.Size = new System.Drawing.Size(183, 20);
            this.nama_barangTextBox.TabIndex = 6;
            // 
            // merk_barangLabel
            // 
            merk_barangLabel.AutoSize = true;
            merk_barangLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            merk_barangLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            merk_barangLabel.Location = new System.Drawing.Point(8, 103);
            merk_barangLabel.Name = "merk_barangLabel";
            merk_barangLabel.Size = new System.Drawing.Size(82, 12);
            merk_barangLabel.TabIndex = 7;
            merk_barangLabel.Text = "Merk Barang";
            // 
            // merk_barangTextBox
            // 
            this.merk_barangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laporan_keluarBindingSource, "merk_barang", true));
            this.merk_barangTextBox.Location = new System.Drawing.Point(104, 101);
            this.merk_barangTextBox.Name = "merk_barangTextBox";
            this.merk_barangTextBox.Size = new System.Drawing.Size(183, 20);
            this.merk_barangTextBox.TabIndex = 8;
            // 
            // jumlah_barangLabel
            // 
            jumlah_barangLabel.AutoSize = true;
            jumlah_barangLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            jumlah_barangLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            jumlah_barangLabel.Location = new System.Drawing.Point(8, 127);
            jumlah_barangLabel.Name = "jumlah_barangLabel";
            jumlah_barangLabel.Size = new System.Drawing.Size(96, 12);
            jumlah_barangLabel.TabIndex = 9;
            jumlah_barangLabel.Text = "Jumlah Barang";
            // 
            // jumlah_barangTextBox
            // 
            this.jumlah_barangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laporan_keluarBindingSource, "jumlah_barang", true));
            this.jumlah_barangTextBox.Location = new System.Drawing.Point(104, 125);
            this.jumlah_barangTextBox.Name = "jumlah_barangTextBox";
            this.jumlah_barangTextBox.Size = new System.Drawing.Size(183, 20);
            this.jumlah_barangTextBox.TabIndex = 10;
            // 
            // tgl_keluarLabel
            // 
            tgl_keluarLabel.AutoSize = true;
            tgl_keluarLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tgl_keluarLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            tgl_keluarLabel.Location = new System.Drawing.Point(8, 152);
            tgl_keluarLabel.Name = "tgl_keluarLabel";
            tgl_keluarLabel.Size = new System.Drawing.Size(54, 12);
            tgl_keluarLabel.TabIndex = 11;
            tgl_keluarLabel.Text = "Tanggal";
            // 
            // tgl_keluarDateTimePicker
            // 
            this.tgl_keluarDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.laporan_keluarBindingSource, "tgl_keluar", true));
            this.tgl_keluarDateTimePicker.Location = new System.Drawing.Point(104, 149);
            this.tgl_keluarDateTimePicker.Name = "tgl_keluarDateTimePicker";
            this.tgl_keluarDateTimePicker.Size = new System.Drawing.Size(183, 20);
            this.tgl_keluarDateTimePicker.TabIndex = 12;
            // 
            // keteranganLabel
            // 
            keteranganLabel.AutoSize = true;
            keteranganLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            keteranganLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            keteranganLabel.Location = new System.Drawing.Point(346, 82);
            keteranganLabel.Name = "keteranganLabel";
            keteranganLabel.Size = new System.Drawing.Size(75, 12);
            keteranganLabel.TabIndex = 13;
            keteranganLabel.Text = "Keterangan";
            // 
            // keteranganTextBox
            // 
            this.keteranganTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laporan_keluarBindingSource, "keterangan", true));
            this.keteranganTextBox.Location = new System.Drawing.Point(442, 79);
            this.keteranganTextBox.Multiline = true;
            this.keteranganTextBox.Name = "keteranganTextBox";
            this.keteranganTextBox.Size = new System.Drawing.Size(196, 90);
            this.keteranganTextBox.TabIndex = 14;
            // 
            // noLabel
            // 
            noLabel.AutoSize = true;
            noLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            noLabel.Location = new System.Drawing.Point(346, 32);
            noLabel.Name = "noLabel";
            noLabel.Size = new System.Drawing.Size(61, 12);
            noLabel.TabIndex = 15;
            noLabel.Text = "Pengirim";
            // 
            // noTextBox
            // 
            this.noTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laporan_keluarBindingSource, "no", true));
            this.noTextBox.Location = new System.Drawing.Point(442, 29);
            this.noTextBox.Name = "noTextBox";
            this.noTextBox.Size = new System.Drawing.Size(196, 20);
            this.noTextBox.TabIndex = 16;
            // 
            // no_userLabel
            // 
            no_userLabel.AutoSize = true;
            no_userLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            no_userLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            no_userLabel.Location = new System.Drawing.Point(346, 56);
            no_userLabel.Name = "no_userLabel";
            no_userLabel.Size = new System.Drawing.Size(40, 12);
            no_userLabel.TabIndex = 17;
            no_userLabel.Text = "Admin";
            // 
            // no_userTextBox
            // 
            this.no_userTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laporan_keluarBindingSource, "no_user", true));
            this.no_userTextBox.Location = new System.Drawing.Point(442, 53);
            this.no_userTextBox.Name = "no_userTextBox";
            this.no_userTextBox.Size = new System.Drawing.Size(196, 20);
            this.no_userTextBox.TabIndex = 18;
            // 
            // laporan_keluarDataGridView
            // 
            this.laporan_keluarDataGridView.AutoGenerateColumns = false;
            this.laporan_keluarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.laporan_keluarDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.laporan_keluarDataGridView.DataSource = this.laporan_keluarBindingSource;
            this.laporan_keluarDataGridView.Location = new System.Drawing.Point(10, 175);
            this.laporan_keluarDataGridView.Name = "laporan_keluarDataGridView";
            this.laporan_keluarDataGridView.Size = new System.Drawing.Size(628, 278);
            this.laporan_keluarDataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "no_lap";
            this.dataGridViewTextBoxColumn1.HeaderText = "no_lap";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "kode_barang";
            this.dataGridViewTextBoxColumn2.HeaderText = "kode_barang";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nama_barang";
            this.dataGridViewTextBoxColumn3.HeaderText = "nama_barang";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "merk_barang";
            this.dataGridViewTextBoxColumn4.HeaderText = "merk_barang";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "jumlah_barang";
            this.dataGridViewTextBoxColumn5.HeaderText = "jumlah_barang";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "tgl_keluar";
            this.dataGridViewTextBoxColumn6.HeaderText = "tgl_keluar";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "keterangan";
            this.dataGridViewTextBoxColumn7.HeaderText = "keterangan";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "no";
            this.dataGridViewTextBoxColumn8.HeaderText = "no";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "no_user";
            this.dataGridViewTextBoxColumn9.HeaderText = "no_user";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(650, 465);
            this.Controls.Add(this.laporan_keluarDataGridView);
            this.Controls.Add(no_lapLabel);
            this.Controls.Add(this.no_lapTextBox);
            this.Controls.Add(kode_barangLabel);
            this.Controls.Add(this.kode_barangTextBox);
            this.Controls.Add(nama_barangLabel);
            this.Controls.Add(this.nama_barangTextBox);
            this.Controls.Add(merk_barangLabel);
            this.Controls.Add(this.merk_barangTextBox);
            this.Controls.Add(jumlah_barangLabel);
            this.Controls.Add(this.jumlah_barangTextBox);
            this.Controls.Add(tgl_keluarLabel);
            this.Controls.Add(this.tgl_keluarDateTimePicker);
            this.Controls.Add(keteranganLabel);
            this.Controls.Add(this.keteranganTextBox);
            this.Controls.Add(noLabel);
            this.Controls.Add(this.noTextBox);
            this.Controls.Add(no_userLabel);
            this.Controls.Add(this.no_userTextBox);
            this.Controls.Add(this.laporan_keluarBindingNavigator);
            this.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laporan_keluarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laporan_keluarBindingNavigator)).EndInit();
            this.laporan_keluarBindingNavigator.ResumeLayout(false);
            this.laporan_keluarBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laporan_keluarDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource laporan_keluarBindingSource;
        private Database1DataSetTableAdapters.laporan_keluarTableAdapter laporan_keluarTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator laporan_keluarBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton laporan_keluarBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox no_lapTextBox;
        private System.Windows.Forms.TextBox kode_barangTextBox;
        private System.Windows.Forms.TextBox nama_barangTextBox;
        private System.Windows.Forms.TextBox merk_barangTextBox;
        private System.Windows.Forms.TextBox jumlah_barangTextBox;
        private System.Windows.Forms.DateTimePicker tgl_keluarDateTimePicker;
        private System.Windows.Forms.TextBox keteranganTextBox;
        private System.Windows.Forms.TextBox noTextBox;
        private System.Windows.Forms.TextBox no_userTextBox;
        private System.Windows.Forms.DataGridView laporan_keluarDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}
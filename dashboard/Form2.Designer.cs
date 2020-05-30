namespace dashboard
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.Label no_lapLabel;
            System.Windows.Forms.Label kode_baranngLabel;
            System.Windows.Forms.Label nama_barangLabel;
            System.Windows.Forms.Label merk_barangLabel;
            System.Windows.Forms.Label jumlah_barangLabel;
            System.Windows.Forms.Label tgl_datangLabel;
            System.Windows.Forms.Label keteranganLabel;
            System.Windows.Forms.Label no_karLabel;
            System.Windows.Forms.Label id_userLabel;
            this.database1DataSet = new dashboard.Database1DataSet();
            this.laporan_masukBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laporan_masukTableAdapter = new dashboard.Database1DataSetTableAdapters.laporan_masukTableAdapter();
            this.tableAdapterManager = new dashboard.Database1DataSetTableAdapters.TableAdapterManager();
            this.laporan_masukBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.laporan_masukBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.no_lapTextBox = new System.Windows.Forms.TextBox();
            this.kode_baranngTextBox = new System.Windows.Forms.TextBox();
            this.nama_barangTextBox = new System.Windows.Forms.TextBox();
            this.merk_barangTextBox = new System.Windows.Forms.TextBox();
            this.jumlah_barangTextBox = new System.Windows.Forms.TextBox();
            this.tgl_datangDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.keteranganTextBox = new System.Windows.Forms.TextBox();
            this.no_karTextBox = new System.Windows.Forms.TextBox();
            this.id_userTextBox = new System.Windows.Forms.TextBox();
            this.laporan_masukDataGridView = new System.Windows.Forms.DataGridView();
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
            kode_baranngLabel = new System.Windows.Forms.Label();
            nama_barangLabel = new System.Windows.Forms.Label();
            merk_barangLabel = new System.Windows.Forms.Label();
            jumlah_barangLabel = new System.Windows.Forms.Label();
            tgl_datangLabel = new System.Windows.Forms.Label();
            keteranganLabel = new System.Windows.Forms.Label();
            no_karLabel = new System.Windows.Forms.Label();
            id_userLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laporan_masukBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laporan_masukBindingNavigator)).BeginInit();
            this.laporan_masukBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laporan_masukDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // laporan_masukBindingSource
            // 
            this.laporan_masukBindingSource.DataMember = "laporan_masuk";
            this.laporan_masukBindingSource.DataSource = this.database1DataSet;
            // 
            // laporan_masukTableAdapter
            // 
            this.laporan_masukTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.karyawanTableAdapter = null;
            this.tableAdapterManager.laporan_keluarTableAdapter = null;
            this.tableAdapterManager.laporan_masukTableAdapter = this.laporan_masukTableAdapter;
            this.tableAdapterManager.UpdateOrder = dashboard.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.user_appTableAdapter = null;
            // 
            // laporan_masukBindingNavigator
            // 
            this.laporan_masukBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.laporan_masukBindingNavigator.BindingSource = this.laporan_masukBindingSource;
            this.laporan_masukBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.laporan_masukBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.laporan_masukBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.laporan_masukBindingNavigatorSaveItem});
            this.laporan_masukBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.laporan_masukBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.laporan_masukBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.laporan_masukBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.laporan_masukBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.laporan_masukBindingNavigator.Name = "laporan_masukBindingNavigator";
            this.laporan_masukBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.laporan_masukBindingNavigator.Size = new System.Drawing.Size(650, 25);
            this.laporan_masukBindingNavigator.TabIndex = 0;
            this.laporan_masukBindingNavigator.Text = "bindingNavigator1";
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
            // laporan_masukBindingNavigatorSaveItem
            // 
            this.laporan_masukBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.laporan_masukBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("laporan_masukBindingNavigatorSaveItem.Image")));
            this.laporan_masukBindingNavigatorSaveItem.Name = "laporan_masukBindingNavigatorSaveItem";
            this.laporan_masukBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.laporan_masukBindingNavigatorSaveItem.Text = "Save Data";
            this.laporan_masukBindingNavigatorSaveItem.Click += new System.EventHandler(this.laporan_masukBindingNavigatorSaveItem_Click);
            // 
            // no_lapLabel
            // 
            no_lapLabel.AutoSize = true;
            no_lapLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            no_lapLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            no_lapLabel.Location = new System.Drawing.Point(14, 39);
            no_lapLabel.Name = "no_lapLabel";
            no_lapLabel.Size = new System.Drawing.Size(40, 12);
            no_lapLabel.TabIndex = 1;
            no_lapLabel.Text = "Nomor";
            no_lapLabel.Click += new System.EventHandler(this.no_lapLabel_Click);
            // 
            // no_lapTextBox
            // 
            this.no_lapTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laporan_masukBindingSource, "no_lap", true));
            this.no_lapTextBox.Location = new System.Drawing.Point(135, 36);
            this.no_lapTextBox.Name = "no_lapTextBox";
            this.no_lapTextBox.Size = new System.Drawing.Size(197, 20);
            this.no_lapTextBox.TabIndex = 2;
            // 
            // kode_baranngLabel
            // 
            kode_baranngLabel.AutoSize = true;
            kode_baranngLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            kode_baranngLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            kode_baranngLabel.Location = new System.Drawing.Point(14, 63);
            kode_baranngLabel.Name = "kode_baranngLabel";
            kode_baranngLabel.Size = new System.Drawing.Size(82, 12);
            kode_baranngLabel.TabIndex = 3;
            kode_baranngLabel.Text = "Kode Barang";
            // 
            // kode_baranngTextBox
            // 
            this.kode_baranngTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laporan_masukBindingSource, "kode_baranng", true));
            this.kode_baranngTextBox.Location = new System.Drawing.Point(135, 60);
            this.kode_baranngTextBox.Name = "kode_baranngTextBox";
            this.kode_baranngTextBox.Size = new System.Drawing.Size(197, 20);
            this.kode_baranngTextBox.TabIndex = 4;
            // 
            // nama_barangLabel
            // 
            nama_barangLabel.AutoSize = true;
            nama_barangLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nama_barangLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            nama_barangLabel.Location = new System.Drawing.Point(14, 87);
            nama_barangLabel.Name = "nama_barangLabel";
            nama_barangLabel.Size = new System.Drawing.Size(82, 12);
            nama_barangLabel.TabIndex = 5;
            nama_barangLabel.Text = "Nama Barang";
            // 
            // nama_barangTextBox
            // 
            this.nama_barangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laporan_masukBindingSource, "nama_barang", true));
            this.nama_barangTextBox.Location = new System.Drawing.Point(135, 84);
            this.nama_barangTextBox.Name = "nama_barangTextBox";
            this.nama_barangTextBox.Size = new System.Drawing.Size(197, 20);
            this.nama_barangTextBox.TabIndex = 6;
            // 
            // merk_barangLabel
            // 
            merk_barangLabel.AutoSize = true;
            merk_barangLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            merk_barangLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            merk_barangLabel.Location = new System.Drawing.Point(14, 111);
            merk_barangLabel.Name = "merk_barangLabel";
            merk_barangLabel.Size = new System.Drawing.Size(82, 12);
            merk_barangLabel.TabIndex = 7;
            merk_barangLabel.Text = "Merk Barang";
            // 
            // merk_barangTextBox
            // 
            this.merk_barangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laporan_masukBindingSource, "merk_barang", true));
            this.merk_barangTextBox.Location = new System.Drawing.Point(135, 108);
            this.merk_barangTextBox.Name = "merk_barangTextBox";
            this.merk_barangTextBox.Size = new System.Drawing.Size(197, 20);
            this.merk_barangTextBox.TabIndex = 8;
            // 
            // jumlah_barangLabel
            // 
            jumlah_barangLabel.AutoSize = true;
            jumlah_barangLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            jumlah_barangLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            jumlah_barangLabel.Location = new System.Drawing.Point(14, 135);
            jumlah_barangLabel.Name = "jumlah_barangLabel";
            jumlah_barangLabel.Size = new System.Drawing.Size(96, 12);
            jumlah_barangLabel.TabIndex = 9;
            jumlah_barangLabel.Text = "Jumlah Barang";
            // 
            // jumlah_barangTextBox
            // 
            this.jumlah_barangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laporan_masukBindingSource, "jumlah_barang", true));
            this.jumlah_barangTextBox.Location = new System.Drawing.Point(135, 132);
            this.jumlah_barangTextBox.Name = "jumlah_barangTextBox";
            this.jumlah_barangTextBox.Size = new System.Drawing.Size(197, 20);
            this.jumlah_barangTextBox.TabIndex = 10;
            // 
            // tgl_datangLabel
            // 
            tgl_datangLabel.AutoSize = true;
            tgl_datangLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tgl_datangLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            tgl_datangLabel.Location = new System.Drawing.Point(14, 160);
            tgl_datangLabel.Name = "tgl_datangLabel";
            tgl_datangLabel.Size = new System.Drawing.Size(75, 12);
            tgl_datangLabel.TabIndex = 11;
            tgl_datangLabel.Text = "Kedatangan";
            // 
            // tgl_datangDateTimePicker
            // 
            this.tgl_datangDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.laporan_masukBindingSource, "tgl_datang", true));
            this.tgl_datangDateTimePicker.Location = new System.Drawing.Point(135, 156);
            this.tgl_datangDateTimePicker.Name = "tgl_datangDateTimePicker";
            this.tgl_datangDateTimePicker.Size = new System.Drawing.Size(197, 20);
            this.tgl_datangDateTimePicker.TabIndex = 12;
            // 
            // keteranganLabel
            // 
            keteranganLabel.AutoSize = true;
            keteranganLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            keteranganLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            keteranganLabel.Location = new System.Drawing.Point(356, 90);
            keteranganLabel.Name = "keteranganLabel";
            keteranganLabel.Size = new System.Drawing.Size(75, 12);
            keteranganLabel.TabIndex = 13;
            keteranganLabel.Text = "Keterangan";
            // 
            // keteranganTextBox
            // 
            this.keteranganTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laporan_masukBindingSource, "keterangan", true));
            this.keteranganTextBox.Location = new System.Drawing.Point(452, 87);
            this.keteranganTextBox.Multiline = true;
            this.keteranganTextBox.Name = "keteranganTextBox";
            this.keteranganTextBox.Size = new System.Drawing.Size(186, 92);
            this.keteranganTextBox.TabIndex = 14;
            // 
            // no_karLabel
            // 
            no_karLabel.AutoSize = true;
            no_karLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            no_karLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            no_karLabel.Location = new System.Drawing.Point(356, 42);
            no_karLabel.Name = "no_karLabel";
            no_karLabel.Size = new System.Drawing.Size(61, 12);
            no_karLabel.TabIndex = 15;
            no_karLabel.Text = "Penerima";
            // 
            // no_karTextBox
            // 
            this.no_karTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laporan_masukBindingSource, "no_kar", true));
            this.no_karTextBox.Location = new System.Drawing.Point(452, 39);
            this.no_karTextBox.Name = "no_karTextBox";
            this.no_karTextBox.Size = new System.Drawing.Size(186, 20);
            this.no_karTextBox.TabIndex = 16;
            // 
            // id_userLabel
            // 
            id_userLabel.AutoSize = true;
            id_userLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_userLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            id_userLabel.Location = new System.Drawing.Point(356, 66);
            id_userLabel.Name = "id_userLabel";
            id_userLabel.Size = new System.Drawing.Size(54, 12);
            id_userLabel.TabIndex = 17;
            id_userLabel.Text = "ID User";
            // 
            // id_userTextBox
            // 
            this.id_userTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laporan_masukBindingSource, "id_user", true));
            this.id_userTextBox.Location = new System.Drawing.Point(452, 63);
            this.id_userTextBox.Name = "id_userTextBox";
            this.id_userTextBox.Size = new System.Drawing.Size(186, 20);
            this.id_userTextBox.TabIndex = 18;
            // 
            // laporan_masukDataGridView
            // 
            this.laporan_masukDataGridView.AutoGenerateColumns = false;
            this.laporan_masukDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.laporan_masukDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.laporan_masukDataGridView.DataSource = this.laporan_masukBindingSource;
            this.laporan_masukDataGridView.Location = new System.Drawing.Point(16, 182);
            this.laporan_masukDataGridView.Name = "laporan_masukDataGridView";
            this.laporan_masukDataGridView.Size = new System.Drawing.Size(622, 224);
            this.laporan_masukDataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "no_lap";
            this.dataGridViewTextBoxColumn1.HeaderText = "no_lap";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "kode_baranng";
            this.dataGridViewTextBoxColumn2.HeaderText = "kode_baranng";
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
            this.dataGridViewTextBoxColumn6.DataPropertyName = "tgl_datang";
            this.dataGridViewTextBoxColumn6.HeaderText = "tgl_datang";
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
            this.dataGridViewTextBoxColumn8.DataPropertyName = "no_kar";
            this.dataGridViewTextBoxColumn8.HeaderText = "no_kar";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "id_user";
            this.dataGridViewTextBoxColumn9.HeaderText = "id_user";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(650, 465);
            this.Controls.Add(this.laporan_masukDataGridView);
            this.Controls.Add(no_lapLabel);
            this.Controls.Add(this.no_lapTextBox);
            this.Controls.Add(kode_baranngLabel);
            this.Controls.Add(this.kode_baranngTextBox);
            this.Controls.Add(nama_barangLabel);
            this.Controls.Add(this.nama_barangTextBox);
            this.Controls.Add(merk_barangLabel);
            this.Controls.Add(this.merk_barangTextBox);
            this.Controls.Add(jumlah_barangLabel);
            this.Controls.Add(this.jumlah_barangTextBox);
            this.Controls.Add(tgl_datangLabel);
            this.Controls.Add(this.tgl_datangDateTimePicker);
            this.Controls.Add(keteranganLabel);
            this.Controls.Add(this.keteranganTextBox);
            this.Controls.Add(no_karLabel);
            this.Controls.Add(this.no_karTextBox);
            this.Controls.Add(id_userLabel);
            this.Controls.Add(this.id_userTextBox);
            this.Controls.Add(this.laporan_masukBindingNavigator);
            this.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laporan_masukBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laporan_masukBindingNavigator)).EndInit();
            this.laporan_masukBindingNavigator.ResumeLayout(false);
            this.laporan_masukBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laporan_masukDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource laporan_masukBindingSource;
        private Database1DataSetTableAdapters.laporan_masukTableAdapter laporan_masukTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator laporan_masukBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton laporan_masukBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox no_lapTextBox;
        private System.Windows.Forms.TextBox kode_baranngTextBox;
        private System.Windows.Forms.TextBox nama_barangTextBox;
        private System.Windows.Forms.TextBox merk_barangTextBox;
        private System.Windows.Forms.TextBox jumlah_barangTextBox;
        private System.Windows.Forms.DateTimePicker tgl_datangDateTimePicker;
        private System.Windows.Forms.TextBox keteranganTextBox;
        private System.Windows.Forms.TextBox no_karTextBox;
        private System.Windows.Forms.TextBox id_userTextBox;
        private System.Windows.Forms.DataGridView laporan_masukDataGridView;
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
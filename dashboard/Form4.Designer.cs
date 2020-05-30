namespace dashboard
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            System.Windows.Forms.Label nipLabel;
            System.Windows.Forms.Label namaLabel;
            System.Windows.Forms.Label tgl_lahirLabel;
            System.Windows.Forms.Label no_tlpLabel;
            System.Windows.Forms.Label alamatLabel;
            this.database1DataSet = new dashboard.Database1DataSet();
            this.karyawanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.karyawanTableAdapter = new dashboard.Database1DataSetTableAdapters.karyawanTableAdapter();
            this.tableAdapterManager = new dashboard.Database1DataSetTableAdapters.TableAdapterManager();
            this.karyawanBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.karyawanBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nipTextBox = new System.Windows.Forms.TextBox();
            this.namaTextBox = new System.Windows.Forms.TextBox();
            this.tgl_lahirDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.no_tlpTextBox = new System.Windows.Forms.TextBox();
            this.alamatTextBox = new System.Windows.Forms.TextBox();
            this.karyawanDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nipLabel = new System.Windows.Forms.Label();
            namaLabel = new System.Windows.Forms.Label();
            tgl_lahirLabel = new System.Windows.Forms.Label();
            no_tlpLabel = new System.Windows.Forms.Label();
            alamatLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanBindingNavigator)).BeginInit();
            this.karyawanBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // karyawanBindingSource
            // 
            this.karyawanBindingSource.DataMember = "karyawan";
            this.karyawanBindingSource.DataSource = this.database1DataSet;
            // 
            // karyawanTableAdapter
            // 
            this.karyawanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.karyawanTableAdapter = this.karyawanTableAdapter;
            this.tableAdapterManager.laporan_keluarTableAdapter = null;
            this.tableAdapterManager.laporan_masukTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = dashboard.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.user_appTableAdapter = null;
            // 
            // karyawanBindingNavigator
            // 
            this.karyawanBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.karyawanBindingNavigator.BindingSource = this.karyawanBindingSource;
            this.karyawanBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.karyawanBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.karyawanBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.karyawanBindingNavigatorSaveItem});
            this.karyawanBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.karyawanBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.karyawanBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.karyawanBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.karyawanBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.karyawanBindingNavigator.Name = "karyawanBindingNavigator";
            this.karyawanBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.karyawanBindingNavigator.Size = new System.Drawing.Size(650, 25);
            this.karyawanBindingNavigator.TabIndex = 0;
            this.karyawanBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
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
            // karyawanBindingNavigatorSaveItem
            // 
            this.karyawanBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.karyawanBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("karyawanBindingNavigatorSaveItem.Image")));
            this.karyawanBindingNavigatorSaveItem.Name = "karyawanBindingNavigatorSaveItem";
            this.karyawanBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.karyawanBindingNavigatorSaveItem.Text = "Save Data";
            this.karyawanBindingNavigatorSaveItem.Click += new System.EventHandler(this.karyawanBindingNavigatorSaveItem_Click);
            // 
            // nipLabel
            // 
            nipLabel.AutoSize = true;
            nipLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nipLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            nipLabel.Location = new System.Drawing.Point(31, 40);
            nipLabel.Name = "nipLabel";
            nipLabel.Size = new System.Drawing.Size(26, 12);
            nipLabel.TabIndex = 1;
            nipLabel.Text = "NIP";
            // 
            // nipTextBox
            // 
            this.nipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.karyawanBindingSource, "nip", true));
            this.nipTextBox.Location = new System.Drawing.Point(130, 37);
            this.nipTextBox.Name = "nipTextBox";
            this.nipTextBox.Size = new System.Drawing.Size(200, 20);
            this.nipTextBox.TabIndex = 2;
            // 
            // namaLabel
            // 
            namaLabel.AutoSize = true;
            namaLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            namaLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            namaLabel.Location = new System.Drawing.Point(31, 66);
            namaLabel.Name = "namaLabel";
            namaLabel.Size = new System.Drawing.Size(33, 12);
            namaLabel.TabIndex = 3;
            namaLabel.Text = "Nama";
            // 
            // namaTextBox
            // 
            this.namaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.karyawanBindingSource, "nama", true));
            this.namaTextBox.Location = new System.Drawing.Point(130, 63);
            this.namaTextBox.Name = "namaTextBox";
            this.namaTextBox.Size = new System.Drawing.Size(200, 20);
            this.namaTextBox.TabIndex = 4;
            // 
            // tgl_lahirLabel
            // 
            tgl_lahirLabel.AutoSize = true;
            tgl_lahirLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tgl_lahirLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            tgl_lahirLabel.Location = new System.Drawing.Point(31, 93);
            tgl_lahirLabel.Name = "tgl_lahirLabel";
            tgl_lahirLabel.Size = new System.Drawing.Size(96, 12);
            tgl_lahirLabel.TabIndex = 5;
            tgl_lahirLabel.Text = "Tanggal Lahir";
            // 
            // tgl_lahirDateTimePicker
            // 
            this.tgl_lahirDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.karyawanBindingSource, "tgl_lahir", true));
            this.tgl_lahirDateTimePicker.Location = new System.Drawing.Point(130, 89);
            this.tgl_lahirDateTimePicker.Name = "tgl_lahirDateTimePicker";
            this.tgl_lahirDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.tgl_lahirDateTimePicker.TabIndex = 6;
            // 
            // no_tlpLabel
            // 
            no_tlpLabel.AutoSize = true;
            no_tlpLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            no_tlpLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            no_tlpLabel.Location = new System.Drawing.Point(359, 40);
            no_tlpLabel.Name = "no_tlpLabel";
            no_tlpLabel.Size = new System.Drawing.Size(61, 12);
            no_tlpLabel.TabIndex = 7;
            no_tlpLabel.Text = "Nomor HP";
            // 
            // no_tlpTextBox
            // 
            this.no_tlpTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.karyawanBindingSource, "no_tlp", true));
            this.no_tlpTextBox.Location = new System.Drawing.Point(426, 37);
            this.no_tlpTextBox.Name = "no_tlpTextBox";
            this.no_tlpTextBox.Size = new System.Drawing.Size(200, 20);
            this.no_tlpTextBox.TabIndex = 8;
            // 
            // alamatLabel
            // 
            alamatLabel.AutoSize = true;
            alamatLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            alamatLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            alamatLabel.Location = new System.Drawing.Point(359, 66);
            alamatLabel.Name = "alamatLabel";
            alamatLabel.Size = new System.Drawing.Size(47, 12);
            alamatLabel.TabIndex = 9;
            alamatLabel.Text = "Alamat";
            // 
            // alamatTextBox
            // 
            this.alamatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.karyawanBindingSource, "alamat", true));
            this.alamatTextBox.Location = new System.Drawing.Point(426, 63);
            this.alamatTextBox.Multiline = true;
            this.alamatTextBox.Name = "alamatTextBox";
            this.alamatTextBox.Size = new System.Drawing.Size(200, 46);
            this.alamatTextBox.TabIndex = 10;
            // 
            // karyawanDataGridView
            // 
            this.karyawanDataGridView.AutoGenerateColumns = false;
            this.karyawanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.karyawanDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.karyawanDataGridView.DataSource = this.karyawanBindingSource;
            this.karyawanDataGridView.Location = new System.Drawing.Point(55, 129);
            this.karyawanDataGridView.Name = "karyawanDataGridView";
            this.karyawanDataGridView.Size = new System.Drawing.Size(544, 313);
            this.karyawanDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nip";
            this.dataGridViewTextBoxColumn1.HeaderText = "nip";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nama";
            this.dataGridViewTextBoxColumn2.HeaderText = "nama";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tgl_lahir";
            this.dataGridViewTextBoxColumn3.HeaderText = "tgl_lahir";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "no_tlp";
            this.dataGridViewTextBoxColumn4.HeaderText = "no_tlp";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "alamat";
            this.dataGridViewTextBoxColumn5.HeaderText = "alamat";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(650, 465);
            this.Controls.Add(this.karyawanDataGridView);
            this.Controls.Add(nipLabel);
            this.Controls.Add(this.nipTextBox);
            this.Controls.Add(namaLabel);
            this.Controls.Add(this.namaTextBox);
            this.Controls.Add(tgl_lahirLabel);
            this.Controls.Add(this.tgl_lahirDateTimePicker);
            this.Controls.Add(no_tlpLabel);
            this.Controls.Add(this.no_tlpTextBox);
            this.Controls.Add(alamatLabel);
            this.Controls.Add(this.alamatTextBox);
            this.Controls.Add(this.karyawanBindingNavigator);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanBindingNavigator)).EndInit();
            this.karyawanBindingNavigator.ResumeLayout(false);
            this.karyawanBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource karyawanBindingSource;
        private Database1DataSetTableAdapters.karyawanTableAdapter karyawanTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator karyawanBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton karyawanBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nipTextBox;
        private System.Windows.Forms.TextBox namaTextBox;
        private System.Windows.Forms.DateTimePicker tgl_lahirDateTimePicker;
        private System.Windows.Forms.TextBox no_tlpTextBox;
        private System.Windows.Forms.TextBox alamatTextBox;
        private System.Windows.Forms.DataGridView karyawanDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}
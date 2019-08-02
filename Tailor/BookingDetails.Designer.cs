namespace Tailor
{
    partial class BookingDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Customer_Combo2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tMSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tMSystemDataSet = new Tailor.TMSystemDataSet();
            this.bookingTableAdapter = new Tailor.TMSystemDataSetTableAdapters.BookingTableAdapter();
            this.tMSystemDataSet1 = new Tailor.TMSystemDataSet1();
            this.tMSystemDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookingTableAdapter1 = new Tailor.TMSystemDataSet1TableAdapters.BookingTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tMSystem = new Tailor.TMSystem();
            this.bookingTableAdapter2 = new Tailor.TMSystemTableAdapters.BookingTableAdapter();
            this.tableAdapterManager = new Tailor.TMSystemTableAdapters.TableAdapterManager();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new Tailor.TMSystemDataSetTableAdapters.CustomerTableAdapter();
            this.bookingBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.C_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Advance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trail_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMSystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMSystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMSystemDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // Customer_Combo2
            // 
            this.Customer_Combo2.FormattingEnabled = true;
            this.Customer_Combo2.Location = new System.Drawing.Point(36, 57);
            this.Customer_Combo2.Name = "Customer_Combo2";
            this.Customer_Combo2.Size = new System.Drawing.Size(148, 24);
            this.Customer_Combo2.TabIndex = 15;
            this.Customer_Combo2.SelectedIndexChanged += new System.EventHandler(this.Customer_Combo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name Or PhoneNo";
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataMember = "Booking";
            this.bookingBindingSource.DataSource = this.tMSystemDataSetBindingSource;
            // 
            // tMSystemDataSetBindingSource
            // 
            this.tMSystemDataSetBindingSource.DataSource = this.tMSystemDataSet;
            this.tMSystemDataSetBindingSource.Position = 0;
            // 
            // tMSystemDataSet
            // 
            this.tMSystemDataSet.DataSetName = "TMSystemDataSet";
            this.tMSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingTableAdapter
            // 
            this.bookingTableAdapter.ClearBeforeFill = true;
            // 
            // tMSystemDataSet1
            // 
            this.tMSystemDataSet1.DataSetName = "TMSystemDataSet1";
            this.tMSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tMSystemDataSet1BindingSource
            // 
            this.tMSystemDataSet1BindingSource.DataSource = this.tMSystemDataSet1;
            this.tMSystemDataSet1BindingSource.Position = 0;
            // 
            // bookingBindingSource1
            // 
            this.bookingBindingSource1.DataMember = "Booking";
            this.bookingBindingSource1.DataSource = this.tMSystemDataSet1BindingSource;
            // 
            // bookingTableAdapter1
            // 
            this.bookingTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_Name,
            this.ContactNo,
            this.Advance,
            this.Balance,
            this.totalDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.Trail_Date,
            this.dueDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookingBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(36, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(843, 268);
            this.dataGridView1.TabIndex = 16;
            // 
            // tMSystem
            // 
            this.tMSystem.DataSetName = "TMSystem";
            this.tMSystem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingTableAdapter2
            // 
            this.bookingTableAdapter2.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookingTableAdapter = this.bookingTableAdapter2;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.LowerTableAdapter = null;
            this.tableAdapterManager.StitchingTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Tailor.TMSystemTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UpperTableAdapter = null;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.tMSystemDataSetBindingSource;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // bookingBindingSource2
            // 
            this.bookingBindingSource2.DataMember = "Booking";
            this.bookingBindingSource2.DataSource = this.tMSystemDataSetBindingSource;
            // 
            // C_Name
            // 
            this.C_Name.DataPropertyName = "B_id";
            this.C_Name.HeaderText = "C_Name";
            this.C_Name.Name = "C_Name";
            this.C_Name.ReadOnly = true;
            // 
            // ContactNo
            // 
            this.ContactNo.DataPropertyName = "B_id";
            this.ContactNo.HeaderText = "ContactNo";
            this.ContactNo.Name = "ContactNo";
            this.ContactNo.ReadOnly = true;
            // 
            // Advance
            // 
            this.Advance.DataPropertyName = "B_id";
            this.Advance.HeaderText = "Advance";
            this.Advance.Name = "Advance";
            this.Advance.ReadOnly = true;
            // 
            // Balance
            // 
            this.Balance.DataPropertyName = "B_id";
            this.Balance.HeaderText = "Balance";
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // Trail_Date
            // 
            this.Trail_Date.DataPropertyName = "B_id";
            this.Trail_Date.HeaderText = "Trail_Date";
            this.Trail_Date.Name = "Trail_Date";
            this.Trail_Date.ReadOnly = true;
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            this.dueDateDataGridViewTextBoxColumn.DataPropertyName = "Due_Date";
            this.dueDateDataGridViewTextBoxColumn.HeaderText = "Due_Date";
            this.dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            // 
            // BookingDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Customer_Combo2);
            this.Controls.Add(this.label1);
            this.Name = "BookingDetails";
            this.Size = new System.Drawing.Size(1119, 709);
            this.Load += new System.EventHandler(this.BookingDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMSystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMSystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMSystemDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox Customer_Combo2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource tMSystemDataSetBindingSource;
        private TMSystemDataSet tMSystemDataSet;
        private TMSystemDataSetTableAdapters.BookingTableAdapter bookingTableAdapter;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private System.Windows.Forms.BindingSource tMSystemDataSet1BindingSource;
        private TMSystemDataSet1 tMSystemDataSet1;
        private System.Windows.Forms.BindingSource bookingBindingSource1;
        private TMSystemDataSet1TableAdapters.BookingTableAdapter bookingTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TMSystem tMSystem;
        private TMSystemTableAdapters.BookingTableAdapter bookingTableAdapter2;
        private TMSystemTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private TMSystemDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.BindingSource bookingBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Advance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trail_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
    }
}

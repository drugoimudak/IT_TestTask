namespace TestTask_CS
{
    partial class StartWindow
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
            this.dgw_orders = new System.Windows.Forms.DataGridView();
            this.dbordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_Test_IT_orders = new TestTask_CS.db_Test_IT_orders();
            this.db_Test_ITDataSet = new TestTask_CS.db_Test_ITDataSet();
            this.dbTestITDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_ordersTableAdapter = new TestTask_CS.db_Test_IT_ordersTableAdapters.db_ordersTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_date = new System.Windows.Forms.CheckBox();
            this.cb_org = new System.Windows.Forms.CheckBox();
            this.cb_city = new System.Windows.Forms.CheckBox();
            this.cb_country = new System.Windows.Forms.CheckBox();
            this.cb_manager = new System.Windows.Forms.CheckBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_Test_IT_orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_Test_ITDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTestITDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_orders
            // 
            this.dgw_orders.AllowUserToAddRows = false;
            this.dgw_orders.AllowUserToDeleteRows = false;
            this.dgw_orders.AutoGenerateColumns = false;
            this.dgw_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.dateDataGridViewTextBoxColumn,
            this.orgDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.managerDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dgw_orders.DataSource = this.dbordersBindingSource;
            this.dgw_orders.Location = new System.Drawing.Point(11, 11);
            this.dgw_orders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgw_orders.Name = "dgw_orders";
            this.dgw_orders.ReadOnly = true;
            this.dgw_orders.Size = new System.Drawing.Size(743, 246);
            this.dgw_orders.TabIndex = 0;
            // 
            // dbordersBindingSource
            // 
            this.dbordersBindingSource.DataMember = "db_orders";
            this.dbordersBindingSource.DataSource = this.db_Test_IT_orders;
            // 
            // db_Test_IT_orders
            // 
            this.db_Test_IT_orders.DataSetName = "db_Test_IT_orders";
            this.db_Test_IT_orders.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // db_Test_ITDataSet
            // 
            this.db_Test_ITDataSet.DataSetName = "db_Test_ITDataSet";
            this.db_Test_ITDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbTestITDataSetBindingSource
            // 
            this.dbTestITDataSetBindingSource.DataSource = this.db_Test_ITDataSet;
            this.dbTestITDataSetBindingSource.Position = 0;
            // 
            // db_ordersTableAdapter
            // 
            this.db_ordersTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(761, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(761, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Organization";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(761, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(761, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Country";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(761, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Manager";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(765, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Clear ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ClearSelection);
            // 
            // cb_date
            // 
            this.cb_date.AutoSize = true;
            this.cb_date.Location = new System.Drawing.Point(867, 19);
            this.cb_date.Name = "cb_date";
            this.cb_date.Size = new System.Drawing.Size(15, 14);
            this.cb_date.TabIndex = 5;
            this.cb_date.UseVisualStyleBackColor = true;
            this.cb_date.CheckedChanged += new System.EventHandler(this.FilterTable);
            // 
            // cb_org
            // 
            this.cb_org.AutoSize = true;
            this.cb_org.Location = new System.Drawing.Point(867, 48);
            this.cb_org.Name = "cb_org";
            this.cb_org.Size = new System.Drawing.Size(15, 14);
            this.cb_org.TabIndex = 5;
            this.cb_org.UseVisualStyleBackColor = true;
            this.cb_org.CheckedChanged += new System.EventHandler(this.FilterTable);
            // 
            // cb_city
            // 
            this.cb_city.AutoSize = true;
            this.cb_city.Location = new System.Drawing.Point(867, 80);
            this.cb_city.Name = "cb_city";
            this.cb_city.Size = new System.Drawing.Size(15, 14);
            this.cb_city.TabIndex = 5;
            this.cb_city.UseVisualStyleBackColor = true;
            this.cb_city.CheckedChanged += new System.EventHandler(this.FilterTable);
            // 
            // cb_country
            // 
            this.cb_country.AutoSize = true;
            this.cb_country.Location = new System.Drawing.Point(867, 110);
            this.cb_country.Name = "cb_country";
            this.cb_country.Size = new System.Drawing.Size(15, 14);
            this.cb_country.TabIndex = 5;
            this.cb_country.UseVisualStyleBackColor = true;
            this.cb_country.CheckedChanged += new System.EventHandler(this.FilterTable);
            // 
            // cb_manager
            // 
            this.cb_manager.AutoSize = true;
            this.cb_manager.Location = new System.Drawing.Point(867, 141);
            this.cb_manager.Name = "cb_manager";
            this.cb_manager.Size = new System.Drawing.Size(15, 14);
            this.cb_manager.TabIndex = 5;
            this.cb_manager.UseVisualStyleBackColor = true;
            this.cb_manager.CheckedChanged += new System.EventHandler(this.FilterTable);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orgDataGridViewTextBoxColumn
            // 
            this.orgDataGridViewTextBoxColumn.DataPropertyName = "org";
            this.orgDataGridViewTextBoxColumn.HeaderText = "Organization";
            this.orgDataGridViewTextBoxColumn.Name = "orgDataGridViewTextBoxColumn";
            this.orgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // managerDataGridViewTextBoxColumn
            // 
            this.managerDataGridViewTextBoxColumn.DataPropertyName = "manager";
            this.managerDataGridViewTextBoxColumn.HeaderText = "Manager";
            this.managerDataGridViewTextBoxColumn.Name = "managerDataGridViewTextBoxColumn";
            this.managerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 272);
            this.Controls.Add(this.cb_manager);
            this.Controls.Add(this.cb_country);
            this.Controls.Add(this.cb_city);
            this.Controls.Add(this.cb_org);
            this.Controls.Add(this.cb_date);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgw_orders);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StartWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.StartWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_Test_IT_orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_Test_ITDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTestITDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_orders;
        private db_Test_ITDataSet db_Test_ITDataSet;
        private System.Windows.Forms.BindingSource dbTestITDataSetBindingSource;
        private db_Test_IT_orders db_Test_IT_orders;
        private System.Windows.Forms.BindingSource dbordersBindingSource;
        private db_Test_IT_ordersTableAdapters.db_ordersTableAdapter db_ordersTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cb_date;
        private System.Windows.Forms.CheckBox cb_org;
        private System.Windows.Forms.CheckBox cb_city;
        private System.Windows.Forms.CheckBox cb_country;
        private System.Windows.Forms.CheckBox cb_manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;

    }
}


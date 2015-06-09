using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTask_CS
{
    public partial class StartWindow : Form
    {
        public StartWindow()
        {
            InitializeComponent();
        }

        private void StartWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_Test_IT_orders.db_orders' table. You can move, or remove it, as needed.
            this.db_ordersTableAdapter.Fill(this.db_Test_IT_orders.db_orders);
            FillComboBox("date",cb_date);
            FillComboBox("city",cb_city);
            FillComboBox("country",cb_country);
            FillComboBox("manager",cb_manager);
            FillComboBox("org", cb_organization);
        }

        //this method fills choosen combobox from the order table with uniwue items from cb_items_name column
        void FillComboBox(string cb_items_name,ComboBox cb_to_fill)
        {
            var dr = db_Test_IT_orders.db_orders;
            int quantity = db_Test_IT_orders.db_orders.Rows.Count;//getting number of rows
            cb_to_fill.Items.Clear();
            for (int i = 0; i < quantity; i++)
            {
                if (!cb_to_fill.Items.Contains(dr[i][cb_items_name]))//adding only unique
                {
                    cb_to_fill.Items.Add(dr[i][cb_items_name]);
                }
            }
        }

       

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.db_ordersTableAdapter.FillBy(this.db_Test_IT_orders.db_orders);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}

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

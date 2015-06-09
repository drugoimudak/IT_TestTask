using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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


        

        private void ClearSelection(object sender, EventArgs e)
        {
            //clear selection
            cb_date.Checked = false;
            cb_city.Checked = false;
            cb_country.Checked = false;
            cb_manager.Checked = false;
            cb_org.Checked = false;
            //returning to the usual datatable view
            this.db_ordersTableAdapter.Fill(this.db_Test_IT_orders.db_orders);


        }

        private void FilterTable(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.db_Test_ITConnectionString);
            string sql_query = "select ";
            if (cb_org.Checked || cb_city.Checked || cb_country.Checked || cb_date.Checked || cb_manager.Checked)
            {
                if (cb_city.Checked)
                {
                    sql_query += "city,";
                    dgw_orders.Columns[3].Visible = true;
                }
                if (cb_country.Checked)
                {
                    sql_query += " country, ";
                    dgw_orders.Columns[4].Visible = true;
                }
                if (cb_date.Checked)
                {
                    sql_query += " date, ";
                    dgw_orders.Columns[1].Visible = true;
                }
                if (cb_manager.Checked)
                {
                    sql_query += " manager, ";
                    dgw_orders.Columns[5].Visible = true;
                }
                if (cb_org.Checked)
                {
                    sql_query += " org, ";
                    dgw_orders.Columns[2].Visible = true;
                }
                sql_query += " sum(quantity) as quantity, sum(total) as total from db_orders group by ";

                if (cb_city.Checked)
                {
                    sql_query += "city, ";
                }
                if (cb_country.Checked)
                {
                    sql_query += " country, ";
                }
                if (cb_date.Checked)
                {
                    sql_query += " date, ";
                }
                if (cb_manager.Checked)
                {
                    sql_query += " manager, ";
                }
                if (cb_org.Checked)
                {
                    sql_query += " org, ";
                }
                sql_query = sql_query.Remove(sql_query.Length - 2);



                if (!cb_city.Checked)
                {
                    dgw_orders.Columns[3].Visible = false;
                }
                if (!cb_country.Checked)
                {
                    dgw_orders.Columns[4].Visible = false;
                }
                if (!cb_date.Checked)
                {
                    dgw_orders.Columns[1].Visible = false;
                }
                if (!cb_manager.Checked)
                {
                    dgw_orders.Columns[5].Visible = false;
                }
                if (!cb_org.Checked)
                {
                    dgw_orders.Columns[2].Visible = false;
                }


            }
            else
            {
                sql_query += " * from db_orders";
                for (int i = 1; i < 8; i++)
                {
                    dgw_orders.Columns[i].Visible = true;
                }
            }
            dgw_orders.Columns[0].Visible = false;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql_query, sqlConnection);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            // sqlConnection.Open();


            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(table);
            dgw_orders.DataSource = table;
            //data.DataSource = table;



            //sqlConnection.Open();
            //SqlDataReader reader = sqlCommand.ExecuteReader();
            //dataGridView2.DataSource = reader;
            //db_ordersTableAdapter.Connection.Close();
            //sqlConnection.Close();
        }
    }
}

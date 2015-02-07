using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atm_Manager
{
    public partial class Form2 : Form


    {
        private int lastIndex;

        


        public Form2()
        {
            InitializeComponent();
        }

      


        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'atmDataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.atmDataSet.product);
            FormHelper.form2 = this;
            reloadGridView();
        }

        


        private void افزودنکالاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        public void reloadGridView()
        {
            


            DatabaseHelper databaseHelper = new Atm_Manager.DatabaseHelper();
            
            
            string sql = "select * from product";
            databaseHelper.da = new System.Data.OleDb.OleDbDataAdapter(sql, databaseHelper.con);
            databaseHelper.con.Open();
            databaseHelper.da.Fill(databaseHelper.ds1, "product");
            
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = databaseHelper.ds1.Tables["product"];

            databaseHelper.con.Close();
            databaseHelper.con.Dispose();
        }

        private void حذفکالاToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DatabaseHelper databaseHelper = new DatabaseHelper();
            databaseHelper.removeProduct(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            reloadGridView();

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)

        {
            if (toolStripTextBox1.TextLength < 1) return;

            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Field = '{1}'", toolStripTextBox1.Text);

        }
    }
}

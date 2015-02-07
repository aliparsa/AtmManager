using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atm_Manager
{
    public partial class Form3 : Form
    {

        System.Data.OleDb.OleDbConnection con;
        DataSet ds1;
        System.Data.OleDb.OleDbDataAdapter da;
        int MaxRows = 0;
        int inc = 0;


        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product product = new Atm_Manager.Product(textBox1.Text, textBox2.Text);
            DatabaseHelper databaseHelepr = new DatabaseHelper();
            databaseHelepr.addProduct(product);
            
            FormHelper.form2.reloadGridView();
            
            this.Close();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            FormHelper.form3 = this;
        }
    }
}

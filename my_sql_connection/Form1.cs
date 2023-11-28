using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using my_sql_connection.myclass;

namespace my_sql_connection
{
    public partial class Form1 : Form
    {
      class_connection con = new class_connection();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.connectdb.Open();
                label1.Text = "You are Connected to the MySql Database!";
                label1.ForeColor = Color.Green;
                con.connectdb.Close();
            }
            catch (Exception)
            {
                label1.Text = "Failed to Connect to MySql Database!";
                label1.ForeColor = Color.Red;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
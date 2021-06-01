using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ExampleAdoNet
{
    public partial class Form1 : Form
    {
        NpgsqlConnection cn;
        string connectionString = "Server=localhost; Port=5432; User Id=postgres; Password=1234; Database=inetmagaz";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //using (cn = new NpgsqlConnection(connectionString))
            //{
            //    try
            //    {
            //        cn.Open();
            //        string strSQL = "SELECT idemployee, password, FROM buyer";
            //        NpgsqlCommand command = new NpgsqlCommand(strSQL, cn);
            //        NpgsqlDataReader rdr = command.ExecuteReader();
            //        while (rdr.Read())
            //        {
            //        }
            //        cn.Close();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}
        }
        private void btn_ConnDB_Click(object sender, EventArgs e)
        {
            Manager Manager = new Manager();
            Hide();
            Manager.ShowDialog();
            Show();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

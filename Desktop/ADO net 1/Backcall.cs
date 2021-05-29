using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleAdoNet
{
    public partial class Backcall : Form
    {

        NpgsqlConnection cn;
        string connectionString = "Server=localhost; Port=5432; User Id=postgres; Password=1234; Database=inetmagaz";
        public Backcall()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lr3 lr3 = new lr3();
            lr3.ShowDialog();
            Backcall_Load(sender, e);
        }

        private void Backcall_Load(object sender, EventArgs e)
        {
            using (cn = new NpgsqlConnection(connectionString))
            {

                try
                {
                    cn.Open();
                    string strSQL = "SELECT firstname, telnumber, problem, solve FROM feedback";
                    NpgsqlCommand command = new NpgsqlCommand(strSQL, cn);
                    NpgsqlDataReader rdr = command.ExecuteReader();
                    dg1.Rows.Clear();
                    while (rdr.Read())
                    {
                        int i = dg1.Rows.Add();
                        dg1.Rows[i].Cells[0].Value = (string)rdr["firstname"];
                        dg1.Rows[i].Cells[1].Value = (string)rdr["telnumber"];
                        dg1.Rows[i].Cells[2].Value = (string)rdr["problem"];
                        dg1.Rows[i].Cells[3].Value = (string)rdr["solve"];
                    }
                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            using (cn = new NpgsqlConnection(connectionString))
            {

                try
                {
                    cn.Open();
                    string strSQL = "SELECT firstname, telnumber, problem, solve FROM feedback";
                    NpgsqlCommand command = new NpgsqlCommand(strSQL, cn);
                    NpgsqlDataReader rdr = command.ExecuteReader();
                    dg1.Rows.Clear();
                    while (rdr.Read())
                    {
                        int i = dg1.Rows.Add();
                        dg1.Rows[i].Cells[0].Value = (string)rdr["firstname"];
                        dg1.Rows[i].Cells[1].Value = (string)rdr["telnumber"];
                        dg1.Rows[i].Cells[2].Value = (string)rdr["problem"];
                        dg1.Rows[i].Cells[3].Value = (string)rdr["solve"];
                    }
                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void find_Click(object sender, EventArgs e)
        {
            using (cn = new NpgsqlConnection(connectionString))
            {

                try
                {
                    cn.Open();
                    string strSQL = "SELECT firstname, telnumber, problem, solve FROM feedback WHERE telnumber = '" + textBox1.Text + "'";
                    NpgsqlCommand command = new NpgsqlCommand(strSQL, cn);
                    NpgsqlDataReader rdr = command.ExecuteReader();
                    dg1.Rows.Clear();
                    while (rdr.Read())
                    {
                        int i = dg1.Rows.Add();
                        dg1.Rows[i].Cells[0].Value = (string)rdr["firstname"];
                        dg1.Rows[i].Cells[1].Value = (string)rdr["telnumber"];
                        dg1.Rows[i].Cells[2].Value = (string)rdr["problem"];
                        dg1.Rows[i].Cells[3].Value = (string)rdr["solve"];
                    }
                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

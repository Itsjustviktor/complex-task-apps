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
           
        }

        private void Backcall_Load(object sender, EventArgs e)
        {
            using (cn = new NpgsqlConnection(connectionString))
            {

                try
                {
                    cn.Open();
                    string strSQL = "SELECT firstname, telnumber, problem, solve, idfeedback FROM feedback ORDER BY idfeedback DESC";
                    NpgsqlCommand command = new NpgsqlCommand(strSQL, cn);
                    NpgsqlDataReader rdr = command.ExecuteReader();
                    dg1.Rows.Clear();
                    while (rdr.Read())
                    {
                        int i = dg1.Rows.Add();
                        dg1.Rows[i].Cells[0].Value = (string)rdr["firstname"];
                        dg1.Rows[i].Cells[1].Value = (string)rdr["telnumber"];
                        dg1.Rows[i].Cells[2].Value = rdr["problem"];
                        dg1.Rows[i].Cells[3].Value = rdr["solve"];
                        dg1.Rows[i].Cells[4].Value = (int)rdr["idfeedback"];
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
                    string strSQL = "SELECT firstname, telnumber, problem, solve, idfeedback FROM feedback ORDER BY idfeedback DESC";
                    NpgsqlCommand command = new NpgsqlCommand(strSQL, cn);
                    NpgsqlDataReader rdr = command.ExecuteReader();
                    dg1.Rows.Clear();
                    while (rdr.Read())
                    {
                        int senderid = (int)rdr["idfeedback"];
                        int i = dg1.Rows.Add();
                        dg1.Rows[i].Cells[0].Value = (string)rdr["firstname"];
                        dg1.Rows[i].Cells[1].Value = (string)rdr["telnumber"];
                        dg1.Rows[i].Cells[2].Value = rdr["problem"];
                        dg1.Rows[i].Cells[3].Value = rdr["solve"];
                        dg1.Rows[i].Cells[4].Value = (int)rdr["idfeedback"];
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
                    string strSQL = "SELECT firstname, telnumber, problem, solve, idfeedback FROM feedback WHERE telnumber = '" + textBox1.Text + "'";
                    NpgsqlCommand command = new NpgsqlCommand(strSQL, cn);
                    NpgsqlDataReader rdr = command.ExecuteReader();
                    dg1.Rows.Clear();
                    while (rdr.Read())
                    {
                        int i = dg1.Rows.Add();
                        dg1.Rows[i].Cells[0].Value = (string)rdr["firstname"];
                        dg1.Rows[i].Cells[1].Value = (string)rdr["telnumber"];
                        dg1.Rows[i].Cells[2].Value = rdr["problem"];
                        dg1.Rows[i].Cells[3].Value = rdr["solve"];
                        dg1.Rows[i].Cells[4].Value = (int)rdr["idfeedback"];
                    }
                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }




        private void dg1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string nameto = dg1.SelectedRows[0].Cells[0].Value.ToString();
            string numberto = dg1.SelectedRows[0].Cells[1].Value.ToString();
            string problemto = dg1.SelectedRows[0].Cells[2].Value.ToString();
            string solveto = dg1.SelectedRows[0].Cells[3].Value.ToString();
            int intto = Convert.ToInt32(dg1.SelectedRows[0].Cells[4].Value);
            lr3 lr = new lr3(nameto, numberto, problemto, solveto, intto);
            lr.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            using (cn = new NpgsqlConnection(connectionString))
            {

                try
                {
                    cn.Open();
                    string strSQL = "SELECT firstname, telnumber, problem, solve, idfeedback FROM feedback WHERE \"end\" = false ORDER BY idfeedback ASC";
                    NpgsqlCommand command = new NpgsqlCommand(strSQL, cn);
                    NpgsqlDataReader rdr = command.ExecuteReader();
                    dg1.Rows.Clear();
                    while (rdr.Read())
                    {
                        int senderid = (int)rdr["idfeedback"];
                        int i = dg1.Rows.Add();
                        dg1.Rows[i].Cells[0].Value = (string)rdr["firstname"];
                        dg1.Rows[i].Cells[1].Value = (string)rdr["telnumber"];
                        dg1.Rows[i].Cells[2].Value = rdr["problem"];
                        dg1.Rows[i].Cells[3].Value = rdr["solve"];
                        dg1.Rows[i].Cells[4].Value = (int)rdr["idfeedback"];
                    }
                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

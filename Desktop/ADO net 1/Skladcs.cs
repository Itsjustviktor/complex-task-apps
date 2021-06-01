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
    public partial class Skladcs : Form
    {

        NpgsqlConnection cn;
        string connectionString = "Server=localhost; Port=5432; User Id=postgres; Password=1234; Database=inetmagaz";

        NpgsqlConnection cnA;
        string connectionStringA = "Server=localhost; Port=5432; User Id=postgres; Password=1234; Database=inetmagaz";

        public Skladcs()
        {
            InitializeComponent();
        }

        private void Skladcs_Load(object sender, EventArgs e)
        {
            using (cnA = new NpgsqlConnection(connectionStringA))
            {
                cnA.Open();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT name FROM good ORDER BY name DESC", cnA);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                comboBox1.DataSource = dt;
                comboBox1.ValueMember = "name";
                cnA.Close();
            }
            using (cn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    cn.Open();
                    string strSQL = "SELECT idgood, name, price, quantity, category, subcategory FROM good ORDER BY idgood";
                    NpgsqlCommand command = new NpgsqlCommand(strSQL, cn);
                    NpgsqlDataReader rdr = command.ExecuteReader();
                    dataGridView1.Rows.Clear();
                    while (rdr.Read())
                    {
                        int i = dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells[0].Value = (int)rdr["idgood"];
                        dataGridView1.Rows[i].Cells[1].Value = (string)rdr["name"];
                        dataGridView1.Rows[i].Cells[2].Value = (double)rdr["price"];
                        dataGridView1.Rows[i].Cells[3].Value = (int)rdr["quantity"];
                        dataGridView1.Rows[i].Cells[4].Value = (string)rdr["category"];
                        dataGridView1.Rows[i].Cells[5].Value = (string)rdr["subcategory"];
                    }
                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

              
            }

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            using (cn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    cn.Open();
                    string strSQL = "SELECT idgood, name, price, quantity, category, subcategory FROM good WHERE name ='" + comboBox1.Text+ "'";
                    NpgsqlCommand command = new NpgsqlCommand(strSQL, cn);
                    NpgsqlDataReader rdr = command.ExecuteReader();
                    dataGridView1.Rows.Clear();
                    while (rdr.Read())
                    {
                        int i = dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells[0].Value = (int)rdr["idgood"];
                        dataGridView1.Rows[i].Cells[1].Value = (string)rdr["name"];
                        dataGridView1.Rows[i].Cells[2].Value = (double)rdr["price"];
                        dataGridView1.Rows[i].Cells[3].Value = (int)rdr["quantity"];
                        dataGridView1.Rows[i].Cells[4].Value = (string)rdr["category"];
                        dataGridView1.Rows[i].Cells[5].Value = (string)rdr["subcategory"];
                    }
                    cn.Close();
                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (cn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    cn.Open();
                    string strSQL = "SELECT idgood, name, price, quantity, category, subcategory FROM good";
                    NpgsqlCommand command = new NpgsqlCommand(strSQL, cn);
                    NpgsqlDataReader rdr = command.ExecuteReader();
                    dataGridView1.Rows.Clear();
                    while (rdr.Read())
                    {
                        int i = dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells[0].Value = (int)rdr["idgood"];
                        dataGridView1.Rows[i].Cells[1].Value = (string)rdr["name"];
                        dataGridView1.Rows[i].Cells[2].Value = (double)rdr["price"];
                        dataGridView1.Rows[i].Cells[3].Value = (int)rdr["quantity"];
                        dataGridView1.Rows[i].Cells[4].Value = (string)rdr["category"];
                        dataGridView1.Rows[i].Cells[5].Value = (string)rdr["subcategory"];
                    }
                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        } //обновить

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost; Port=5432; User Id=postgres; Password=1234; Database=inetmagaz";
            try
            {
                NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
                npgSqlConnection.Open();
                string strSQL = "UPDATE good SET quantity = " + Convert.ToInt32(numericUpDown1.Value) + "WHERE name = '" + comboBox1.Text + "'";
                NpgsqlCommand command = new NpgsqlCommand(strSQL, npgSqlConnection);
                if (command.ExecuteNonQuery() == 1) MessageBox.Show("Запись обновлена!");
                npgSqlConnection.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            using (cn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    cn.Open();
                    string strSQL = "SELECT idgood, name, price, quantity, category, subcategory FROM good WHERE name ='" + comboBox1.Text + "'";
                    NpgsqlCommand command = new NpgsqlCommand(strSQL, cn);
                    NpgsqlDataReader rdr = command.ExecuteReader();
                    dataGridView1.Rows.Clear();

                    while (rdr.Read())
                    {
                        int i = dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells[0].Value = (int)rdr["idgood"];
                        dataGridView1.Rows[i].Cells[1].Value = (string)rdr["name"];
                        dataGridView1.Rows[i].Cells[2].Value = (double)rdr["price"];
                        dataGridView1.Rows[i].Cells[3].Value = (int)rdr["quantity"];
                        dataGridView1.Rows[i].Cells[4].Value = (string)rdr["category"];
                        dataGridView1.Rows[i].Cells[5].Value = (string)rdr["subcategory"];
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
            using (cn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    cn.Open();
                    string strSQL = "SELECT idgood, name, price, quantity, category, subcategory FROM good WHERE name = '" + textBox1.Text + "' OR firm = '" + textBox1.Text + "' OR subfirm = '" + textBox1.Text + "'";
                    NpgsqlCommand command = new NpgsqlCommand(strSQL, cn);
                    NpgsqlDataReader rdr = command.ExecuteReader();
                    dataGridView1.Rows.Clear();
                    while (rdr.Read())
                    {
                        int i = dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells[0].Value = (int)rdr["idgood"];
                        dataGridView1.Rows[i].Cells[1].Value = (string)rdr["name"];
                        dataGridView1.Rows[i].Cells[2].Value = (double)rdr["price"];
                        dataGridView1.Rows[i].Cells[3].Value = (int)rdr["quantity"];
                        dataGridView1.Rows[i].Cells[4].Value = (string)rdr["category"];
                        dataGridView1.Rows[i].Cells[5].Value = (string)rdr["subcategory"];
                    }
                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

            private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}





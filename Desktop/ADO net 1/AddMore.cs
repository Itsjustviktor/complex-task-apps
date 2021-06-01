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
    public partial class AddMore : Form
    {
        NpgsqlConnection cn;
        string connectionString = "Server=localhost; Port=5432; User Id=postgres; Password=1234; Database=inetmagaz";

        NpgsqlConnection cnA;
        string connectionStringA = "Server=localhost; Port=5432; User Id=postgres; Password=1234; Database=inetmagaz";

        int lastid2 = 0;
        List<string> tovar = new List<string>();
        List<int> qutovar = new List<int>();
        public AddMore()
        {
            InitializeComponent();
            using (cn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    cn.Open();
                    string strSQL = "SELECT provider FROM provider";
                    NpgsqlCommand command = new NpgsqlCommand(strSQL, cn);
                    NpgsqlDataReader rdr = command.ExecuteReader();
                    int i = 0;
                    while (rdr.Read())
                    {
                        comboBox1.Items.Insert(i, rdr["provider"]);
                    }
                    cn.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void lastid()
        {
            using (cn = new NpgsqlConnection(connectionString))
            {

                try
                {
                    cn.Open();
                    string strSQL = "SELECT idpackagesupply FROM supplygoods WHERE idpackagesupply=(SELECT max(idpackagesupply) FROM supplygoods)";
                    NpgsqlCommand command = new NpgsqlCommand(strSQL, cn);
                    NpgsqlDataReader rdr = command.ExecuteReader();
                    while (rdr.Read())
                    {
                        lastid2 = rdr.GetInt32(0);
                        lastid2++;
                    }
                    cn.Close();
                }
                catch
                {
                    MessageBox.Show("не повезло2");
                }
            }
        }
        private void AddMore_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = null;
            using (cn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    comboBox2.Items.Clear();
                    cn.Open();
                    string strSQL = "SELECT good.name FROM good INNER JOIN supply ON good.idgood = supply.idgood INNER JOIN provider ON supply.provider = provider.provider WHERE provider.provider = '" + comboBox1.Text + "'";
                    NpgsqlCommand command = new NpgsqlCommand(strSQL, cn);
                    NpgsqlDataReader rdr = command.ExecuteReader();
                    int i = 0;
                    while (rdr.Read())
                    {
                        comboBox2.Items.Insert(i, rdr["name"]);
                    }
                    cn.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                lastid();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            tovar.Add(comboBox2.Text);
            qutovar.Add(Convert.ToInt32(numericUpDown1.Value));
            int count = 0;
            dataGridView1.Rows.Clear();
            foreach (var i in tovar)
            {
                int k = dataGridView1.Rows.Add();
                dataGridView1.Rows[k].Cells[0].Value = i;
                dataGridView1.Rows[k].Cells[1].Value = qutovar[k];
                count++;
            }


        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        int idinsert = 0;
        double priceinsert = 0;
        void select()
        {
            using (cnA = new NpgsqlConnection(connectionStringA))
            {
                int k = 0;
                foreach (var i in tovar)
                {
                    cnA.Open();
                    string strSQL3 = "SELECT good.idgood, supply.pricesupply FROM good INNER JOIN supply ON good.idgood = supply.idgood WHERE good.name = '" + i + "'";
                    NpgsqlCommand command2 = new NpgsqlCommand(strSQL3, cnA);
                    NpgsqlDataReader rdr = command2.ExecuteReader();
                    while (rdr.Read())
                    {
                        idinsert = rdr.GetInt32(0);
                        priceinsert = rdr.GetDouble(1);
                    }
                    rdr.Close();
                    string strSQL2 = "INSERT INTO supplygoods (idgood, quantitydeliveredgoods, priceposition, idpackagesupply) VALUES (" + idinsert + ", " + qutovar[k] + ", " + priceinsert + ", " + lastid2 + ")";
                    NpgsqlCommand cmd2 = new NpgsqlCommand(strSQL2, cn);
                    cmd2.ExecuteNonQuery();
                    k++;
                    idinsert = 0;
                    priceinsert = 0;
                    cnA.Close();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (cn = new NpgsqlConnection(connectionString))
            {
                int k = 0;
                cn.Open();
                foreach (var i in tovar)
                { 
                string strSQL = "UPDATE good SET quantity = quantity +"+ qutovar[k] + " WHERE name = '" + i + "'";
                NpgsqlCommand command = new NpgsqlCommand(strSQL, cn);
                command.ExecuteNonQuery();

                    select();

                }
                cn.Close();
            }
        }
    }
}

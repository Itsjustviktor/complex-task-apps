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
    public partial class Add : Form
    {
        NpgsqlConnection cn;
        string connectionString = "Server=localhost; Port=5432; User Id=postgres; Password=1234; Database=inetmagaz";
        public Add()
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = null;
            using (cn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    
                    comboBox2.Items.Clear();
                    cn.Open();
                    string strSQL = "SELECT good.name FROM good INNER JOIN supply ON good.idgood = supply.idgood INNER JOIN provider ON supply.provider = provider.provider WHERE provider.provider = '"+ comboBox1.Text + "'";
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
            }
        }
        int idgood;
        int qugood;
        double pricesupply;
        int lastid2;
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
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (cn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    cn.Open();
                    string strSQL = "SELECT good.picture, supply.pricesupply, good.idgood, good.quantity FROM good INNER JOIN supply ON good.idgood = supply.idgood INNER JOIN provider ON supply.provider = provider.provider WHERE good.name = '" + comboBox2.Text + "'";
                    NpgsqlCommand command = new NpgsqlCommand(strSQL, cn);
                    NpgsqlDataReader rdr = command.ExecuteReader();
                    while (rdr.Read())
                    {
                        string p = null;
                        p = rdr.GetString(0);
                        pictureBox1.ImageLocation = p;
                        pricesupply = rdr.GetDouble(1);
                        label5.Text = Convert.ToString(rdr.GetDouble(1) * Convert.ToInt32(numericUpDown1.Value));
                        idgood = rdr.GetInt32(2);
                        qugood = rdr.GetInt32(3);
                    }
                    cn.Close();
                    lastid();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            using (cn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    cn.Open();
                    string strSQL = "SELECT supply.pricesupply FROM good INNER JOIN supply ON good.idgood = supply.idgood INNER JOIN provider ON supply.provider = provider.provider WHERE good.name = '" + comboBox2.Text + "'";
                    NpgsqlCommand command = new NpgsqlCommand(strSQL, cn);
                    NpgsqlDataReader rdr = command.ExecuteReader();
                    while (rdr.Read())
                    {
                        label5.Text = Convert.ToString(rdr.GetDouble(0));
                    }
                    double endcost = Convert.ToDouble(label5.Text) * Convert.ToInt32(numericUpDown1.Value);
                    label5.Text = Convert.ToString(endcost);
                    cn.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddMore addMore = new AddMore();
            Hide();
            addMore.ShowDialog();
            Show();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            using (cn = new NpgsqlConnection(connectionString))
            {
                    cn.Open();
                    string strSQL = "INSERT INTO supplygoods (idgood, quantitydeliveredgoods, priceposition, idpackagesupply) VALUES ("+idgood+", " + Convert.ToInt32(numericUpDown1.Value)+", "+pricesupply+", "+lastid2+")";
                    NpgsqlCommand cmd = new NpgsqlCommand(strSQL, cn);
                    if (cmd.ExecuteNonQuery() == 1)
                        MessageBox.Show("Запись успешно добавлена!");

                qugood = qugood + Convert.ToInt32(numericUpDown1.Value);
                string strSQL1 = "UPDATE good SET quantity = '" + qugood + "' WHERE idgood = " + idgood + "";
                NpgsqlCommand command = new NpgsqlCommand(strSQL1, cn);
                if (command.ExecuteNonQuery() == 1) MessageBox.Show("Статус обновлен!");
                cn.Close();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    }

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

    public partial class Orderedgood : Form
    {
        NpgsqlConnection cn;
        string connectionString = "Server=localhost; Port=5432; User Id=postgres; Password=1234; Database=inetmagaz";

        NpgsqlConnection cnA;
        string connectionStringA = "Server=localhost; Port=5432; User Id=postgres; Password=1234; Database=inetmagaz";

        int idorder;
        public Orderedgood(int id)
        {
            InitializeComponent();
            idorder = id;
        }

        private void Orderedgood_Load(object sender, EventArgs e)
        {
            using (cn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    cn.Open();
                    string strSQL = "SELECT public.good.name, orderedgoods.quantityorderedgoods, orderedgoods.price FROM orderedgoods INNER JOIN good ON orderedgoods.idgood = good.idgood INNER JOIN public.order on orderedgoods.idorder = public.order.idorder WHERE public.order.idorder = "+ idorder + "";
                    NpgsqlCommand command = new NpgsqlCommand(strSQL, cn);
                    NpgsqlDataReader rdr = command.ExecuteReader();
                    dg1.Rows.Clear();
                    while (rdr.Read())
                    {
                        int i = dg1.Rows.Add();
                        dg1.Rows[i].Cells[0].Value = (string)rdr["name"];
                        dg1.Rows[i].Cells[1].Value = (int)rdr["quantityorderedgoods"];
                        dg1.Rows[i].Cells[2].Value = (double)rdr["price"];
                    }
                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            using (cnA = new NpgsqlConnection(connectionStringA))
            {
               
                cnA.Open();
                string strSQL2 = "SELECT orderstatus FROM test";
                NpgsqlCommand cmd = new NpgsqlCommand(strSQL2, cnA);
                NpgsqlDataReader rdr1 = cmd.ExecuteReader();
                int j = 0;
                while (rdr1.Read())
                {
                    try
                    {
                        if (rdr1.GetString(0) != null)
                        {
                            comboBox1.Items.Insert(j, rdr1["orderstatus"]);
                        }
                    }
                    catch { }

                }
                cnA.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (cn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
                    npgSqlConnection.Open();

                    if (comboBox1.Text == "" && textBox2.Text != "")
                    {
                        string strSQL = "UPDATE public.order SET tracknum = '" + textBox2.Text + "' WHERE idorder = " + idorder + "";
                        NpgsqlCommand command = new NpgsqlCommand(strSQL, npgSqlConnection);
                        if (command.ExecuteNonQuery() == 1) MessageBox.Show("Трек номер обновлен!");
                        npgSqlConnection.Close();
                    }
                    if (textBox2.Text == "" && comboBox1.Text != "")
                    {
                        string strSQL = "UPDATE public.order SET status = '" + comboBox1.Text + "' WHERE idorder = " + idorder + "";
                        NpgsqlCommand command = new NpgsqlCommand(strSQL, npgSqlConnection);
                        if (command.ExecuteNonQuery() == 1) MessageBox.Show("Статус обновлен!");
                        npgSqlConnection.Close();
                    }
                    if (textBox2.Text == "" && comboBox1.Text == "")
                    {
                        MessageBox.Show("Пожалуйста, укажите данные для изменения");
                    }
                    if (textBox2.Text != "" && comboBox1.Text != "")
                    {
                        string strSQL = "UPDATE public.order SET tracknum = '" + textBox2.Text + "', status = '" + comboBox1.Text + "' WHERE idorder = " + idorder + "";
                        NpgsqlCommand command = new NpgsqlCommand(strSQL, npgSqlConnection);
                        if (command.ExecuteNonQuery() == 1) MessageBox.Show("Статус и трекномер обновлен!");
                        npgSqlConnection.Close();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

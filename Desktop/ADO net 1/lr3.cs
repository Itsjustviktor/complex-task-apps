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
    public partial class lr3 : Form
    {
        string strSQL;
        NpgsqlConnection cn;
        string connectionString = "Server=localhost; Port=5432; User Id=postgres; Password=1234; Database=inetmagaz";
        int idcheck;
        public lr3(string name, string telnum, string problem, string solve, int id)
        {
            InitializeComponent();
            textBox4.Text = name;
            textBox3.Text = telnum;
            textBox1.Text = problem;
            comboBox1.Text = solve;
            idcheck = id;
        }

        private void lr3_Load(object sender, EventArgs e)
        {
            using (cn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    cn.Open();
                    strSQL = "SELECT solve FROM test";
                    NpgsqlCommand cmd = new NpgsqlCommand(strSQL, cn);
                    NpgsqlDataReader rdr1 = cmd.ExecuteReader();
                    int i = 0;
                    while (rdr1.Read())
                    {
                        comboBox1.Items.Insert(i, rdr1["solve"]);
                    }
                    cn.Close();
                }
                catch
                {
                    MessageBox.Show("не повезло");
                }
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

                    if(comboBox1.Text == "решено")
                    { 
                    string strSQL = "UPDATE feedback SET problem = '" + textBox4.Text + "', solve = '" + textBox1.Text + "', \"end\" = true WHERE idfeedback = " + idcheck + ""; ;
                    NpgsqlCommand command = new NpgsqlCommand(strSQL, npgSqlConnection);
                    if (command.ExecuteNonQuery() == 1) MessageBox.Show("Запись обновлена!");
                    npgSqlConnection.Close();
                    }
                    if (comboBox1.Text == "нерешено")
                    {
                        string strSQL = "UPDATE feedback SET problem = '" + textBox4.Text + "', solve = '" + textBox1.Text + "', \"end\" = false WHERE idfeedback = " + idcheck + "";
                        NpgsqlCommand command = new NpgsqlCommand(strSQL, npgSqlConnection);
                        if (command.ExecuteNonQuery() == 1) MessageBox.Show("Запись обновлена!");
                        npgSqlConnection.Close();
                    }
                    if (comboBox1.Text == "перезвонить")
                    {
                        string strSQL = "UPDATE feedback SET problem = '"+ textBox4.Text +"', solve = '" + textBox1.Text + "', \"end\" = false WHERE idfeedback = " + idcheck + "";
                        NpgsqlCommand command = new NpgsqlCommand(strSQL, npgSqlConnection);
                        if (command.ExecuteNonQuery() == 1) MessageBox.Show("Запись обновлена!");
                        npgSqlConnection.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } 

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}

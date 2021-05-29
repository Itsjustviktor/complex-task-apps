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

        public lr3()
        {
            InitializeComponent();
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

        private void lr3_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (cn = new NpgsqlConnection(connectionString))
            {
                
                try
                {
                    cn.Open();
                    strSQL = "INSERT INTO feedback (firstname, telnumber, problem, solve) VALUES ('" + textBox4.Text + "','" + textBox3.Text
                        + "','" + textBox1.Text + "','" + comboBox1.Text + "')";

                    NpgsqlCommand cmd = new NpgsqlCommand(strSQL, cn);
                    if (cmd.ExecuteNonQuery() == 1)
                        MessageBox.Show("Запись успешно добавлена!");
                    cn.Close();
                }
                catch
                {
                    MessageBox.Show("не повезло2");
                }
            } 

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

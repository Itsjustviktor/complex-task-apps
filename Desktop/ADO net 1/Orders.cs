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
    public partial class Orders : Form
    {
        NpgsqlConnection cn;
        string connectionString = "Server=localhost; Port=5432; User Id=postgres; Password=1234; Database=inetmagaz";
        public Orders()
        {
            InitializeComponent();
            label3.AutoSize = false;
            label3.Paint += Label1_Paint;
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            using (cn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    cn.Open();
                    string strSQL = "SELECT public.order.idorder, buyer.telephonebuyer, public.order.status, public.order.date, public.order.priceoreder, public.order.tracknum FROM buyer " +
                    "INNER JOIN public.order ON buyer.idbuyer = public.order.idbuyer ";
                    NpgsqlCommand command = new NpgsqlCommand(strSQL, cn);
                    NpgsqlDataReader rdr = command.ExecuteReader();
                    dg1.Rows.Clear();
                    while (rdr.Read())
                    {
                        int i = dg1.Rows.Add();
                        dg1.Rows[i].Cells[0].Value = (int)rdr["idorder"];
                        dg1.Rows[i].Cells[1].Value = (string)rdr["telephonebuyer"];
                        dg1.Rows[i].Cells[2].Value = (string)rdr["status"];
                        dg1.Rows[i].Cells[3].Value = (DateTime)rdr["date"];
                        dg1.Rows[i].Cells[4].Value = (double)rdr["priceoreder"];
                        dg1.Rows[i].Cells[5].Value = (string)rdr["tracknum"];
                    }
                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void checkb_id_CheckedChanged(object sender, EventArgs e)
        {
            if (checkb_id.Checked)
                textb_id.Enabled = true;
            else
            {
                textb_id.Enabled = false;
            }
        }

        private void checkb_number_CheckedChanged(object sender, EventArgs e)
        {
            if (checkb_number.Checked)
                textb_number.Enabled = true;
            else
            {
                textb_number.Enabled = false;
            }
        }

        private void checkb_second_CheckedChanged(object sender, EventArgs e)
        {
            if (checkb_second.Checked)
                textb_second.Enabled = true;
            else
            {
                textb_second.Enabled = false;
            }
        }

        private void checkb_first_CheckedChanged(object sender, EventArgs e)
        {
            if (checkb_first.Checked)
                textb_first.Enabled = true;
            else
            {
                textb_first.Enabled = false;
            }
        }

        private void checkb_third_CheckedChanged(object sender, EventArgs e)
        {
            if (checkb_third.Checked)
                textb_third.Enabled = true;
            else
            {
                textb_third.Enabled = false;
            }
        }

        private void find_Click(object sender, EventArgs e)
        {
            using (cn = new NpgsqlConnection(connectionString))
            {
                if (textb_first.Enabled == true && textb_first.Text == "" || textb_second.Enabled == true && textb_second.Text == ""
                    || textb_third.Enabled == true && textb_third.Text == "" || textb_id.Enabled == true && textb_id.Text == ""
                    || textb_number.Enabled == true && textb_number.Text == "" || textb_third.Enabled == false && textb_first.Enabled == false && textb_second.Enabled == false &&
                    textb_id.Enabled == false && textb_number.Enabled == false)
                { MessageBox.Show("Введите данные для поиска"); }

                else
                {
                if (textb_third.Enabled == true && textb_first.Enabled == true && textb_second.Enabled == true)
                {  
                    try
                    {
                        cn.Open();
                        string strSQL = "SELECT public.order.idorder, buyer.telephonebuyer, public.order.status, public.order.date, public.order.priceoreder, public.order.tracknum FROM buyer " +
                        "INNER JOIN public.order ON buyer.idbuyer = public.order.idbuyer " +
                        "WHERE buyer.first = '" + textb_first.Text + "' AND buyer.second = '" + textb_second.Text + "' AND buyer.third = '" + textb_third.Text + "'";
                        NpgsqlCommand command = new NpgsqlCommand(strSQL, cn);
                        NpgsqlDataReader rdr = command.ExecuteReader();
                        dg1.Rows.Clear();
                        while (rdr.Read())
                        {
                            int i = dg1.Rows.Add();
                            dg1.Rows[i].Cells[0].Value = (int)rdr["idorder"];
                            dg1.Rows[i].Cells[1].Value = (string)rdr["telephonebuyer"];
                            dg1.Rows[i].Cells[2].Value = (string)rdr["status"];
                            dg1.Rows[i].Cells[3].Value = (DateTime)rdr["date"];
                            dg1.Rows[i].Cells[4].Value = (double)rdr["priceoreder"];
                                dg1.Rows[i].Cells[5].Value = (string)rdr["tracknum"];
                            }
                        cn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                } //ФИО

                if (textb_first.Enabled == true && textb_second.Enabled == true)
                {
                    try
                    {
                            cn.Open();
                            string strSQL = "SELECT public.order.idorder, buyer.telephonebuyer, public.order.status, public.order.date, public.order.priceoreder, public.order.tracknum FROM buyer " +
                            "INNER JOIN public.order ON buyer.idbuyer = public.order.idbuyer " +
                            "WHERE buyer.first = '" + textb_first.Text + "' AND buyer.second = '" + textb_second.Text + "'";
                            NpgsqlCommand command = new NpgsqlCommand(strSQL, cn);
                            NpgsqlDataReader rdr = command.ExecuteReader();
                            dg1.Rows.Clear();
                            while (rdr.Read())
                            {
                                int i = dg1.Rows.Add();
                                dg1.Rows[i].Cells[0].Value = (int)rdr["idorder"];
                                dg1.Rows[i].Cells[1].Value = (string)rdr["telephonebuyer"];
                                dg1.Rows[i].Cells[2].Value = (string)rdr["status"];
                                dg1.Rows[i].Cells[3].Value = (DateTime)rdr["date"];
                                dg1.Rows[i].Cells[4].Value = (double)rdr["priceoreder"];
                                dg1.Rows[i].Cells[5].Value = (string)rdr["tracknum"];
                            }
                            cn.Close();
                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }//ФИ

                if (textb_first.Enabled == true)
                {
                    try
                    {
                        
                        cn.Open();
                        string strSQL = "SELECT public.order.idorder, buyer.telephonebuyer, public.order.status, public.order.date, public.order.priceoreder, public.order.tracknum FROM buyer " +
                        "INNER JOIN public.order ON buyer.idbuyer = public.order.idbuyer " +
                        "WHERE buyer.first = '" + textb_first.Text + "'";
                        NpgsqlCommand command = new NpgsqlCommand(strSQL, cn);
                        NpgsqlDataReader rdr = command.ExecuteReader();
                        dg1.Rows.Clear();
                        while (rdr.Read())
                        {
                            int i = dg1.Rows.Add();
                            dg1.Rows[i].Cells[0].Value = (int)rdr["idorder"];
                            dg1.Rows[i].Cells[1].Value = (string)rdr["telephonebuyer"];
                            dg1.Rows[i].Cells[2].Value = (string)rdr["status"];
                            dg1.Rows[i].Cells[3].Value = (DateTime)rdr["date"];
                            dg1.Rows[i].Cells[4].Value = (double)rdr["priceoreder"];
                                dg1.Rows[i].Cells[5].Value = (string)rdr["tracknum"];
                            }
                        cn.Close();
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                } //И

                if (textb_first.Enabled == true && textb_third.Enabled == true)
                {
                    try
                    {
                        cn.Open();
                        string strSQL = "SELECT public.order.idorder, buyer.telephonebuyer, public.order.status, public.order.date, public.order.priceoreder, public.order.tracknum FROM buyer " +
                        "INNER JOIN public.order ON buyer.idbuyer = public.order.idbuyer " +
                        "WHERE buyer.first = '" + textb_first.Text + "' AND buyer.third = '" + textb_third.Text + "'";
                        NpgsqlCommand command = new NpgsqlCommand(strSQL, cn);
                        NpgsqlDataReader rdr = command.ExecuteReader();
                        dg1.Rows.Clear();
                        while (rdr.Read())
                        {
                            int i = dg1.Rows.Add();
                            dg1.Rows[i].Cells[0].Value = (int)rdr["idorder"];
                            dg1.Rows[i].Cells[1].Value = (string)rdr["telephonebuyer"];
                            dg1.Rows[i].Cells[2].Value = (string)rdr["status"];
                            dg1.Rows[i].Cells[3].Value = (DateTime)rdr["date"];
                            dg1.Rows[i].Cells[4].Value = (double)rdr["priceoreder"];
                                dg1.Rows[i].Cells[5].Value = (string)rdr["tracknum"];
                            }
                        cn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                } //ИО

                if (textb_second.Enabled == true && textb_third.Enabled == true)
                {
                    try
                    {
                        cn.Open();
                        string strSQL = "SELECT public.order.idorder, buyer.telephonebuyer, public.order.status, public.order.date, public.order.priceoreder, public.order.tracknum FROM buyer " +
                        "INNER JOIN public.order ON buyer.idbuyer = public.order.idbuyer " +
                        "WHERE buyer.second = '" + textb_second.Text + "' AND buyer.third = '" + textb_third.Text + "'";
                        NpgsqlCommand command = new NpgsqlCommand(strSQL, cn);
                        NpgsqlDataReader rdr = command.ExecuteReader();
                        dg1.Rows.Clear();
                        while (rdr.Read())
                        {
                            int i = dg1.Rows.Add();
                            dg1.Rows[i].Cells[0].Value = (int)rdr["idorder"];
                            dg1.Rows[i].Cells[1].Value = (string)rdr["telephonebuyer"];
                            dg1.Rows[i].Cells[2].Value = (string)rdr["status"];
                            dg1.Rows[i].Cells[3].Value = (DateTime)rdr["date"];
                            dg1.Rows[i].Cells[4].Value = (double)rdr["priceoreder"];
                                dg1.Rows[i].Cells[5].Value = (string)rdr["tracknum"];
                            }
                        cn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }//ФО

                if (textb_second.Enabled == true)
                {
                    try
                    {
                        cn.Open();
                        string strSQL = "SELECT public.order.idorder, buyer.telephonebuyer, public.order.status, public.order.date, public.order.priceoreder, public.order.tracknum FROM buyer " +
                        "INNER JOIN public.order ON buyer.idbuyer = public.order.idbuyer " +
                        "WHERE buyer.second = '" + textb_second.Text + "'";
                        NpgsqlCommand command = new NpgsqlCommand(strSQL, cn);
                        NpgsqlDataReader rdr = command.ExecuteReader();
                        dg1.Rows.Clear();
                        while (rdr.Read())
                        {
                            int i = dg1.Rows.Add();
                            dg1.Rows[i].Cells[0].Value = (int)rdr["idorder"];
                            dg1.Rows[i].Cells[1].Value = (string)rdr["telephonebuyer"];
                            dg1.Rows[i].Cells[2].Value = (string)rdr["status"];
                            dg1.Rows[i].Cells[3].Value = (DateTime)rdr["date"];
                            dg1.Rows[i].Cells[4].Value = (double)rdr["priceoreder"];
                                dg1.Rows[i].Cells[5].Value = (string)rdr["tracknum"];
                            }
                        cn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }//Ф

                if (textb_third.Enabled == true)
                {
                    try
                    {
                        cn.Open();
                        string strSQL = "SELECT public.order.idorder, buyer.telephonebuyer, public.order.status, public.order.date, public.order.priceoreder, public.order.tracknum FROM buyer " +
                        "INNER JOIN public.order ON buyer.idbuyer = public.order.idbuyer " +
                        "WHERE buyer.third = '" + textb_third.Text + "'";
                        NpgsqlCommand command = new NpgsqlCommand(strSQL, cn);
                        NpgsqlDataReader rdr = command.ExecuteReader();
                        dg1.Rows.Clear();
                        while (rdr.Read())
                        {
                            int i = dg1.Rows.Add();
                            dg1.Rows[i].Cells[0].Value = (int)rdr["idorder"];
                            dg1.Rows[i].Cells[1].Value = (string)rdr["telephonebuyer"];
                            dg1.Rows[i].Cells[2].Value = (string)rdr["status"];
                            dg1.Rows[i].Cells[3].Value = (DateTime)rdr["date"];
                            dg1.Rows[i].Cells[4].Value = (double)rdr["priceoreder"];
                                dg1.Rows[i].Cells[5].Value = (string)rdr["tracknum"];
                            }
                        cn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }//О

                if (textb_id.Enabled == true)
                {
                    try
                    {
                        cn.Open();
                        string strSQL = "SELECT public.order.idorder, buyer.telephonebuyer, public.order.status, public.order.date, public.order.priceoreder, public.order.tracknum FROM buyer " +
                        "INNER JOIN public.order ON buyer.idbuyer = public.order.idbuyer " +
                        "WHERE public.order.idorder ='"+ textb_id.Text +"'";
                        NpgsqlCommand command = new NpgsqlCommand(strSQL, cn);
                        NpgsqlDataReader rdr = command.ExecuteReader();
                        dg1.Rows.Clear();
                        while (rdr.Read())
                        {
                            int i = dg1.Rows.Add();
                            dg1.Rows[i].Cells[0].Value = (int)rdr["idorder"];
                            dg1.Rows[i].Cells[1].Value = (string)rdr["telephonebuyer"];
                            dg1.Rows[i].Cells[2].Value = (string)rdr["status"];
                            dg1.Rows[i].Cells[3].Value = (DateTime)rdr["date"];
                            dg1.Rows[i].Cells[4].Value = (double)rdr["priceoreder"];
                                dg1.Rows[i].Cells[5].Value = (string)rdr["tracknum"];
                            }
                        cn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                } //ИД

                if (textb_number.Enabled == true) 
                {
                    try
                    {
                        cn.Open();
                        string strSQL = "SELECT public.order.idorder, buyer.telephonebuyer, public.order.status, public.order.date, public.order.priceoreder, public.order.tracknum FROM buyer " +
                        "INNER JOIN public.order ON buyer.idbuyer = public.order.idbuyer " +
                        "WHERE buyer.telephonebuyer ='" + textb_number.Text + "'";
                        NpgsqlCommand command = new NpgsqlCommand(strSQL, cn);
                        NpgsqlDataReader rdr = command.ExecuteReader();
                        dg1.Rows.Clear();
                        while (rdr.Read())
                        {
                            int i = dg1.Rows.Add();
                            dg1.Rows[i].Cells[0].Value = (int)rdr["idorder"];
                            dg1.Rows[i].Cells[1].Value = (string)rdr["telephonebuyer"];
                            dg1.Rows[i].Cells[2].Value = (string)rdr["status"];
                            dg1.Rows[i].Cells[3].Value = (DateTime)rdr["date"];
                            dg1.Rows[i].Cells[4].Value = (double)rdr["priceoreder"];
                                dg1.Rows[i].Cells[5].Value = (string)rdr["tracknum"];
                            }
                        cn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                } //Номер телефона

                if (textb_id.Enabled == true && textb_number.Enabled == true) 
                {
                    try
                    {
                        cn.Open();
                        string strSQL = "SELECT public.order.idorder, buyer.telephonebuyer, public.order.status, public.order.date, public.order.priceoreder, public.order.tracknum FROM buyer " +
                        "INNER JOIN public.order ON buyer.idbuyer = public.order.idbuyer " +
                        "WHERE buyer.telephonebuyer ='" + textb_number.Text + "' AND public.order.idorder ='" + textb_id.Text + "'";
                        NpgsqlCommand command = new NpgsqlCommand(strSQL, cn);
                        NpgsqlDataReader rdr = command.ExecuteReader();
                        dg1.Rows.Clear();
                        while (rdr.Read())
                        {
                            int i = dg1.Rows.Add();
                            dg1.Rows[i].Cells[0].Value = (int)rdr["idorder"];
                            dg1.Rows[i].Cells[1].Value = (string)rdr["telephonebuyer"];
                            dg1.Rows[i].Cells[2].Value = (string)rdr["status"];
                            dg1.Rows[i].Cells[3].Value = (DateTime)rdr["date"];
                            dg1.Rows[i].Cells[4].Value = (double)rdr["priceoreder"];
                                dg1.Rows[i].Cells[5].Value = (string)rdr["tracknum"];
                            }
                        cn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                } //Номер телефона и ИД

                if(textb_id.Enabled == true && textb_third.Enabled == true && textb_first.Enabled == true && textb_second.Enabled == true
                    || textb_id.Enabled == true && textb_first.Enabled == true && textb_second.Enabled == true
                    || textb_id.Enabled == true && textb_first.Enabled == true
                    || textb_id.Enabled == true && textb_first.Enabled == true && textb_third.Enabled == true
                    || textb_id.Enabled == true && textb_second.Enabled == true && textb_third.Enabled == true
                    || textb_id.Enabled == true && textb_second.Enabled == true
                    || textb_id.Enabled == true && textb_third.Enabled == true

                    ||textb_number.Enabled == true && textb_third.Enabled == true && textb_first.Enabled == true && textb_second.Enabled == true
                    || textb_number.Enabled == true && textb_first.Enabled == true && textb_second.Enabled == true
                    || textb_number.Enabled == true && textb_first.Enabled == true
                    || textb_number.Enabled == true && textb_first.Enabled == true && textb_third.Enabled == true
                    || textb_number.Enabled == true && textb_second.Enabled == true && textb_third.Enabled == true
                    || textb_number.Enabled == true && textb_second.Enabled == true
                    || textb_number.Enabled == true && textb_third.Enabled == true

                    || textb_number.Enabled == true && textb_id.Enabled == true && textb_third.Enabled == true && textb_first.Enabled == true && textb_second.Enabled == true
                    || textb_number.Enabled == true && textb_id.Enabled == true && textb_first.Enabled == true && textb_second.Enabled == true
                    || textb_number.Enabled == true && textb_id.Enabled == true && textb_first.Enabled == true
                    || textb_number.Enabled == true && textb_id.Enabled == true && textb_first.Enabled == true && textb_third.Enabled == true
                    || textb_number.Enabled == true && textb_id.Enabled == true && textb_second.Enabled == true && textb_third.Enabled == true
                    || textb_number.Enabled == true && textb_id.Enabled == true && textb_second.Enabled == true
                    || textb_number.Enabled == true && textb_id.Enabled == true && textb_third.Enabled == true
                    )
                {
                    dg1.Rows.Clear();
                    MessageBox.Show("Пожалуйста выберите разные блоки поиска данных");
                }//разные блоки данных
                }
            }
        } //Поиск

        private void refresh_Click(object sender, EventArgs e)
        {
            using (cn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    cn.Open();
                    string strSQL = "SELECT public.order.idorder, buyer.telephonebuyer, public.order.status, public.order.date, public.order.priceoreder, public.order.tracknum FROM buyer " +
                    "INNER JOIN public.order ON buyer.idbuyer = public.order.idbuyer ";
                    NpgsqlCommand command = new NpgsqlCommand(strSQL, cn);
                    NpgsqlDataReader rdr = command.ExecuteReader();
                    dg1.Rows.Clear();
                    while (rdr.Read())
                    {
                        int i = dg1.Rows.Add();
                        dg1.Rows[i].Cells[0].Value = (int)rdr["idorder"];
                        dg1.Rows[i].Cells[1].Value = (string)rdr["telephonebuyer"];
                        dg1.Rows[i].Cells[2].Value = (string)rdr["status"];
                        dg1.Rows[i].Cells[3].Value = (DateTime)rdr["date"];
                        dg1.Rows[i].Cells[4].Value = (double)rdr["priceoreder"];
                        dg1.Rows[i].Cells[5].Value = (string)rdr["tracknum"];
                    }
                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }// Обновление таблицы

        private void button1_Click(object sender, EventArgs e) 
        {
            Close();
        }

        private void Label1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
            e.Graphics.RotateTransform(-90);
            SizeF textSize = e.Graphics.MeasureString(label3.Text, label3.Font);
            label3.Width = (int)textSize.Height + 2;
            label3.Height = (int)textSize.Width + 2;
            e.Graphics.TranslateTransform(-label3.Height / 2, label3.Width / 2);
            e.Graphics.DrawString(label3.Text, label3.Font, Brushes.Black, -(textSize.Width / 2), -(textSize.Height / 2));
        }

        private void dg1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           int intto = Convert.ToInt32(dg1.SelectedRows[0].Cells[0].Value);
           Orderedgood orderedgood = new Orderedgood(intto);
           orderedgood.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ComputerCompany
{
    public partial class Form1 : Form
    {

        
        SqlConnection con =
            new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=ComputerDB;Trusted_Connection=True");
         
        public Form1()
        {
            InitializeComponent();
        }

        private void AddProduct(object sender, EventArgs e)
        {
            con.Open();
            var com = new SqlCommand("ProductInsert", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            com.Parameters.AddWithValue("@market", SqlDbType.VarChar).Value = textBox1.Text.Trim();
            com.Parameters.AddWithValue("@model", SqlDbType.VarChar).Value = textBox2.Text.Trim();
            com.Parameters.AddWithValue("@type", SqlDbType.VarChar).Value = textBox3.Text.Trim();
            com.ExecuteNonQuery();
            MessageBox.Show("Product added in BD");
            con.Close();

        }

        private void AddPC(object sender, EventArgs e)
        {
            con.Open();
            var com = new SqlCommand("PсInsert", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            com.Parameters.AddWithValue("@code", SqlDbType.VarChar).Value = textBox6.Text.Trim();
            com.Parameters.AddWithValue("@model", SqlDbType.VarChar).Value = textBox5.Text.Trim();
            com.Parameters.AddWithValue("@speed", SqlDbType.VarChar).Value = textBox4.Text.Trim();
            com.Parameters.AddWithValue("@ram", SqlDbType.VarChar).Value = textBox9.Text.Trim();
            com.Parameters.AddWithValue("@hd", SqlDbType.VarChar).Value = textBox8.Text.Trim();
            com.Parameters.AddWithValue("@cd", SqlDbType.VarChar).Value = textBox7.Text.Trim();
            com.Parameters.AddWithValue("@price", SqlDbType.VarChar).Value = textBox10.Text.Trim();
            com.ExecuteNonQuery();
            MessageBox.Show("Product PC added in BD");
            con.Close();

        }

        private void AddLaptop(object sender, EventArgs e)
        {
            con.Open();
            var com = new SqlCommand("LaptopInsert", con) //
            {
                CommandType = CommandType.StoredProcedure
            };
            com.Parameters.AddWithValue("@code", SqlDbType.VarChar).Value = textBox17.Text.Trim();
            com.Parameters.AddWithValue("@model", SqlDbType.VarChar).Value = textBox16.Text.Trim();
            com.Parameters.AddWithValue("@speed", SqlDbType.VarChar).Value = textBox15.Text.Trim();
            com.Parameters.AddWithValue("@ram", SqlDbType.VarChar).Value = textBox14.Text.Trim();
            com.Parameters.AddWithValue("@hd", SqlDbType.VarChar).Value = textBox13.Text.Trim();
            com.Parameters.AddWithValue("@screen", SqlDbType.VarChar).Value = textBox12.Text.Trim();
            com.Parameters.AddWithValue("@price", SqlDbType.VarChar).Value = textBox11.Text.Trim();
            com.ExecuteNonQuery();
            MessageBox.Show("Product Laptop added in BD");
            con.Close();

        }

        private void AddPrinter(object sender, EventArgs e)
        {
            con.Open();
            var com = new SqlCommand("PrintInsert", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            com.Parameters.AddWithValue("@code", SqlDbType.VarChar).Value = textBox20.Text.Trim();
            com.Parameters.AddWithValue("@model", SqlDbType.VarChar).Value = textBox19.Text.Trim();
            com.Parameters.AddWithValue("@color", SqlDbType.VarChar).Value = textBox18.Text.Trim();
            com.Parameters.AddWithValue("@type", SqlDbType.VarChar).Value = textBox22.Text.Trim();
            com.Parameters.AddWithValue("@price", SqlDbType.VarChar).Value = textBox21.Text.Trim();
            com.ExecuteNonQuery();
            MessageBox.Show("Product Printer added in BD");
            con.Close();
        }

        private void ShowProductTable(object sender, EventArgs e)
        {
            con.Open();
            var com = new SqlCommand("ProductShow", con)
            {
                CommandType = CommandType.StoredProcedure

            };
            var dt = new DataTable();
            dt.Load(com.ExecuteReader());
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void ShowPCTable(object sender, EventArgs e)
        {
            con.Open();
            var com = new SqlCommand("PCShow", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            var dt = new DataTable();
            dt.Load(com.ExecuteReader());
            dataGridView2.DataSource = dt;
            com.ExecuteNonQuery();
            con.Close();


        }

        private void ShowLaptopTable(object sender, EventArgs e)
        {
            con.Open();
            var com = new SqlCommand("ShowLaptop", con);
            com.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(com.ExecuteReader());
            dataGridView3.DataSource = dt;
            com.ExecuteNonQuery();
            con.Close();
        }

        private void ShowPrintTable(object sender, EventArgs e)
        {
            con.Open();
            var com = new SqlCommand("PrintShow", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            DataTable dt = new DataTable();
            dt.Load(com.ExecuteReader());
            dataGridView4.DataSource = dt;
            com.ExecuteNonQuery();
            con.Close();
        }

        private void DeleteProductTable(object sender, EventArgs e)
        {
           
                con.Open();
                var com = new SqlCommand("DelProduct", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
               
                com.Parameters.AddWithValue("@ID", dataGridView1.SelectedRows[0].Cells[0].Value).ToString();


                com.ExecuteNonQuery();
                con.Close();
            }

        private void DeletePC(object sender, EventArgs e)
        {
            con.Open();
            var com = new SqlCommand("DeletePC", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            com.Parameters.AddWithValue("@ID", dataGridView2.SelectedRows[0].Cells[0].Value).ToString();
            com.ExecuteNonQuery();
            MessageBox.Show("Delete product");
            con.Close();
        }

        private void DeleteLaptop(object sender, EventArgs e)
        {
            con.Open();
            var com = new SqlCommand("DeleteLaptop", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            com.Parameters.AddWithValue("@ID", dataGridView3.SelectedRows[0].Cells[0].Value).ToString();
            com.ExecuteNonQuery();
            MessageBox.Show("Delete product");
            con.Close();


        }

        private void DeletePrinter(object sender, EventArgs e)
        {
                con.Open();
                var com = new SqlCommand("DeletePrinter", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                com.Parameters.AddWithValue("@ID", dataGridView4.SelectedRows[0].Cells[0].Value).ToString();
                com.ExecuteNonQuery();
                MessageBox.Show("Dell product");
                con.Close();
        }

        private void UpdateProduct(object sender, EventArgs e)
        {
            con.Open();
            var com = new SqlCommand("UpdateProduct", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            com.Parameters.AddWithValue("@ID", dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            com.Parameters.AddWithValue("@market", SqlDbType.Char).Value = textBox1.Text.Trim();
            com.Parameters.AddWithValue("@model", SqlDbType.Char).Value = textBox2.Text.Trim();
            com.Parameters.AddWithValue("@type", SqlDbType.Char).Value = textBox3.Text.Trim();
            com.ExecuteNonQuery();
            MessageBox.Show("Update successeful");
            con.Close();
        }

        private void UpdatePC(object sender, EventArgs e)
        {
            con.Open();
            var com = new SqlCommand("UpdatePC", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            com.Parameters.AddWithValue("@ID", dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
            com.Parameters.AddWithValue("@code", SqlDbType.Char).Value = textBox6.Text.Trim();
            com.Parameters.AddWithValue("@model", SqlDbType.Char).Value = textBox5.Text.Trim();
            com.Parameters.AddWithValue("@speed", SqlDbType.Char).Value = textBox4.Text.Trim();
            com.Parameters.AddWithValue("@ram", SqlDbType.Char).Value = textBox9.Text.Trim();
            com.Parameters.AddWithValue("@hd", SqlDbType.Char).Value = textBox8.Text.Trim();
            com.Parameters.AddWithValue("@cd", SqlDbType.Char).Value = textBox7.Text.Trim();
            com.Parameters.AddWithValue("@price", SqlDbType.Char).Value = textBox10.Text.Trim();
            com.ExecuteNonQuery();
            MessageBox.Show("Update Successeful");
            con.Close();
        }
    }
    }








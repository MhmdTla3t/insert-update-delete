using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace insert_update_delete.cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sqlcn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
        }

        //connection
        SqlConnection sqlcn;
        SqlCommand sqlcm;



public void openconnection()
        {
            if (sqlcn.State == ConnectionState.Closed)
            {
                sqlcn.Open();
            }
        }



        public void closeconnection()
        {
            if (sqlcn.State != ConnectionState.Closed)
            {
                sqlcn.Close();
            }
        }



     
        private void btnInsert_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO Products(ProductID,ProductName) VALUES('" + comboProudectID.Text+"','"+textProudectName.Text+"')";
            //  executequery(insertQuery);
            sqlcn.Open();
            sqlcm = new SqlCommand(insertQuery, sqlcn);

            try
            {
                if (sqlcm.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Inserted");
                }
                else
                {
                    MessageBox.Show("Data Not Inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            sqlcn.Close();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string updateQuery = "INSERT INTO Products(ProductID,ProductName) VALUES('" + comboProudectID.Text + "','" + textProudectName.Text + "')";

            sqlcn.Open();
            try
            {
                 sqlcm= new SqlCommand(updateQuery, sqlcn);
                if (sqlcm.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("DATA UPDATED");
                }
                else
                {
                    MessageBox.Show("Data NOT UPDATED");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlcn.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string deletQuery = "INSERT INTO Products(ProductID,ProductName) VALUES('" + comboProudectID.Text + "','" + textProudectName.Text + "')";

            sqlcn.Open();
            try
            {
                sqlcm = new SqlCommand(deletQuery, sqlcn);
                if (sqlcm.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("DATA UPDATED");
                }
                else
                {
                    MessageBox.Show("Data NOT UPDATED");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlcn.Close();
        }
    }
    }
    
    


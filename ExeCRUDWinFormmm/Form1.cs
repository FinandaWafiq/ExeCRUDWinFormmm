using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeCRUDWinFormmm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-EEHVPIV;Initial Catalog=SAMSUNG_ES;User ID=sa;Password=***********");

        private void Form1_Load(object sender, EventArgs e)
        {
            con.Open();
            string kategori = "";
            if(radioButton1.Checked==true)
            {
                kategori = radioButton1.Text;
            }
            else
            {
                kategori = radioButton2.Text;
            }
            SqlCommand com = new SqlCommand("exec dbo.SAMSUNG_ES_Product_Insert '" + int.Parse(textBox1.Text) + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + kategori + "','" + DateTime.Parse(dateTimePicker1.Text), con);
            com.ExecuteNonQuery();
            MessageBox.Show("Sukses Tersimpan");
        }
    }
}

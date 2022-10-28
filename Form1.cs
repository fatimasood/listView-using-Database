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

namespace listViewwithDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static ListView list_view = new ListView();
        private void button1_Click(object sender, EventArgs e)
        {
            string str = "";

            if(radioButton1.Checked)
            {
                str = "Male";
            }
            else
            {
                str = "Female";
            }
            ListViewItem list = new ListViewItem(textBox1.Text + " "+textBox2.Text);
            list.SubItems.Add(str);
            list.SubItems.Add(textBox3.Text);
            list.SubItems.Add(richTextBox1.Text);
            list.SubItems.Add(textBox4.Text);
            list.SubItems.Add(textBox5.Text);   
            
            list_view.Items.Add(list);

            MessageBox.Show("Your data saved successfully...!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();  
            form2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string firstName = textBox1.Text;
            string lastNmae = textBox2.Text;
            string contact = textBox3.Text;
            string warehouseno = textBox4.Text;
            string warehousename = textBox5.Text;
            string address = richTextBox1.Text;
           
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fatim\source\repos\listViewwithDatabase\Database1.mdf;Integrated Security=True";

            string str = "";

            if (radioButton1.Checked)
            {
                str = "Male";
            }
            else
            {
                str = "Female";
            }

            SqlConnection con = new SqlConnection(connectionString);
            string query = "INSERT INTO Info (FirstName, LastName, Contact,Gender, Address, Warehouseno, Warehousename ) VALUES('"+firstName+"','"+lastNmae+"','"+contact+"','"+ str+"','"+address+"','"+warehouseno+"','"+warehousename+"')";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();

            int i = cmd.ExecuteNonQuery();
            if( i > 0 )
            {
                MessageBox.Show("Data Inserted");
            }
            else if(i == 0)
            {
                MessageBox.Show("Data Not Inserted");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.ShowDialog();
        }
    }
}

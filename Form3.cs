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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace listViewwithDatabase
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in Form1.list_view.Items)
            {
                string[] str = item.SubItems[0].Text.Split(' ');

                if (str.Length >= 2)
                {
                    if (str[1].ToUpper() == textBox2.Text.ToUpper())
                    {
                        string s = "";

                        if (radioButton1.Checked)
                        {
                            s = "Male";
                        }
                        else
                        {
                            s = "Female";
                        }

                        item.SubItems[0].Text = textBox6.Text +" " +textBox1.Text;
                        item.SubItems[1].Text =s;
                        item.SubItems[2].Text = s;
                        item.SubItems[2].Text = textBox3.Text;  
                        item.SubItems[3].Text = richTextBox1.Text;
                        item.SubItems[4].Text = textBox4.Text;
                        item.SubItems[5].Text = textBox5.Text;

                        MessageBox.Show("Data Updated Successfully....!!");
                    }
                }
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
    }
}

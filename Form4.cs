using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace listViewwithDatabase
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            foreach (ListViewItem item in Form1.list_view.Items)
            {
                string[] str = item.SubItems[0].Text.Split(' ');

                if (str.Length >= 2)
                {
                    if (str[1].ToUpper() == textBox2.Text.ToUpper())
                    {

                        item.SubItems[0].Text = " ";
                        item.SubItems[1].Text = " ";
                        item.SubItems[2].Text = " ";
                        item.SubItems[3].Text = " ";
                        item.SubItems[4].Text = " ";
                        item.SubItems[5].Text = " ";

                        MessageBox.Show("Data Deleted Successfully....!!");
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in Form1.list_view.Items)
            {
                listView1.Items.Add((ListViewItem)item.Clone());
            }
        }
    }
}

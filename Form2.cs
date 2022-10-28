using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listViewwithDatabase
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in Form1.list_view.Items)
            {
                listView1.Items.Add((ListViewItem)item.Clone());
            }
            
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
                        listView1.Items.Add((ListViewItem)item.Clone());
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            label1.Text = listBox1.Items.Count + " Count";
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(textBox2.Text);
            if (listBox1.Items.Count == 0)
            {
                button2.Enabled = false;
            }
            label1.Text = listBox1.Items.Count + " Count";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = listBox1.Items.Count + " Count";
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                listBox1.Items.Add(textBox1.Text);
                label1.Text = listBox1.Items.Count + " Count";
                e.Handled = true;
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                listBox1.Items.Remove(textBox2.Text);
                if (listBox1.Items.Count == 0)
                {
                    button2.Enabled = false;
                }
                label1.Text = listBox1.Items.Count + " Count";

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var a = listBox1.SelectedItems;
            foreach (var item in a)
            {
                listBox2.Items.Add(item.ToString());
            }
        }
    }
}

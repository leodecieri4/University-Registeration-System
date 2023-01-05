using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("please input student Name", "Caution",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("please input Surname ", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("please input student ID", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            else if (comboBox2.SelectedItem == null)
            {
                MessageBox.Show("please choose student's Department", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("please choose student's Year of Entry ", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (comboBox3.SelectedItem == null)
            {
                MessageBox.Show("please choose student's Type of Scholarship", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (listBox6.FindString(textBox2.Text) != -1){

                MessageBox.Show("Student Already Registered!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);





            }

            else
            {
                listBox2.Items.Add(textBox1.Text);
                listBox1.Items.Add(textBox3.Text);
                listBox6.Items.Add(textBox2.Text);
                listBox3.Items.Add(comboBox2.Text);
                listBox7.Items.Add(comboBox1.Text);
                listBox4.Items.Add(comboBox3.Text);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            


            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Are you sure,you want to delete this student?", "Caution", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialog == DialogResult.OK)
            {
                int i = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(i);
                listBox2.Items.RemoveAt(i);
                listBox3.Items.RemoveAt(i);
                listBox4.Items.RemoveAt(i);
                listBox6.Items.RemoveAt(i);
                listBox7.Items.RemoveAt(i);

            }
            else
            {
                MessageBox.Show("Student did not deleted.");
            }


            
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listBox2.SelectedIndex; 
            listBox1.SelectedIndex = i;
            listBox3.SelectedIndex = i;
            listBox4.SelectedIndex = i;
            listBox6.SelectedIndex = i;
            listBox7.SelectedIndex = i;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int i = listBox1.SelectedIndex;
            listBox2.SelectedIndex = i;
            listBox3.SelectedIndex = i;
            listBox4.SelectedIndex = i;
            listBox6.SelectedIndex = i;
            listBox7.SelectedIndex = i;
        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listBox6.SelectedIndex;
            listBox1.SelectedIndex = i;
            listBox3.SelectedIndex = i;
            listBox4.SelectedIndex = i;
            listBox2.SelectedIndex = i;
            listBox7.SelectedIndex = i;
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listBox3.SelectedIndex;
            listBox1.SelectedIndex = i;
            listBox2.SelectedIndex = i;
            listBox4.SelectedIndex = i;
            listBox6.SelectedIndex = i;
            listBox7.SelectedIndex = i;
        }

        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listBox7.SelectedIndex;
            listBox1.SelectedIndex = i;
            listBox3.SelectedIndex = i;
            listBox4.SelectedIndex = i;
            listBox6.SelectedIndex = i;
            listBox2.SelectedIndex = i;
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listBox4.SelectedIndex;
            listBox1.SelectedIndex = i;
            listBox3.SelectedIndex = i;
            listBox2.SelectedIndex = i;
            listBox6.SelectedIndex = i;
            listBox7.SelectedIndex = i;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

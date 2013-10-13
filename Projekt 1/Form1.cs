using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Projekt_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       //test kondzia <3 

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                ComboBox comboBox = sender as ComboBox;
                if ((textBox1.Text == "1") || (textBox1.Text == "2") || (textBox1.Text == "3") || (textBox1.Text == "4") || (textBox1.Text == "5") || (textBox1.Text == "6"))
                {
                    switch (comboBox1.SelectedItem.ToString())
                    {

                        case "1":
                            listBox1.Items.Add(textBox1.Text);
                            textBox1.Clear();
                            break;
                        case "3":
                            listBox2.Items.Add(textBox1.Text);
                            textBox1.Clear();
                            break;
                        case "5":
                            listBox3.Items.Add(textBox1.Text);
                            textBox1.Clear();
                            break;

                    }
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        //test
        private void listBox3_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("ss");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;


namespace Projekt_1
{
    public partial class Form1 : Form
    {
        static int x = 17;
        static int y = 17;
        static int z = 17;
        public Form1()
        {
            InitializeComponent();
            
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        //test kondzia <3 
     

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            try
            {

                ComboBox comboBox = sender as ComboBox;
                if ((textBox1.Text == "1") || (textBox1.Text == "2") || (textBox1.Text == "3") || (textBox1.Text == "4") || (textBox1.Text == "5") || (textBox1.Text == "6"))
                {
                    switch (comboBox1.SelectedItem.ToString())
                    {

                        case "1":
                            x--;
                            listBox1.Items.Add(textBox1.Text);
                            listBox1.Height += x; //tu jest iterowana "odstęp się zmniejsza" :)
                            textBox1.Clear();
                            break;
                        case "3":
                            y--;
                            listBox2.Items.Add(textBox1.Text);
                            listBox2.Height += y;
                            textBox1.Clear();
                            break;
                        case "5":
                            z--;
                            listBox3.Items.Add(textBox1.Text);
                            listBox3.Height += z;
                            textBox1.Clear();
                            break;

                    }

                }
                else
                {
                    Form3 newForm1 = new Form3();
                    newForm1.Show();
                }
            }
            catch (NullReferenceException ex)
            {
                Form3 newForm1 = new Form3();
                newForm1.Show();
            }
        }



        //test
      private void listBox3_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

      private void informationButton_Click(object sender, EventArgs e)
      {
         /* MessageBox.Show("Autorzy: \n Konrad Cygal & Sabina Wrońska \n  \n \n © Katowice, Październik 2013", "Info",  
                           MessageBoxButtons.OK, MessageBoxIcon.Information); */
      }

      private void button2_Click(object sender, EventArgs e)
      {   
       
      }



      private void pictureBox3_Click(object sender, EventArgs e)
      {
         WindowState = System.Windows.Forms.FormWindowState.Minimized;
      }

      private void pictureBox2_Click(object sender, EventArgs e)
      {
          Application.Exit();
      }

      private void pictureBox4_Click(object sender, EventArgs e)
      {
          Form2 newForm = new Form2();
          newForm.Show();
          //this.Hide();
          /* MessageBox.Show("Autorzy: \n Konrad Cygal & Sabina Wrońska \n  \n \n © Katowice, Październik 2013", "Info",
                          MessageBoxButtons.OK, MessageBoxIcon.Information); */
      }

      private void pictureBox6_Click_1(object sender, EventArgs e)
      {
          while (listBox1.SelectedIndex != -1)
          {
              listBox1.Items.RemoveAt(listBox1.SelectedIndex);
              listBox1.Height -= x;
          }
          while (listBox2.SelectedIndex != -1)
          {
              listBox2.Items.RemoveAt(listBox2.SelectedIndex);
              listBox2.Height -= y;
          }
          while (listBox3.SelectedIndex != -1)
          {
              listBox3.Items.RemoveAt(listBox3.SelectedIndex);
              listBox3.Height -= z;
          }
           
      }

      private void pictureBox7_Click(object sender, EventArgs e)
      {
          double sum1 = 0;
          double sum2 = 0;
          double sum3 = 0;
          double num1 =0, num2=0, num3 = 0;
          
          double weight;
          double weight1, weight2, weight3;
          double average;

          foreach (string s in listBox1.Items)
          {
              try
              {
                  int n = int.Parse(s); // przypisz n jako string i sparuj na int
                  sum1 += n;
                  num1++;
              }
              catch (FormatException ex2)
              {
                  MessageBox.Show(ex2.Message);
              }

          }

          foreach (string s in listBox2.Items)
          {
              int n = int.Parse(s);
              sum2 += n;
              num2++;

          }

          foreach (string s in listBox3.Items)
          {
              int n = int.Parse(s);
              sum3 += n;
              num3++;

          }

          if (listBox1.Items.Count != -1) //jezeli kolekcja pusta nie licz wartosci do sredniej
          
              weight1 = 1;
          
          else weight1 = 0;

          if (listBox2.Items.Count != -1)
          
              weight2 = 3;
          
          else weight2 = 0;
          if (listBox3.Items.Count != -1)
         
              weight3 = 5;
          
          else weight3 = 0;

          weight = num1*weight1 + num2*weight2 + num3*weight3;
          average = (sum1 * weight1 + sum2 * weight2 + sum3 * weight3) / weight;
         
          //textBox2.Text  = average.ToString(); // paruj na stringa by w txt boxie wyswietlac

          label6.Visible = true;
          label7.Visible = true;
          

          label7.Text = String.Format("{0:0.00}", average);
      }

      } 
    }


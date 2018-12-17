using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3b
{
    /*
   Author:Agbasi oscar 
   Student number: 000333302
    Date: Nov., 11 2018
    */
    public partial class Form1 : Form
    {
        // Declaring Variables and intializing my variable
        private double Jane = 30.00;
        private double Pat = 45.00;
        private double Ron = 40.00;
        private double Sue = 50.00;
        private double Laurie = 55.00;
        private double Cut = 30.00;
        private double Wash = 20.00;
        private double Blow = 20.00;
        private double Style = 20.00;
        private double Colour = 40.00;
        private double Highlights = 50.00;
        private double Extension = 200.00;
        private double UpDO = 60;
        private double Total = 0;

        public Form1()
        {
            InitializeComponent();
            button_Add.Enabled = false; //making the add service button not clickable
            Combo_HairDresser.Enabled = true;
            Combo_HairDresser.SelectedIndex = 0;
        }

        private void listBox_Services_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_Add.Enabled = true; //making the add button clickable once you click in the services listbox
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            button_Total.Enabled = true;

            if (Combo_HairDresser.Enabled == true)

            {
                listBox_Items.Items.Add(Combo_HairDresser.Text);
                //Using an if statement to make a true or false statement

                if (Combo_HairDresser.SelectedIndex == 0)

                {
                    listBox_Price.Items.Add("   $" + Jane + ".00");
                    Total = Total + Jane; //adding Jane base-rate to the total
                }
                else if (Combo_HairDresser.SelectedIndex == 1)
                {
                    listBox_Price.Items.Add("   $" + Pat + ".00");
                    Total = Total + Pat; //adding Pat base-rate to the total
                }
                else if (Combo_HairDresser.SelectedIndex == 2)
                {
                    listBox_Price.Items.Add("   $" + Ron + ".00");
                    Total = Total + Ron;  //adding Ron base-rate to the total
                }
                else if (Combo_HairDresser.SelectedIndex == 3)
                {
                    listBox_Price.Items.Add("   $" + Sue + ".00");
                    Total = Total + Sue; //adding Sue base-rate to the total
                }
                else
                {
                    listBox_Price.Items.Add("   $" + Laurie + ".00");
                    Total = Total + Laurie; //adding Laurie the base-rate to the total
                }
                HairDresser.Enabled = false;
            }
            if (listBox_Services.SelectedIndex == 0)
            {
                listBox_Items.Items.Add(listBox_Services.SelectedItem);
                listBox_Price.Items.Add("   $" + Cut + ".00");
                Total = Total + Cut; //adding the Service charge to the total
            }
            else if (listBox_Services.SelectedIndex == 1)
            {
                listBox_Items.Items.Add(listBox_Services.SelectedItem);
                listBox_Price.Items.Add("   $" + Wash + ".00");
                Total = Total + Wash; //adding the Service charge to the total
            }
            else if (listBox_Services.SelectedIndex == 2)
            {
                listBox_Items.Items.Add(listBox_Services.SelectedItem);
                listBox_Price.Items.Add("   $" + Colour + ".00");
                Total = Total + Colour; //adding the Service charge to the total
            }
            else if (listBox_Services.SelectedIndex == 3)
            {
                listBox_Items.Items.Add(listBox_Services.SelectedItem);
                listBox_Price.Items.Add("   $" + Highlights + ".00");
                Total = Total + Highlights;
            }
            else if (listBox_Services.SelectedIndex == 4)
            {
                listBox_Items.Items.Add(listBox_Services.SelectedItem);
                listBox_Price.Items.Add("   $" + Extension + ".00");
                Total = Total + Extension; //adding the Service charge to the total
            }
            else
            {
                listBox_Items.Items.Add(listBox_Services.SelectedItem);
                listBox_Price.Items.Add("   $" + UpDO + ".00");
                Total = Total + UpDO; //adding the Service charge to the total
            }

            listBox_Items.Enabled = false;
            listBox_Price.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_Total.Text = "   $" + Total + ".00"; //calculating the total and displaying it in the text box
        }

        private void textBox_Total_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close(); //when Exit is click the program closes 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //reseting all buttons,listboxs and textbox
            
            button_Add.Enabled = false;
            button_Total.Enabled = false;
            Combo_HairDresser.Enabled = true;
            Combo_HairDresser.SelectedIndex = 0;
            listBox_Items.Items.Clear();
            listBox_Price.Items.Clear();
            textBox_Total.Text = "";
            Total = 0;
        }
    }
}

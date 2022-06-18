using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petrol_bunk_billing_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int wheels = 0;
            int price = 0;
            int total = 0;
            string fuelType=" ";


            listBox1.Items.Clear();
            listBox1.Items.Add("Welcome to my petrol bunk");
            listBox1.Items.Add("Your registration number is:" + textBox1.Text);
    //vehicle type
            if (radioButton1.Checked)
            {
                wheels = 2;
                listBox1.Items.Add("your vehicle type:"+radioButton1.Text);
            }
            else if (radioButton2.Checked)
            {
                wheels = 4;
                listBox1.Items.Add("Your vehicle type:" + radioButton2.Text);
            }
            else
            {
                MessageBox.Show("Please select fuel type");
            }

            //fuel type

            if (comboBox1.SelectedItem.ToString()=="Petrol")
            {
                price = 101;
                fuelType = "Petrol";
                listBox1.Items.Add("Your fuel type:" + fuelType);
            }
            else if (comboBox1.SelectedItem.ToString()=="Diesel")
            {
                price = 98;
                fuelType = "Diesel";
                listBox1.Items.Add("Your fuel type:" + fuelType);
            }
            else if(comboBox1.SelectedItem.ToString()=="CNG")
            {
                price = 70;
                fuelType = "CNG";
                listBox1.Items.Add("your fuel type is:" + fuelType);
            }


            //bill procedure
            if (checkBox1.Checked)
            {
                int temp = 5 * wheels;
                listBox1.Items.Add("cost is filling for air:"+temp);
                total = temp;
            }
            if (checkBox2.Checked)
            {
                int Litres = (int)numericUpDown1.Value;
                int temp = Litres * price;
                listBox1.Items.Add("cost is filling for fuel:"+temp);
                total += temp;
            }
            if (checkBox3.Checked)
            {
                int oilqty = Convert.ToInt32(numericUpDown2.Value);
                int temp = 5 * oilqty;
                listBox1.Items.Add("cost is filling for oil:"+temp);
                total += temp;
            }
            listBox1.Items.Add("total amount is:"+total);
        }
    }
}

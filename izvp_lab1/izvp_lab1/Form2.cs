using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace izvp_lab1
{
    public partial class Form2 : Form
    {
        bikeShop logic = new bikeShop();
        private bikeShop orderForm;
        public Form2( bikeShop logic)
        {
            InitializeComponent();
            orderForm = logic;
        }

       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = logic.getPrice(comboBox1.SelectedIndex).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach ( var cdx in this.Controls.OfType<ComboBox>())
                if (cdx.SelectedIndex == -1)
                {
                    MessageBox.Show(" Оформити замовлення");
                    break;
                }
            else
                    switch (comboBox2.SelectedIndex)
                    {
                        case 0: logic.record("Order.txt", FileMode.Append, comboBox1.Text, textBox1.Text); break;
                        case 1: logic.record("Order.txt", FileMode.Append, comboBox1.Text, textBox1.Text); break;
                        case 2: logic.record("Order.txt", comboBox1.Text, textBox1.Text, 0.05);  break;
                        case 3: logic.record("Order.txt", comboBox1.Text, textBox1.Text, 0.03); break;
                    }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace izvp_lab1
{
    public partial class Form3 : Form
    {
        public bikeShop orderForm;
        bikeShop logic = new bikeShop();
         public Form3( bikeShop logicForm)
        {
            InitializeComponent();
            orderForm = logicForm;
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schoolweek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           btnbutton1.Text="我已經按過了";
           Form form = new FormButton();
           
           form.Show();
            
           btnbutton1.Enabled= false;
         
            
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form form = new Form2();

            form.Show();
        }
    }
}

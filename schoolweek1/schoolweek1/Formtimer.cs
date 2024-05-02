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
    public partial class Formtimer : Form
    { 
        int scond;
        public Formtimer()
        {
           
            InitializeComponent();
            this.scond=00;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text=String.Format("{0}秒", this. scond);
            scond++;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

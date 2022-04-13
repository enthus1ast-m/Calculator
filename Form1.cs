using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        public void Method()
        {

            int n = 1;
                
                label1.Text += (n).ToString();
            
        }
       
        private void button1_Click(object sender, EventArgs e)
        {

            
            Method();
            
        }
    
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

           
        }

        
    }
}

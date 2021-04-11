using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IVS_calc
{

    public partial class Kalkulátor : Form
    {
        public Kalkulátor()
        {
            InitializeComponent();
        }
        
        //auxiliary button so I can use one function to control all buttons
        Button aux;
        private void button_1_Click(object sender, EventArgs e)
        {
            aux = sender as Button;

            textbox_example.Text += aux.Text;
        }

        private void button_power_Click(object sender, EventArgs e)
        {
            aux = sender as Button;

            textbox_example.Text += aux.Text + "(";
        }

        //starts computing
        private void button_eq_Click(object sender, EventArgs e)
        {

        }

        private void button2_delAll_Click(object sender, EventArgs e)
        {
            textbox_example.Text = "";
        }

        private void button_delOne_Click(object sender, EventArgs e)
        {
            if ((textbox_example.Text.Length - 1) > 0)
                textbox_example.Text = textbox_example.Text.Remove(textbox_example.Text.Length-1, 1);
        }
    }
}

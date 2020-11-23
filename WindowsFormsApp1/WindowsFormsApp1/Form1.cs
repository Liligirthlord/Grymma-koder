using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Random slumpsak = new Random();
        int slumpattal;
        int räknare = 0;
    
        public Form1()
        {

            slumpattal = slumpsak.Next(1, 100);
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {


            int tal = int.Parse(textBox1.Text);
            if (tal > slumpattal)
                label2.Text = "Talet är för stort";
            else if (tal < slumpattal)
                label2.Text = "Talet är för litet";
            else
            label2.Text = "Talet är för rätt!";
            räknare++;
            label4.Text = räknare.ToString();


        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {
            
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}

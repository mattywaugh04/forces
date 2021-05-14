using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 180.00));
        }
        double asin(double x)
        {
            return (Math.Asin(x) * 180 / Math.PI);
        }
        double cos(double x)
        {
            return (Math.Cos(x * Math.PI / 180.00));
        }
        double acos(double x)
        {
            return (Math.Acos(x) * 180 / Math.PI);
        }



            private void PictureBox1_Click(object sender, EventArgs e)
            {

            }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //read force and angle from textbox
                double force = double.Parse(textBox1.Text);
                Double Angle = double.Parse(textBox2.Text);
                // calculation
                double Fx = force * cos(Angle);
                double Fy = Angle * sin(Angle);
                //put values in labels
                label1.Text = "fx= " + Fx;
                label2.Text = "Fy= " + Fx;
            }
            catch
            {
                //show error message on screen if fail
                MessageBox.Show("Error! Error!! Error!!!");
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }
    }
    }


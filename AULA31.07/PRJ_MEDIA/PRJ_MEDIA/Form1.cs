using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRJ_MEDIA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            try 
	{	        
		    double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            double m = (a + b) / 2;

            lbResposta.Text = $"A média =  {m:N3}";
	}
	catch (Exception Erro)
	{
		lbResposta.Text = $"Erro: {Erro.Message}"; 
	}
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar; 
            if (Char.IsLetter(c))
	{
		 e.Handled = true;
	}
            if (c == '.') {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',' && txtA.Text.Contains(","))
            {
                e.Handled = true; 
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtB.Focus(); 
            }
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar; 
            if (Char.IsLetter(c))
	{
		 e.Handled = true;
	}
            if (c == '.') {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',' && txtA.Text.Contains(","))
            {
                e.Handled = true; 
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnMedia_Click(sender, e);  
            }
        }

        private void btnGeometrica_Click(object sender, EventArgs e)
        {
         try 
	{	        
		    double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            double m = Math.Sqrt(a * b);

            lbResposta.Text = $"A média geométrica =  {m:N3}";
	}
	catch (Exception Erro)
	{
		lbResposta.Text = $"Erro: {Erro.Message}";
	}
        }
    }
}


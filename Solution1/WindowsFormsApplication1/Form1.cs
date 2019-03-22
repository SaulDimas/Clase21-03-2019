using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	public partial class frmPrincipal : Form
	{
		public frmPrincipal()
		{
			InitializeComponent();
			textBox1.Text = "0";
			textBox2.Text = "0";
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			int a, b, r;
			a = int.Parse(textBox1.Text);
			b = int.Parse(textBox2.Text);
			r = a + b;
			label3.Text = r.ToString();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int a, b, r;
			a = int.Parse(textBox1.Text);
			b = int.Parse(textBox2.Text);
			r = a - b;
			label3.Text = r.ToString();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int a, b, r;
			a = int.Parse(textBox1.Text);
			b = int.Parse(textBox2.Text);
			r = a * b;
			label3.Text = r.ToString();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			int a, b, r;
			String Datos;
			a = int.Parse(textBox1.Text);
			b = int.Parse(textBox2.Text);
			r = a / b;
			Datos = "Resultado " + r.ToString();
			label3.Text = r.ToString();
		}

		private void label3_Click_1(object sender, EventArgs e)
		{

		}
	}
}

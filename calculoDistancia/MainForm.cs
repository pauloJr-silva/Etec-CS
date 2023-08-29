
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace calculoDistancia
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			
			float inicial, final;
			float posto1, posto2, posto3;
			float distanciaTotal, distaEntrePosto;
			
			inicial = float.Parse(textBox1.Text);
			final = float.Parse(textBox5.Text);
			
			distanciaTotal = final - inicial;
			
			distaEntrePosto = distanciaTotal / 4;
			posto1 = inicial + distaEntrePosto;
			posto2 = posto1 + distaEntrePosto;
			posto3  = posto2 + distaEntrePosto;
			
			
			textBox2.Text = posto1.ToString();
			textBox3.Text = posto2.ToString();
			textBox4.Text = posto3.ToString();
			
		}
	}
}

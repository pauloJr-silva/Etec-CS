
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoForm
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
		}
		
		float numero1;
		float numero2;
		int operacao;
		
		void Button1Click(object sender, EventArgs e)
		{
			
			//int numero1 = int.Parse( textBox1.Text);
			
			textBox1.Text = textBox1.Text + Convert.ToString(1);
		}
		
		public float Somar(float numero1, float numero2)
		{
			
			return numero1 + numero2;
		}
		
		public float subtrair(float numero1, float numero2)
		{
			
			return numero1 - numero2;
		}
		
		public float multiplicar(float numero1, float numero2)
		{
			
			return numero1 * numero2;
		}
		
		public float dividir(float numero1, float numero2)
		{
			
			return numero1 / numero2;
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + Convert.ToString(2);
		}
		void Button13Click(object sender, EventArgs e)
		{
			numero1 = long.Parse(textBox1.Text);
			operacao = 1;
			textBox1.Text = "";
			label1.Text = numero1 + "+";
		}
		void Button17Click(object sender, EventArgs e)
		{
			
			numero2 = long.Parse(textBox1.Text);
			switch (operacao) {
				case 1:
					textBox1.Text = Convert.ToString(Somar(numero1, numero2));
					label1.Text = numero1 + " + " + numero2 + " = " + textBox1.Text;
					break;
					
				case 2:
					textBox1.Text = Convert.ToString(subtrair(numero1, numero2));
					label1.Text = numero1 + " - " + numero2 + " = " + textBox1.Text;
					break;
					
				case 3:
					textBox1.Text = Convert.ToString(multiplicar(numero1, numero2));
					label1.Text = numero1 + " x " + numero2 + " = " + textBox1.Text;
					break;
					
				case 4:
					textBox1.Text = Convert.ToString(dividir(numero1, numero2));
					label1.Text = numero1 + " / " + numero2 + " = " + textBox1.Text;
					break;
			}
			
			
		}
		void Button3Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + Convert.ToString(3);
		}
		void Button6Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + Convert.ToString(4);
		}
		void Button5Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + Convert.ToString(5);
		}
		void Button4Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + Convert.ToString(6);
		}
		void Button7Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + Convert.ToString(7);
		}
		void Button8Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + Convert.ToString(8);
		}
		void Button9Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + Convert.ToString(9);
		}
		void Button10Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + Convert.ToString(0);
		}
		void Button18Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
			label1.Text = "";
		}
		void Button14Click(object sender, EventArgs e)
		{
			numero1 = long.Parse(textBox1.Text);
			operacao = 2;
			textBox1.Text = "";
			label1.Text = numero1 + "-";
		}
		void Button15Click(object sender, EventArgs e)
		{
			numero1 = long.Parse(textBox1.Text);
			operacao = 3;
			textBox1.Text = "";
			label1.Text = numero1 + " X ";
		}
		void Button16Click(object sender, EventArgs e)
		{
			numero1 = long.Parse(textBox1.Text);
			operacao = 4;
			textBox1.Text = "";
			label1.Text = numero1 + "/";
		}
		
		
	}
}

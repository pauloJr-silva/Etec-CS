
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace calculoLojaMicangas
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			int c1Ini, c2Ini, c3Ini;
			int c1Fim,c2Fim,c3Fim;
			int qtdVendaC1, qtdVendaC2, qtdVendaC3;
			int taxaC1,taxaC2,taxaC3;
			float precoC1,precoC2,precoC3;
			float valorVendaC1, valorVendaC2, valorVendaC3;
			
			c1Ini = int.Parse( textBox1.Text);
			c2Ini = int.Parse( textBox2.Text);
			c3Ini = int.Parse( textBox3.Text);
			
			c1Fim = int.Parse( textBox4.Text);
			c2Fim = int.Parse( textBox5.Text);
			c3Fim = int.Parse( textBox6.Text);
			
			precoC1 = 20.0f;
			precoC2 = 40.0f;
			precoC3 = 60.0f;
			
			qtdVendaC1  = calcularEstoque(c1Ini,c1Fim);
			qtdVendaC2 =  calcularEstoque(c2Ini,c2Fim);
			qtdVendaC3 = calcularEstoque(c3Ini,c3Fim);
			
			textBox7.Text = qtdVendaC1.ToString();
			textBox8.Text = qtdVendaC2.ToString();
			textBox9.Text = qtdVendaC3.ToString();
			
			valorVendaC1 = calcularVendas( qtdVendaC1,precoC1);
			valorVendaC2 = calcularVendas( qtdVendaC2,precoC2);
			valorVendaC3 = calcularVendas( qtdVendaC3,precoC3);
			
			textBox12.Text = valorVendaC1.ToString("C");
			textBox11.Text = valorVendaC2.ToString("C");
			textBox10.Text = valorVendaC3.ToString("C");
			
			textBox16.Text = calcularTotal(valorVendaC1,valorVendaC2,valorVendaC3).ToString("C");
			
			taxaC1 = 18;
			taxaC2 = 25;
			taxaC3 = 35;
			
			float lucroC1 = calcularLucroItem(valorVendaC1,taxaC1);
			float lucroC2 = calcularLucroItem(valorVendaC2,taxaC2);
			float lucroC3 = calcularLucroItem(valorVendaC3,taxaC3);
			
			textBox15.Text = lucroC1.ToString("C");
			textBox14.Text = lucroC2.ToString("C");
			textBox13.Text = lucroC3.ToString("C");
			
			textBox17.Text = calcularLucroTotal(lucroC1,lucroC2,lucroC3).ToString("C");
		}
		
		
		public  int calcularEstoque( int UniInicial, int UniFinal){
			
			return UniInicial - UniFinal;
		}
		
		public float calcularVendas(int qtdVendida, float preco){
			float total = (float) qtdVendida * preco;
			
			return total;
		}
		
		public float calcularTotal(float valor1, float valor2, float valor3){
			
			float somaTotal = valor1 + valor2 + valor3;
			
			return somaTotal;
		}
		
		public float calcularLucroItem (float valorVendido, int PorcTaxa){
			
			return	valorVendido * (float) PorcTaxa /100;
		}
		
		public float calcularLucroTotal(float valor1, float valor2, float valor3){
			
			float somaTotal = valor1 + valor2 + valor3;
			
			return somaTotal;
		}
		
	}
}

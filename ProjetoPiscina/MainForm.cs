/*
 * Created by SharpDevelop.
 * User: Aluno Etec
 * Date: 29/08/2023
 * Time: 19:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoPiscina
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		void Button1Click(object sender, EventArgs e)
		{
		
			float altura, largura, comprimento;
			float volumePiscina, valorServico, valorAdicional, valorImposto, valorTotal;
			
			altura = float.Parse( textBox1.Text);
			largura = float.Parse(textBox2.Text);
			comprimento = float.Parse(textBox3.Text);
						
			volumePiscina = calcularVolume(altura,largura,comprimento);
			textBox4.Text = volumePiscina.ToString();
			
			valorServico = calcularServico(volumePiscina,58.0f);
			textBox5.Text = valorServico.ToString("C");
			
			
			if(volumePiscina > 50f && volumePiscina <= 200f ){
				valorAdicional = valorServico * 0.20f;
				textBox6.Text = valorAdicional.ToString("C");
			   	
			}else if (volumePiscina > 200f){
				valorAdicional = valorServico * 0.40f;
				textBox6.Text = valorAdicional.ToString("C");
				
			}else{
				valorAdicional = 0.0f;
				textBox6.Text = valorAdicional.ToString("C");
			}
			
			valorImposto = calcularImposto(valorServico,valorAdicional);
			textBox7.Text = valorImposto.ToString("C");
			
			valorTotal = valorServico + valorAdicional + valorImposto;
			textBox8.Text = valorTotal.ToString("C");
			
			
		}
		
		public float calcularVolume(float altura, float largura, float comprimento){
			
			return altura * largura * comprimento;
		}
		
		public float calcularServico(float volume, float preco){
			
			return volume * preco;
		}
		
		public float calcularImposto(float valorServiço, float valorAdicional){
			
			return (valorServiço + valorAdicional) * 0.22f;
		}
		void Button2Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
			textBox4.Text = "";
			textBox5.Text = "";
			textBox6.Text = "";
			textBox7.Text = "";
			textBox8.Text = "";
		}
	}
}

/*
 * Created by SharpDevelop.
 * User: Aluno Etec
 * Date: 10/08/2023
 * Time: 19:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace calcularDias
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			int ano, meses, dias;
			
			ano =  int.Parse(textBox1.Text);
			meses = int.Parse(textBox2.Text);
			dias = int.Parse(textBox3.Text);
			
			//soma = ano * 365 + meses * 30 + dias;
				
			textBox4.Text = somar(ano,meses,dias).ToString();
				

			
		}
		void Button2Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox4.Clear();
		}
		
		  public int somar( int ano, int meses, int dias){
			
			return ano * 365 + meses * 30 + dias;
		}
		
	}
}

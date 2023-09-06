/*
 * Created by SharpDevelop.
 * User: Aluno Etec
 * Date: 05/09/2023
 * Time: 19:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace porjetoRadar
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			float posiInicial = float.Parse(textBox1.Text);
			float posiFinal = float.Parse(textBox2.Text);
			float tempo = float.Parse(textBox3.Text);
			
			float media = (posiFinal - posiInicial)/tempo;
			
			label4.Text =  "Velocidade média: " + media.ToString();
			
			if (media >80) {
				label5.Text = "Multa Aplicada!";
				pictureBox5.Load("multado.jpg");
				
			}else{
				label5.Text = "Parabéns! Você ganhou o selo Rubens Barrichello.";
				pictureBox5.Load("rubens.jpg");
				
			}
	
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		
	}
}

/*
 * Criado por SharpDevelop.
 * Usuário: Paulo_junior
 * Data: 05/08/2023
 * Hora: 17:21
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace ProjetoForm
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.Button button16;
		private System.Windows.Forms.Button button17;
		private System.Windows.Forms.Button button18;
		private System.Windows.Forms.Label label1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button17 = new System.Windows.Forms.Button();
			this.button18 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.button14 = new System.Windows.Forms.Button();
			this.button15 = new System.Windows.Forms.Button();
			this.button16 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(25, 99);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(59, 48);
			this.button1.TabIndex = 0;
			this.button1.Text = "1";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(25, 28);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(251, 38);
			this.textBox1.TabIndex = 3;
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(90, 99);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(59, 48);
			this.button2.TabIndex = 4;
			this.button2.Text = "2";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button13
			// 
			this.button13.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button13.Location = new System.Drawing.Point(220, 99);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(56, 24);
			this.button13.TabIndex = 16;
			this.button13.Text = "+";
			this.button13.UseVisualStyleBackColor = false;
			this.button13.Click += new System.EventHandler(this.Button13Click);
			// 
			// button17
			// 
			this.button17.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button17.Location = new System.Drawing.Point(220, 229);
			this.button17.Name = "button17";
			this.button17.Size = new System.Drawing.Size(56, 81);
			this.button17.TabIndex = 19;
			this.button17.Text = "=";
			this.button17.UseVisualStyleBackColor = false;
			this.button17.Click += new System.EventHandler(this.Button17Click);
			// 
			// button18
			// 
			this.button18.BackColor = System.Drawing.Color.Red;
			this.button18.Location = new System.Drawing.Point(220, 72);
			this.button18.Name = "button18";
			this.button18.Size = new System.Drawing.Size(56, 24);
			this.button18.TabIndex = 20;
			this.button18.Text = "C";
			this.button18.UseVisualStyleBackColor = false;
			this.button18.Click += new System.EventHandler(this.Button18Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(136, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(140, 16);
			this.label1.TabIndex = 21;
			// 
			// button14
			// 
			this.button14.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button14.Location = new System.Drawing.Point(220, 129);
			this.button14.Name = "button14";
			this.button14.Size = new System.Drawing.Size(56, 24);
			this.button14.TabIndex = 22;
			this.button14.Text = "-";
			this.button14.UseVisualStyleBackColor = false;
			this.button14.Click += new System.EventHandler(this.Button14Click);
			// 
			// button15
			// 
			this.button15.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button15.Location = new System.Drawing.Point(220, 159);
			this.button15.Name = "button15";
			this.button15.Size = new System.Drawing.Size(56, 24);
			this.button15.TabIndex = 23;
			this.button15.Text = "*";
			this.button15.UseVisualStyleBackColor = false;
			this.button15.Click += new System.EventHandler(this.Button15Click);
			// 
			// button16
			// 
			this.button16.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button16.Location = new System.Drawing.Point(220, 189);
			this.button16.Name = "button16";
			this.button16.Size = new System.Drawing.Size(56, 24);
			this.button16.TabIndex = 24;
			this.button16.Text = "/";
			this.button16.UseVisualStyleBackColor = false;
			this.button16.Click += new System.EventHandler(this.Button16Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(155, 99);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(59, 48);
			this.button3.TabIndex = 25;
			this.button3.Text = "3";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(155, 153);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(59, 48);
			this.button4.TabIndex = 26;
			this.button4.Text = "6";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(90, 153);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(59, 48);
			this.button5.TabIndex = 27;
			this.button5.Text = "5";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.Location = new System.Drawing.Point(25, 153);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(59, 48);
			this.button6.TabIndex = 28;
			this.button6.Text = "4";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button7.Location = new System.Drawing.Point(25, 207);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(59, 48);
			this.button7.TabIndex = 29;
			this.button7.Text = "7";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button8.Location = new System.Drawing.Point(90, 207);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(59, 48);
			this.button8.TabIndex = 30;
			this.button8.Text = "8";
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += new System.EventHandler(this.Button8Click);
			// 
			// button9
			// 
			this.button9.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button9.Location = new System.Drawing.Point(155, 207);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(59, 48);
			this.button9.TabIndex = 31;
			this.button9.Text = "9";
			this.button9.UseVisualStyleBackColor = false;
			this.button9.Click += new System.EventHandler(this.Button9Click);
			// 
			// button10
			// 
			this.button10.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button10.Location = new System.Drawing.Point(90, 261);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(59, 48);
			this.button10.TabIndex = 32;
			this.button10.Text = "0";
			this.button10.UseVisualStyleBackColor = false;
			this.button10.Click += new System.EventHandler(this.Button10Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(302, 322);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button16);
			this.Controls.Add(this.button15);
			this.Controls.Add(this.button14);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button18);
			this.Controls.Add(this.button17);
			this.Controls.Add(this.button13);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "ProjetoForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}

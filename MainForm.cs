/*
 * Creato da RubenZarcone
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

	
namespace Calcolare_il_mcd_GUI
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			int number1 = int.Parse(textBox1.Text);
	int number2 = int.Parse(textBox2.Text);
	int mcd = 0;
	int n1 = int.Parse(textBox1.Text);
	int n2 = int.Parse(textBox2.Text);
 while (number2 != 0)
 {
 mcd = number2;
 number2 = number1 % number2;
 number1 = mcd;
 }
 
 double mcm = n1*n2/mcd;
 string resultmcd = mcd.ToString();
 string resultmcm = mcm.ToString();
 string n1string = n1.ToString();
 string n2string = n2.ToString();
 textBox3.Text = "M.C.D. {"+n1string+"; "+n2string+"} = ("+resultmcd+") e il m.c.m. = ("+resultmcm+").";
 textBox3.Visible = true;
 button2.Visible = true;
 label3.Visible = true;
 
 
 
		
		}
		
		void TextBox3TextChanged(object sender, EventArgs e)
		{
	
		}
		void Button2Click(object sender, EventArgs e)
		{
			SaveFileDialog svf = new SaveFileDialog();
			svf.Filter = "Text Files (.txt)|*.txt";
			svf.Title = "Stampa il risultato";
			if (svf.ShowDialog() == DialogResult.OK) {
				System.IO.StreamWriter sw = new System.IO.StreamWriter(svf.FileName);
				sw.Write(textBox3.Text);
				sw.Close();
		}
	}
}
}
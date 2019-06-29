using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PRUEBA
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int x1, x2;
			x1 = Convert.ToInt32(textBox1.Text);
			x2 = Convert.ToInt32(textBox2.Text);
			MessageBox.Show((x1 + x2).ToString());
		}
	}
}

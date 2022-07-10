using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinema
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		int ücret = 0;
		int sayaç = 0;
		int sayaç2 = 0;
		int koltuk = 40;
		int KalanKoltuk2 = 0;
		int çarpan = 0;



		#region buton renk kodları
		private void A1(object sender, EventArgs e)
		{
			NameA1.BackColor = Color.Red;
			textBox1.Text += "A1 ";
			NameA1.Enabled= false;
		}

		private void A2(object sender, EventArgs e)
		{
			NameA2.BackColor = Color.Red;
			textBox1.Text += "A2 ";
			NameA2.Enabled = false;

		}

		private void A3(object sender, EventArgs e)
		{
			NameA3.BackColor = Color.Red;
			textBox1.Text += "A3 ";
			NameA3.Enabled = false;

		}

		private void A4(object sender, EventArgs e)
		{
			NameA4.BackColor = Color.Red;
			textBox1.Text += "A4 ";
			NameA4.Enabled = false;

		}

		private void A5(object sender, EventArgs e)
		{
			NameA5.BackColor = Color.Red;
			textBox1.Text += "A5 ";
			NameA5.Enabled = false;

		}

		private void B1(object sender, EventArgs e)
		{
			NameB1.BackColor = Color.Red;
			textBox1.Text += "B1 ";
			NameB1.Enabled = false;

		}

		private void B2(object sender, EventArgs e)
		{
			NameB2.BackColor = Color.Red;
			textBox1.Text += "B2 ";
			NameB2.Enabled = false;

		}

		private void B3(object sender, EventArgs e)
		{
			NameB3.BackColor = Color.Red;
			textBox1.Text += "B3 ";
			NameB3.Enabled = false;

		}

		private void B4(object sender, EventArgs e)
		{
			NameB4.BackColor = Color.Red;
			textBox1.Text += "B4 ";
			NameB4.Enabled = false;

		}

		private void B5(object sender, EventArgs e)
		{
			NameB5.BackColor = Color.Red;
			textBox1.Text += "B5 ";
			NameB5.Enabled = false;

		}

		private void C1(object sender, EventArgs e)
		{
			NameC1.BackColor = Color.Red;
			textBox1.Text += "C1 ";
			NameC1.Enabled = false;

		}

		private void C2(object sender, EventArgs e)
		{
			NameC2.BackColor = Color.Red;
			textBox1.Text += "C2 ";
			NameC2.Enabled = false;

		}

		private void C3(object sender, EventArgs e)
		{
			NameC3.BackColor = Color.Red;
			textBox1.Text += "C3 ";
			NameC3.Enabled = false;

		}

		private void C4(object sender, EventArgs e)
		{
			NameC4.BackColor = Color.Red;
			textBox1.Text += "C4 ";
			NameC4.Enabled = false;

		}

		private void C5(object sender, EventArgs e)
		{
			NameC5.BackColor = Color.Red;
			textBox1.Text += "C5 ";
			NameC5.Enabled = false;

		}

		private void D1(object sender, EventArgs e)
		{
			button71.BackColor = Color.Red;
			textBox1.Text += "D1 ";
			button71.Enabled = false;

		}

		private void D2(object sender, EventArgs e)
		{
			button70.BackColor = Color.Red;
			textBox1.Text += "D2 ";
			NameC5.Enabled = false;

		}

		private void D3(object sender, EventArgs e)
		{
			button69.BackColor = Color.Red;
			textBox1.Text += "D3 "; button69.Enabled = false;

		}

		private void D4(object sender, EventArgs e)
		{
			button68.BackColor = Color.Red;
			textBox1.Text += "D4 "; button68.Enabled = false;

		}

		private void D5(object sender, EventArgs e)
		{
			button67.BackColor = Color.Red;
			textBox1.Text += "D5 "; button67.Enabled = false;

		}

		private void E1(object sender, EventArgs e)
		{
			button76.BackColor = Color.Red;
			textBox1.Text += "E1 "; button76.Enabled = false;

		}

		private void E2(object sender, EventArgs e)
		{
			button75.BackColor = Color.Red;
			textBox1.Text += "E2 "; button75.Enabled = false;

		}

		private void E3(object sender, EventArgs e)
		{
			button74.BackColor = Color.Red;
			textBox1.Text += "E3 "; button74.Enabled = false;

		}

		private void E4(object sender, EventArgs e)
		{
			button73.BackColor = Color.Red;
			textBox1.Text += "E4 "; button73.Enabled = false;

		}

		private void E5(object sender, EventArgs e)
		{
			button72.BackColor = Color.Red;
			textBox1.Text += "E5 "; button72.Enabled = false;

		}

		private void F1(object sender, EventArgs e)
		{
			button81.BackColor = Color.Red;
			textBox1.Text += "F1 "; button81.Enabled = false;

		}

		private void F2(object sender, EventArgs e)
		{
			button80.BackColor = Color.Red;
			textBox1.Text += "F2 "; button80.Enabled = false;

		}

		private void F3(object sender, EventArgs e)
		{
			button79.BackColor = Color.Red;
			textBox1.Text += "F3 "; button79.Enabled = false;

		}

		private void F4(object sender, EventArgs e)
		{
			button78.BackColor = Color.Red;
			textBox1.Text += "F4 "; button78.Enabled = false;

		}

		private void F5(object sender, EventArgs e)
		{
			button77.BackColor = Color.Red;
			textBox1.Text += "F5 "; button77.Enabled = false;

		}

		private void G1(object sender, EventArgs e)
		{
			button86.BackColor = Color.Red;
			textBox1.Text += "G1 "; button86.Enabled = false;

		}

		private void G2(object sender, EventArgs e)
		{
			button85.BackColor = Color.Red;
			textBox1.Text += "G2 "; button85.Enabled = false;

		}

		private void G3(object sender, EventArgs e)
		{
			button84.BackColor = Color.Red;
			textBox1.Text += "G3 "; button84.Enabled = false;

		}

		private void G4(object sender, EventArgs e)
		{
			button83.BackColor = Color.Red;
			textBox1.Text += "G4 "; button83.Enabled = false;

		}

		private void G5(object sender, EventArgs e)
		{
			button82.BackColor = Color.Red;
			textBox1.Text += "G5 "; button82.Enabled = false;

		}

		private void H1(object sender, EventArgs e)
		{
			button91.BackColor = Color.Red;
			textBox1.Text += "H1 "; button91.Enabled = false;

		}

		private void H2(object sender, EventArgs e)
		{
			button90.BackColor = Color.Red;
			textBox1.Text += "H2 "; button90.Enabled = false;

		}

		private void H3(object sender, EventArgs e)
		{
			button89.BackColor = Color.Red;
			textBox1.Text += "H3 "; button89.Enabled = false;

		}

		private void H4(object sender, EventArgs e)
		{
			button88.BackColor = Color.Red;
			textBox1.Text += "H4 "; button88.Enabled = false;

		}

		private void H5(object sender, EventArgs e)
		{
			button87.BackColor = Color.Red;
			textBox1.Text += "H5 "; button87.Enabled = false;

		}
		#endregion

		private void ÖğrenciSatınAl(object sender, EventArgs e)
		{
			
			label14.Text = "0";
			string[] textBoxDizi = new string[textBox1.Text.Length];
			for (int i = 0; i < textBoxDizi.Length; i++)
			{
				textBoxDizi[i]=Convert.ToString(textBox1.Text[i]);
				if (textBoxDizi[i]==" ")
				{
					sayaç += 1;
				}
			}
			if (checkBox1.Checked=true)
			{
				çarpan = 15;
			}
			if (checkBox2.Checked = true)
			{
				çarpan = 30;
			}
			else
			{
				MessageBox.Show("öğrenci veya Tam seçimini doğru yaplmalısınız");
			}
			ücret = sayaç * çarpan;
			label14.Text =Convert.ToString(ücret);
			textBox1.Text = "";
			sayaç2 += sayaç;
			label15.Text = Convert.ToString(koltuk - sayaç2); sayaç = 0;
			checkBox1.Checked = false; checkBox2.Checked = false;

		}
		

		

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{

		}
	}
}

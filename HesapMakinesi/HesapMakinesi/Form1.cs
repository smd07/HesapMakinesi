using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int toplam=0;
        int sayi1;
        int sayi2;
        string isaret;

        int sonuc;
        public void Sonuc()
        {
            if (isaret.Equals("+"))
            {
                sonuc = sayi1 + sayi2;
                textBox1.Text = sonuc.ToString();
            }
            else if (isaret.Equals("-"))
            {
                sonuc = sayi1 - sayi2;
                textBox1.Text = sonuc.ToString();

            }
            else if (isaret.Equals("/"))
            {
                sonuc = sayi1 / sayi2;
                textBox1.Text = sonuc.ToString();
            }
            else if (isaret.Equals("X"))
            {
                sonuc = sayi1 * sayi2;
                textBox1.Text = sonuc.ToString();
            }
            else if (isaret.Equals("%"))
            {
                sonuc = sayi1 % sayi2;
                textBox1.Text = sonuc.ToString();
            }

        }

        public void isrt(int sayi1,int sayi2)
        {
            if (isaret.Equals("-"))
            {
                cıkar(sayi1, sayi2);
            }
            else if (isaret.Equals("+"))
            {
                topla(sayi1, sayi2);
            }
            else if (isaret.Equals("/"))
            {
                böl(sayi1, sayi2);
            }
            else if (isaret.Equals("X"))
            {
                carp(sayi1, sayi2);
            }
            else
            {
                modal(sayi1, sayi2);
            }

        }
       
     
        public void carp(int sayi1, int sayi2)
        {
            toplam = sayi1 * sayi2;
            textBox1.Text = toplam.ToString();
            this.sayi1 = toplam;
        }
       
        public void topla(int sayi1, int sayi2)
        {
            toplam = sayi1 + sayi2;
            textBox1.Text = toplam.ToString();
            this.sayi1 = toplam;
        }
        public void böl(int sayi1, int sayi2)
        {
            toplam = sayi1 / sayi2;
            textBox1.Text = toplam.ToString();
            this.sayi1 = toplam;
        }
        public void cıkar(int sayi1,int sayi2)
        {
            toplam= sayi1 - sayi2;
            textBox1.Text = toplam.ToString();
            this.sayi1 = toplam;

        }
        public void modal(int sayi1, int sayi2)
        {
            toplam = sayi1 % sayi2;
            textBox1.Text = toplam.ToString();
            this.sayi1 = toplam;

        }
     

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "/";
            if (sayi1 == 0)
            {
                sayi1 = int.Parse(textBox1.Text);
                textBox1.Text = "";
                isaret = "/";
            }
            else
            {
                sayi2 = int.Parse(textBox1.Text);
                textBox1.Text = "";
                isrt(sayi1, sayi2);
                label1.Text = sayi1.ToString() + "/";
                isaret = "/";
            }
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "%";
            if (sayi1 == 0)
            {
                sayi1 = int.Parse(textBox1.Text);
                textBox1.Text = "";
                isaret = "%";
                toplam = sayi1;
            }
            else
            {
                sayi2 = int.Parse(textBox1.Text);
                textBox1.Text = "";
                isrt(sayi1, sayi2);
                label1.Text = sayi1.ToString() + "%";
                isaret = "%";
            }


        }


        private void buttonMinus_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "-";
            if (sayi1 == 0)
            {
                sayi1 = int.Parse(textBox1.Text);
                textBox1.Text = "";
                isaret = "-";
            }
            else
            {
                sayi2 = int.Parse(textBox1.Text);
                textBox1.Text = "";
                isrt(sayi1, sayi2);
                label1.Text = sayi1.ToString() + "-";
                isaret = "-";
            }
            
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "+";
            if (sayi1 == 0)
            {
                sayi1 = int.Parse(textBox1.Text);
                textBox1.Text = "";
                isaret = "+";
            }
            else
            {
                sayi2 = int.Parse(textBox1.Text);
                textBox1.Text = "";
                isrt(sayi1, sayi2);
                label1.Text = sayi1.ToString() + "+";
                isaret = "+";
            }
          
        }
        private void buttonCross_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "X";

            if (sayi1 == 0)
            {
                sayi1 = int.Parse(textBox1.Text);
                textBox1.Text = "";
                isaret = "X";
            }
            else
            {
                sayi2 = int.Parse(textBox1.Text);
                textBox1.Text = "";
                isrt(sayi1, sayi2);
                label1.Text = sayi1.ToString() + "X";
                isaret = "X";
            }
        }
        private void buttonKup_Click(object sender, EventArgs e)
        {
           
            int sayi =int.Parse(textBox1.Text);
            double toplam = sayi*sayi*sayi;
            textBox1.Text = toplam.ToString();
            label1.Text = toplam.ToString();
        }
        private void buttonC_Click(object sender, EventArgs e)
        {

            textBox1.Text = "0";
            sayi1 = 0;
            sayi2 = 0;
            isaret = "";
            label1.Text = "";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (sayi1 == 0)
            {
                sayi1 = int.Parse(textBox1.Text);

                textBox1.Text = "";
            }
            else
            {
                sayi2 = int.Parse(textBox1.Text);
                Sonuc();
                label1.Text += "=" + sonuc;
                sayi1 = sonuc;

            }
            sayi1 = 0;
            sayi2 = 0;
            isaret = "";
            label1.Text = "";
        }

       

        private void buttonDEL_Click(object sender, EventArgs e)
        {


            if (textBox1.Text.Length == 1)
                textBox1.Text = "0";
            else
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
        }
      

        private void button0_Click(object sender, EventArgs e)
        {
            label1.Text += "0";
            if (textBox1.Text != "" && !textBox1.Text.Equals("0") && int.Parse(textBox1.Text.ToString()) != toplam)
                textBox1.Text += "0";
            else
                textBox1.Text = "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text += "9";
            if (textBox1.Text != "" && !textBox1.Text.Equals("0") && int.Parse(textBox1.Text.ToString()) != toplam)
                textBox1.Text += "9";
            else
                textBox1.Text = "9";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text += "8";
            if (textBox1.Text != "" && !textBox1.Text.Equals("0") && int.Parse(textBox1.Text.ToString()) != toplam)
                textBox1.Text += "8";
            else
                textBox1.Text = "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text += "7";
            if (textBox1.Text != "" && !textBox1.Text.Equals("0") && int.Parse(textBox1.Text.ToString()) != toplam)
                textBox1.Text += "7";
            else
                textBox1.Text = "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text += "6";
            if (textBox1.Text != "" && !textBox1.Text.Equals("0") && int.Parse(textBox1.Text.ToString()) != toplam)
                textBox1.Text += "6";
            else
                textBox1.Text = "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text += "5";
            if (textBox1.Text != "" && !textBox1.Text.Equals("0") && int.Parse(textBox1.Text.ToString()) != toplam)
                textBox1.Text += "5";
            else
                textBox1.Text = "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text += "4";
            if (textBox1.Text != "" && !textBox1.Text.Equals("0") && int.Parse(textBox1.Text.ToString()) != toplam)
                textBox1.Text += "4";
            else
                textBox1.Text = "4";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text += "3";
            if (textBox1.Text != "" && !textBox1.Text.Equals("0") && int.Parse(textBox1.Text.ToString()) != toplam)
                textBox1.Text += "3";
            else
                textBox1.Text = "3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text += "2";
            if (textBox1.Text != "" && !textBox1.Text.Equals("0") && int.Parse(textBox1.Text.ToString()) != toplam)
                textBox1.Text += "2";
            else
                textBox1.Text = "2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += "1";
            if (textBox1.Text != "" && !textBox1.Text.Equals("0") && int.Parse(textBox1.Text.ToString()) != toplam)
                textBox1.Text += "1";
            else
                textBox1.Text = "1";
        }

       
    }
}

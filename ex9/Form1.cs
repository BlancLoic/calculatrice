using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex9
{
    public partial class Form1 : Form
    {
        private string operation = "";
        private float val_1;
        private bool isResult = false;
        public class Calcul
        {}
        public Form1()
        {
            InitializeComponent();
        }

        private void AjoutCalcul(string symbole)
        {
            if (isResult)
            {
                textBox1.Text = "";
                isResult = false;
            }
            if (symbole == "/" || symbole == "x" || symbole == "+" || symbole == "-" )
            {
                if(textBox1.Text != "")
                {
                    val_1 = float.Parse(textBox1.Text);
                    textBox1.Text = "";
                    operation = symbole;
                }
            }
            else
            {
                textBox1.Text += symbole;
            }
            
        }
        
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_1_Click(object sender, EventArgs e)
        {
            AjoutCalcul("1");
        }

        private void Button_2_Click(object sender, EventArgs e)
        {
            AjoutCalcul("2");
        }

        private void Button_3_Click(object sender, EventArgs e)
        {
            AjoutCalcul("3");
        }

        private void Button_4_Click(object sender, EventArgs e)
        {
            AjoutCalcul("4");
        }

        private void Button_5_Click(object sender, EventArgs e)
        {
            AjoutCalcul("5");
        }

        private void Button_6_Click(object sender, EventArgs e)
        {
            AjoutCalcul("6");
        }

        private void Button_7_Click(object sender, EventArgs e)
        {
            AjoutCalcul("7");
        }

        private void Button_8_Click(object sender, EventArgs e)
        {
            AjoutCalcul("8");
        }

        private void Button_9_Click(object sender, EventArgs e)
        {
            AjoutCalcul("9");
        }

        private void Button_0_Click(object sender, EventArgs e)
        {
            AjoutCalcul("0");
        }

        private void Button_virgule_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                if (textBox1.Text.IndexOf(",") == -1)
                {
                    AjoutCalcul(",");
                }
            }
        }

        private void Button_diviser_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                AjoutCalcul("/");
            }
        }

        private void Button_effacer_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                string text = "";
                char[] tab = textBox1.Text.ToCharArray();
                for (int n = 0; n < tab.Length - 1; n++)
                {
                    text += tab[n];
                }
                textBox1.Text = text;
            }
        }
            

        private void Button_multiplier_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                AjoutCalcul("x");
            }
        }

        private void Button_soustraction_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                AjoutCalcul("-");
            }
        }

        private void Button_addition_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                AjoutCalcul("+");
            }
        }

        private void Button_resultat_Click(object sender, EventArgs e)
        {
            float val_2 = float.Parse(textBox1.Text);
            float result = 0;
            bool error = false;
            switch (operation)
            {
                case "x":
                    {
                        result = val_1 * val_2;
                        break;
                    }
                case "+":
                    {
                        result = val_1 + val_2;
                        break;
                    }
                case "-":
                    {
                        result = val_1 - val_2;
                        break;
                    }
                case "/":
                    {
                        if(val_2 == 0)
                        {
                            error = true;
                        }
                        else
                        {
                            result = val_1 / val_2;
                        }
                        break;
                    }
            }
            isResult = true;
            operation = "";
            if (error)
            {
                textBox1.Text = "Impossible de diviser par 0";
            }
            else
            {
                textBox1.Text = result.ToString();
            }
        }
    }
}

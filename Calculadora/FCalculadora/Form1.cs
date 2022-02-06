using System;
using System.Drawing;
using System.Speech.Recognition;
using System.Windows.Forms;

namespace FCalculadora
{
    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        double resultado;
        string op;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
           
            try
            {
                
            }   

            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            TBBarra.Text = TBBarra.Text + "0";
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            TBBarra.Text = TBBarra.Text + "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            TBBarra.Text = TBBarra.Text + "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            TBBarra.Text = TBBarra.Text + "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            TBBarra.Text = TBBarra.Text + "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            TBBarra.Text = TBBarra.Text + "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            TBBarra.Text = TBBarra.Text + "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            TBBarra.Text = TBBarra.Text + "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            TBBarra.Text = TBBarra.Text + "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            TBBarra.Text = TBBarra.Text + "9";
        }

        private void BtnPunto_Click(object sender, EventArgs e)
        {
            TBBarra.Text = TBBarra.Text + ".";
        }

        private void BtnMas_Click(object sender, EventArgs e)
        {
            if (TBBarra.Text != "") //esto evita que explote
            {
                panel1.BackColor = Color.Blue;
                BtnIgual.Enabled = true;
                op = "+";
                primero = double.Parse(TBBarra.Text);
                TBBarra.Clear();
               
            }

                
            
        }

        private void BtnMenos_Click(object sender, EventArgs e)
        {
            if (TBBarra.Text != "") //esto evita que explote
            {
                panel1.BackColor = Color.Red;
                BtnIgual.Enabled = true;
                op = "-";
                primero = double.Parse(TBBarra.Text);
                TBBarra.Clear();
            }
        }

        private void BtnMultiplicar_Click(object sender, EventArgs e)
        {
            if (TBBarra.Text != "") //esto evita que explote
            {
                panel1.BackColor = Color.Green;
                BtnIgual.Enabled = true;
                op = "*";
                primero = double.Parse(TBBarra.Text);
                TBBarra.Clear();
            }
        }

        private void BtnDividir_Click(object sender, EventArgs e)
        {
            if (TBBarra.Text != "") //esto evita que explote
            {
                panel1.BackColor = Color.Yellow;
                BtnIgual.Enabled = true;
                op = "/";
                primero = double.Parse(TBBarra.Text);
                TBBarra.Clear();
            }
            

            if (primero == 0)
            {
                MessageBox.Show("Error no puedes dividir entre 0");
            }
            
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            
            segundo = double.Parse(TBBarra.Text);     
            switch (op)
            {
                case "+":
                    TBBarra.Text = Convert.ToString(primero + segundo);
                    break;
                case "-":
                    TBBarra.Text = Convert.ToString(primero - segundo);
                    break;
                case "*":
                    TBBarra.Text = Convert.ToString(primero * segundo);
                    break;
                case "/":
                    TBBarra.Text = Convert.ToString(primero / segundo);
                    break;
                                 

            }
            BtnIgual.Enabled = false;
           
        }

        private void BtnCe_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.LightGray;
            TBBarra.Clear();
            BtnIgual.Enabled = true;
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.LightGray;
            primero = 0;
            segundo = 0;
            TBBarra.Clear();
        }

        private void BtnRetroceso_Click(object sender, EventArgs e)
        {
            if (TBBarra.Text.Length > 0)
            {
                TBBarra.Text = TBBarra.Text.Remove(TBBarra.Text.Length - 1, 1);

            }  
        }

        private void button15_Click(object sender, EventArgs e)
        {
        
        }

        private void BtnPorciento_Click(object sender, EventArgs e)
        {
            if (TBBarra.Text != "")
            {
                panel1.BackColor = Color.Pink;

                BtnIgual.Enabled = true;
                op = "%";
                resultado = double.Parse(TBBarra.Text);
                TBBarra.Clear();
                TBBarra.Text = Convert.ToString(resultado / 100);
            }
        }

        private void Btn1entre_Click(object sender, EventArgs e)
        {
            if (TBBarra.Text != "")
            {
                panel1.BackColor = Color.Pink;
                BtnIgual.Enabled = true;
                resultado = double.Parse(TBBarra.Text);
                TBBarra.Clear();
                TBBarra.Text = Convert.ToString(1 / resultado);


            }
        }

        private void BtnRaiz_Click(object sender, EventArgs e)
        {
            
            if (TBBarra.Text !="")
            {
                BtnRaiz.Enabled = true;
                panel1.BackColor = Color.Pink; ;
                BtnIgual.Enabled = true;
                resultado = double.Parse(TBBarra.Text);
                TBBarra.Clear();
                TBBarra.Text = Convert.ToString(Math.Sqrt(resultado));
            }
            

        }

        private void BtnNegativo_Click(object sender, EventArgs e)
        {
            if (TBBarra.Text != "")
            {
                BtnIgual.Enabled = true;
                op = "-/+";
                resultado = double.Parse(TBBarra.Text);
                TBBarra.Clear();
                TBBarra.Text = Convert.ToString(resultado * -1);
            }
              
            
        }

        private void BtnMC_Click(object sender, EventArgs e)
        {

        }
    }
}

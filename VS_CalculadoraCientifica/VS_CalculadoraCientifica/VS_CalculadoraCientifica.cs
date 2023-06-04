﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS_CalculadoraCientifica
{
    public partial class VS_CalculadoraCientifica : Form
    {

        public double valor1, valor2, resultado, memoria;
        public string operador;
        public bool inicio;
        

        public VS_CalculadoraCientifica()
        {
            InitializeComponent();
        }

        //Funcionalides dos Botões de Numeração

        private void btn0_Click(object sender, EventArgs e)
        {
            txtBoxOperacao.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtBoxOperacao.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtBoxOperacao.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtBoxOperacao.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtBoxOperacao.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtBoxOperacao.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtBoxOperacao.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtBoxOperacao.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtBoxOperacao.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtBoxOperacao.Text += "9";
        }

        //Funcionalides de Operação

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if (txtBoxOperacao.Text == "")
            {
                txtBoxOperacao.Text = "Inválido";
            }
            else if (txtBoxOperacao.Text == "Inválido")
                txtBoxOperacao.Text = "Inválido";
            else
            {
                operador = "+";
                valor1 = double.Parse(txtBoxOperacao.Text);
                lblOperacao.Text = valor1 + "+";
                txtBoxOperacao.Clear();
            }
            btnVirgula.Enabled = true;
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (txtBoxOperacao.Text == "")
            {
                operador = "-";
                valor1 = 0;
                lblOperacao.Text = valor1 + "-";
                txtBoxOperacao.Clear();
            }
            else
            {
                operador = "-";
                valor1 = double.Parse(txtBoxOperacao.Text);
                lblOperacao.Text = valor1 + "-";
                txtBoxOperacao.Clear();
            }
            btnVirgula.Enabled = true;
            
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (txtBoxOperacao.Text == "")
            {
                txtBoxOperacao.Text = "Inválido";
            }
            else if (txtBoxOperacao.Text == "Inválido")
                txtBoxOperacao.Text = "Inválido";
            else
            {
                operador = "x";
                valor1 = double.Parse(txtBoxOperacao.Text);
                lblOperacao.Text = valor1 + "x";
                txtBoxOperacao.Clear();
            }
            btnVirgula.Enabled = true;
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (txtBoxOperacao.Text == "")
            {
                txtBoxOperacao.Text = "Inválido";
            }
            else if (txtBoxOperacao.Text == "Inválido")
                txtBoxOperacao.Text = "Inválido";
            else
            {
                operador = "/";
                valor1 = double.Parse(txtBoxOperacao.Text);
                lblOperacao.Text = valor1 + "/";
                txtBoxOperacao.Clear();
            }
            btnVirgula.Enabled = true;
        }

        //Funcionalidade de Resultado

        private void btnIgual_Click(object sender, EventArgs e)
        {
             try
            {
                if(txtBoxOperacao.Text == "")
                    txtBoxOperacao.Text = "Inválido";
                else
                valor2 = double.Parse(txtBoxOperacao.Text);
            }
            catch { }
           
            switch (operador)
            {
                case "+":
                    resultado = valor1 + valor2;
                    txtBoxOperacao.Text = resultado.ToString();
                    break;
                case "-":
                    resultado = valor1 - valor2;
                    txtBoxOperacao.Text = resultado.ToString();
                    break;
                case "x":
                    
                    resultado = valor1 * valor2;
                    
                    txtBoxOperacao.Text = resultado.ToString();
                    break;
                case "/":
                    if (valor2 == 0)
                    {
                        txtBoxOperacao.Text = "Inválido";
                        MessageBox.Show("Insira um Valor Real.", "", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        txtBoxOperacao.Text = "";
                    }
                    else
                    {
                        resultado = valor1 / valor2;
                        txtBoxOperacao.Text = resultado.ToString();
                    }
                    
                    break;
                case "exp":
                    resultado = Math.Exp(valor1 * Math.Log(valor2 * 4));
                    txtBoxOperacao.Text = resultado.ToString();
                    break;
                case "mod":

                    resultado = valor1 % valor2;

                    txtBoxOperacao.Text = resultado.ToString();
                    break;
                default:
                    MessageBox.Show("Operação inexistente", "", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
            }
            btnVirgula.Enabled = true;
            
        }

        //Funcionalidades Científicas

        private void btnSin_Click(object sender, EventArgs e)
        {
            if (txtBoxOperacao.Text == "")
            {
                txtBoxOperacao.Text = "Inválido";
            }
            else if (txtBoxOperacao.Text == "Inválido")
                txtBoxOperacao.Text = "Inválido";
            else 
            {
                 valor1 = double.Parse(txtBoxOperacao.Text);
                 lblOperacao.Text = "sin(" + valor1 + ")";
                 resultado = valor1;
                 txtBoxOperacao.Text = Math.Sin(valor1).ToString();
            }
            
        }

        private void btnSinh_Click(object sender, EventArgs e)
        {
            if (txtBoxOperacao.Text == "")
            {
                txtBoxOperacao.Text = "Inválido";
            }
            else if (txtBoxOperacao.Text == "Inválido")
                txtBoxOperacao.Text = "Inválido";
            else
            {
                valor1 = double.Parse(txtBoxOperacao.Text);
                lblOperacao.Text = "sinh(" + valor1 + ")";
                resultado = valor1;
                txtBoxOperacao.Text = Math.Sinh(valor1).ToString();
            }
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            if (txtBoxOperacao.Text == "")
            {
                txtBoxOperacao.Text = "Inválido";
            }
            else if (txtBoxOperacao.Text == "Inválido")
                txtBoxOperacao.Text = "Inválido";
            else
            {
                valor1 = double.Parse(txtBoxOperacao.Text);
                lblOperacao.Text = "cos(" + valor1 + ")";
                resultado = valor1;
                txtBoxOperacao.Text = Math.Cos(valor1).ToString();
            }
        }

        private void btnCosh_Click(object sender, EventArgs e)
        {
            if (txtBoxOperacao.Text == "")
            {
                txtBoxOperacao.Text = "Inválido";
            }
            else if (txtBoxOperacao.Text == "Inválido")
                txtBoxOperacao.Text = "Inválido";
            else
            {
                valor1 = double.Parse(txtBoxOperacao.Text);
                lblOperacao.Text = "cosh(" + valor1 + ")";
                resultado = valor1;
                txtBoxOperacao.Text = Math.Cosh(valor1).ToString();
            }
        }

        private void btnTag_Click(object sender, EventArgs e)
        {
            if (txtBoxOperacao.Text == "")
            {
                txtBoxOperacao.Text = "Inválido";
            }
            else if (txtBoxOperacao.Text == "Inválido")
                txtBoxOperacao.Text = "Inválido";
            else
            {
                valor1 = double.Parse(txtBoxOperacao.Text);
                lblOperacao.Text = "tag(" + valor1 + ")";
                resultado = valor1;
                txtBoxOperacao.Text = Math.Tan(valor1).ToString();
            }
        }

        private void btnTagh_Click(object sender, EventArgs e)
        {
            if (txtBoxOperacao.Text == "")
            {
                txtBoxOperacao.Text = "Inválido";
            }
            else if (txtBoxOperacao.Text == "Inválido")
                txtBoxOperacao.Text = "Inválido";
            else
            {
                valor1 = double.Parse(txtBoxOperacao.Text);
                lblOperacao.Text = "tagh(" + valor1 + ")";
                resultado = valor1;
                txtBoxOperacao.Text = Math.Tanh(valor1).ToString();
            }
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        { 
            if (txtBoxOperacao.Text == "")
            {
                txtBoxOperacao.Text = "Inválido";
            }
            else if(txtBoxOperacao.Text == "Inválido")
            txtBoxOperacao.Text = "Inválido";
            else
            {
                valor1 = double.Parse(txtBoxOperacao.Text);
                lblOperacao.Text = "√(" + valor1 + ")";
                resultado = valor1;
                txtBoxOperacao.Text = Math.Tanh(valor1).ToString();
            }
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            if (txtBoxOperacao.Text == "")
            {
                lblOperacao.Text = "π";
                txtBoxOperacao.Text = Math.PI.ToString();
            }
            else
            {
                valor1 = Math.PI;
                lblOperacao.Text = "π";
                resultado = valor1;
            }
        }

        private void btnXQuadrado_Click(object sender, EventArgs e)
        {
            if (txtBoxOperacao.Text == "")
            {
                txtBoxOperacao.Text = "Inválido";
            }
            else if (txtBoxOperacao.Text == "Inválido")
                txtBoxOperacao.Text = "Inválido";
            else
            {
                valor1 = double.Parse(txtBoxOperacao.Text);
                lblOperacao.Text = valor1 + "^²";
                resultado = valor1;
                txtBoxOperacao.Text = Math.Pow(valor1, 2).ToString();
            }
        }

        private void btnXCubo_Click(object sender, EventArgs e)
        {
            if (txtBoxOperacao.Text == "")
            {
                txtBoxOperacao.Text = "Inválido";
            }
            else if (txtBoxOperacao.Text == "Inválido")
                txtBoxOperacao.Text = "Inválido";
            else
            {
                valor1 = double.Parse(txtBoxOperacao.Text);
                lblOperacao.Text = valor1 + "^³";
                resultado = valor1;
                txtBoxOperacao.Text = Math.Pow(valor1, 3).ToString();
            }
        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            if (txtBoxOperacao.Text == "")
            {
                txtBoxOperacao.Text = "Inválido";
            }
            else if (txtBoxOperacao.Text == "Inválido")
                txtBoxOperacao.Text = "Inválido";
            else
            {
                valor1 = double.Parse(txtBoxOperacao.Text) / 100;
                lblOperacao.Text = txtBoxOperacao.Text + "%";
                resultado = valor1;
                txtBoxOperacao.Text = resultado.ToString();
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (txtBoxOperacao.Text == "")
            {
                txtBoxOperacao.Text = "Inválido";
            }
            else if (txtBoxOperacao.Text == "Inválido")
                txtBoxOperacao.Text = "Inválido";
            else
            {
                valor1 = double.Parse(txtBoxOperacao.Text);
                lblOperacao.Text = "in(" + valor1 + ")";
                resultado = valor1;
                txtBoxOperacao.Text = Math.Log(valor1).ToString();
            }
        }

        
        private void btn10Elevado_Click(object sender, EventArgs e)
        {
            if (txtBoxOperacao.Text == "")
            {
                txtBoxOperacao.Text = "Inválido";
            }
            else if (txtBoxOperacao.Text == "Inválido")
                txtBoxOperacao.Text = "Inválido";
            else
            {
                valor1 = double.Parse(txtBoxOperacao.Text);
                lblOperacao.Text = "10^(" + valor1 + ")";
                resultado = valor1;
                txtBoxOperacao.Text = Math.Pow(10, valor1).ToString();
            }
        }

        private void btnSinNeg_Click(object sender, EventArgs e)
        {
            if (txtBoxOperacao.Text == "")
            {
                txtBoxOperacao.Text = "Inválido";
            }
            else if (txtBoxOperacao.Text == "Inválido")
                txtBoxOperacao.Text = "Inválido";
            else
            {
                valor1 = double.Parse(txtBoxOperacao.Text);
                lblOperacao.Text = "sinˉ¹(" + valor1 + ")";
                resultado = valor1;
                txtBoxOperacao.Text = Math.Asin(valor1).ToString();
            }
        }

        private void btnCosNeg_Click(object sender, EventArgs e)
        {
            if (txtBoxOperacao.Text == "")
            {
                txtBoxOperacao.Text = "Inválido";
            }
            else if (txtBoxOperacao.Text == "Inválido")
                txtBoxOperacao.Text = "Inválido";
            else
            {
                valor1 = double.Parse(txtBoxOperacao.Text);
                lblOperacao.Text = "cosˉ¹(" + valor1 + ")";
                resultado = valor1;
                txtBoxOperacao.Text = Math.Acos(valor1).ToString();
            }
        }

        private void btnTagNeg_Click(object sender, EventArgs e)
        {
            if (txtBoxOperacao.Text == "")
            {
                txtBoxOperacao.Text = "Inválido";
            }
            else if (txtBoxOperacao.Text == "Inválido")
                txtBoxOperacao.Text = "Inválido";
            else
            {
                valor1 = double.Parse(txtBoxOperacao.Text);
                lblOperacao.Text = "tagˉ¹(" + valor1 + ")";
                resultado = valor1;
                txtBoxOperacao.Text = Math.Atan(valor1).ToString();
            }
        }
        private void btnLog_Click(object sender, EventArgs e)
        {
            if (txtBoxOperacao.Text == "")
            {
                txtBoxOperacao.Text = "Inválido";
            }
            else if (txtBoxOperacao.Text == "Inválido")
                txtBoxOperacao.Text = "Inválido";
            else
            {
                valor1 = double.Parse(txtBoxOperacao.Text);
                lblOperacao.Text = "log(" + valor1 + ")";
                resultado = valor1;
                txtBoxOperacao.Text = Math.Log10(valor1).ToString();
            }
        }
        
        private void btn1x_Click(object sender, EventArgs e)
        {
            if (txtBoxOperacao.Text == "")
            {
                txtBoxOperacao.Text = "Inválido";
            }
            else if (txtBoxOperacao.Text == "Inválido")
                txtBoxOperacao.Text = "Inválido";
            else
            {
                valor1 = double.Parse(txtBoxOperacao.Text);
                lblOperacao.Text = "1/" + valor1;
                resultado = valor1;
                txtBoxOperacao.Text = (1.0 / valor1).ToString();
            }
        }     
        
        private void btnMaisMenos_Click(object sender, EventArgs e)
        {
            double maismenos = double.Parse(txtBoxOperacao.Text);
            txtBoxOperacao.Text = (-1 * maismenos).ToString();
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            if (txtBoxOperacao.Text == "")
            {
                txtBoxOperacao.Text = "Inválido";
            }
            else if (txtBoxOperacao.Text == "Inválido")
                txtBoxOperacao.Text = "Inválido";
            else
            {
                operador = "exp";
                valor1 = double.Parse(txtBoxOperacao.Text);
                lblOperacao.Text = "exp(" + valor1 + ")";
                txtBoxOperacao.Clear();
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (txtBoxOperacao.Text == "")
            {
                txtBoxOperacao.Text = "Inválido";
            }
            else if (txtBoxOperacao.Text == "Inválido")
                txtBoxOperacao.Text = "Inválido";
            else
            {
                operador = "mod";
                valor1 = double.Parse(txtBoxOperacao.Text);
                lblOperacao.Text = "mod(" + valor1 + ")";
                txtBoxOperacao.Clear();
            }
        }
        
        private void btnMS_Click(object sender, EventArgs e)
        {
            memoria = double.Parse(txtBoxOperacao.Text);
            this.lblMemoria.Visible = true;
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            memoria = 0;
            this.lblMemoria.Visible = false;
        }

        private void btnMmais_Click(object sender, EventArgs e)
        {
            memoria = memoria + double.Parse(txtBoxOperacao.Text);
            this.lblMemoria.Visible = true;
        }

        private void btnMmenos_Click(object sender, EventArgs e)
        {
            memoria = memoria - double.Parse(txtBoxOperacao.Text);
            this.lblMemoria.Visible = true;
        }

        //Funcionalidades Básicas Secundárias e Terciárias
        private void btnOutros_Click(object sender, EventArgs e)
        {
            btnOutros.Visible = false;
            btnOutros1.Visible = true;
            btnSinNeg.Visible = true;
            btn10Elevado.Visible = true;
            btnCosNeg.Visible = true;
            btnTagNeg.Visible = true;
            btnXCubo.Visible = false;
            btnSin.Visible = false;
            btnCos.Visible = false;
            btnTag.Visible = false;
            btn1x.Visible = false;
            btnMod.Visible = true;
            btnMS.Visible = false;
            btnPorcentagem.Visible = true;
            btnMC.Visible = false;
            btnIn.Visible = true;
        }

        private void btnOutros1_Click(object sender, EventArgs e)
        {
            btnOutros1.Visible = false;
            btnOutros.Visible = true;
            btnSinNeg.Visible = false;
            btn10Elevado.Visible = false;
            btnCosNeg.Visible = false;
            btnTagNeg.Visible = false;
            btnXCubo.Visible = true;
            btnSin.Visible = true;
            btnCos.Visible = true;
            btnTag.Visible = true;
            btn1x.Visible = true;
            btnMod.Visible = false;
            btnMS.Visible = true;
            btnPorcentagem.Visible = false;
            btnMC.Visible = true;
            btnIn.Visible = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBoxOperacao.Text = "";
            txtBoxOperacao.PlaceholderText = "0";
            lblOperacao.Text = "";
            btnVirgula.Enabled = true;
        }

        private void btnLimparLinha_Click(object sender, EventArgs e)
        {
            txtBoxOperacao.Clear();
            btnVirgula.Enabled = true;
            
        }

        private void btnLimparUm_Click(object sender, EventArgs e)
        {

            if (txtBoxOperacao.TextLength > 1) 
            {
                txtBoxOperacao.Text = txtBoxOperacao.Text.Remove(txtBoxOperacao.Text.Length - 1, 1);

            }
            if (txtBoxOperacao.Text.Length == 1)
            {
                txtBoxOperacao.Text = "0";
                inicio = true;
            }
            if (txtBoxOperacao.Text.Contains(","))
            {
                btnVirgula.Enabled = false;
            }
            else 
            {
                btnVirgula.Enabled = true;
            }
        }

        private void btnParDIr_Click(object sender, EventArgs e)
        {
            txtBoxOperacao.Text += "(";
        }

        private void btnParEsq_Click(object sender, EventArgs e)
        {
            txtBoxOperacao.Text += ")";
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (txtBoxOperacao.Text == "")
            {
                txtBoxOperacao.Text = "0,";
            }
            else
            {
                txtBoxOperacao.Text =txtBoxOperacao.Text +  ",";
                btnVirgula.Enabled = false;
            }
            
        }       
       
    }
}

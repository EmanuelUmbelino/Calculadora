using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Calculadora : Form
    {
        Calculator calculator = new Calculator();
        CalculatorBin calculatorBin = new CalculatorBin();
        public Calculadora()
        {
            InitializeComponent();
        }
        public double negativando;
        public string pegar;
        public bool simbol = false;
        public bool somou = false;
        public bool algo = false;
        public bool batata = false;
        // add caracteres
        private void Add(object sender, EventArgs e)
        {
            Button clicked = sender as Button;
            // verificar se tem algum digito escrito na tela
            algo = true;
            // usos da virgula
            if (clicked.Text.Equals(",") && !somou && !simbol)
            {
                if (Result.Text.IndexOf(",") != -1) Result.Text = Result.Text;
                else Result.Text += clicked.Text;
            }
            else if (clicked.Text.Equals(",") || clicked.Text.Equals(",") && simbol)
            {
                Result.Text = "0,";
                somou = false;
                simbol = false;
            }
            // respectivamente: testando se vai colocar o primeiro digito; colocando mais um digito; negando o zero;
            if (simbol && clicked.Text != "," || somou && clicked.Text != ",") { Result.Text = clicked.Text; simbol = false; somou = false; }
            else if (Result.Text != "0" && clicked.Text != ",") Result.Text += clicked.Text;
            else if (clicked.Text != ",") Result.Text = clicked.Text;
        }
        // reiniciar tudo
        private void Reset(object sender, EventArgs e)
        {
            Result.Text = "0";
            calculator.simbolinho = null;
            calculator.valor = 0;
            calculator.valor2 = 0;
            calculator.total = 0;
            simbol = false;
            algo = false;
        }
        // executar a conta
        private void Total(object sender, EventArgs e)
        {
            // testar se existe algum simbolo ativado
            if (calculator.simbolinho != null)
            {
                // pegar o valor escrito
                calculator.sl = Convert.ToDouble(Result.Text);
                // usar a funçao da conta
                calculator.calcular();
                // digitar o total
                Result.Text = calculator.total.ToString();
                // pegar o valor escrito
                calculator.sl = Convert.ToDouble(Result.Text);
                // definir que valor sera o valor escrito
                calculator.valor = calculator.sl;
                // zerador
                calculator.simbolinho = null;
                batata = true;
                somou = true;
            }
        }
        // escolher a conta
        private void Add_simbolos(object sender, EventArgs e)
        {
            Button clicked = sender as Button;
            // ver se algo foi digitado
            if (algo) calculator.sl = Convert.ToDouble(Result.Text);
            if (batata && algo) { calculator.valor = calculator.sl; batata = false; }
            // caso aperte um botao de sinal ja tendo definido uma conta anterior
            if (calculator.simbolinho != null)
            {
                // mesmo que no total exceto por colocar o simbolo clicado para a prox conta
                calculator.calcular();
                Result.Text = calculator.total.ToString();
                calculator.sl = Convert.ToDouble(Result.Text);
                calculator.valor = calculator.sl;
                calculator.simbolinho = clicked.Text;
                somou = true;
            }
            // criar o simbolo
            if (calculator.simbolinho == null && algo) calculator.simbolinho = clicked.Text;
            // pegar segundo valor ou primeiro valor
            if (calculator.valor != 0)calculator.valor2 = calculator.sl;
            else calculator.valor = calculator.sl;
            // contas que sao executadas na h que clicadas no simbolo
            if (algo && calculator.simbolinho.Equals("√") || algo && calculator.simbolinho.Equals("Sen") || algo && calculator.simbolinho.Equals("Cos") ||
                algo && calculator.simbolinho.Equals("Tg") || algo && calculator.simbolinho.Equals("! In") || algo && calculator.simbolinho.Equals("! Re") ||
                algo && calculator.simbolinho.Equals("Fi In") || algo && calculator.simbolinho.Equals("Fi Re") || algo && calculator.simbolinho.Equals("ConvertToBin"))

            {
                calculator.calcular();
                Result.Text = calculator.total.ToString();
                calculator.sl = Convert.ToDouble(Result.Text);
                calculator.valor = calculator.sl;
                calculator.simbolinho = null;
                somou = true;
            }
            simbol = true;
        }
        // verifica se o valor digitado e um numero
        private void Aprovador(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) || e.KeyChar == 8)
                e.Handled = true;
        }
        // inverter sinal
        private void Negativar(object sender, EventArgs e)
        {
            negativando = Convert.ToDouble(Result.Text) * -1;
            Result.Text = negativando.ToString();
        }
        // deletar caracter final
        private void Backspace(object sender, EventArgs e)
        {
            Result.Text = Result.Text.Remove(Result.Text.Length- 1);
            if (Result.Text == "") Result.Text = "0";
        }

        private void AddBin(object sender, EventArgs e)
        {
            Button clicked = sender as Button;
            // verificar se tem algum digito escrito na tela
            algo = true;
            // respectivamente: testando se vai colocar o primeiro digito; colocando mais um digito; negando o zero;
            if (simbol && clicked.Text != "," || somou && clicked.Text != ",") { ResultBin.Text = clicked.Text; simbol = false; somou = false; }
            else if (ResultBin.Text != "0" && clicked.Text != ",") ResultBin.Text += clicked.Text;
            else if (clicked.Text != ",") ResultBin.Text = clicked.Text;
        }

        private void ResetBin(object sender, EventArgs e)
        {
            ResultBin.Text = "0";
            calculatorBin.simbolinho = null;
            calculatorBin.valor = 0;
            calculatorBin.valor2 = 0;
            calculatorBin.total = 0;
            simbol = false;
            algo = false;

        }

        private void BackspaceBin(object sender, EventArgs e)
        {
            ResultBin.Text = ResultBin.Text.Remove(ResultBin.Text.Length - 1);
            if (ResultBin.Text == "") ResultBin.Text = "0";
        }

        private void Add_simbolosBin(object sender, EventArgs e)
        {
            Button clicked = sender as Button;
            // ver se algo foi digitado
            if (algo) calculatorBin.sl = Convert.ToDouble(ResultBin.Text);
            if (batata && algo) { calculatorBin.valor = calculatorBin.sl; batata = false; }
            // caso aperte um botao de sinal ja tendo definido uma conta anterior
            if (calculatorBin.simbolinho != null)
            {
                // mesmo que no total exceto por colocar o simbolo clicado para a prox conta
                calculatorBin.calcular();
                ResultBin.Text = calculatorBin.total.ToString();
                calculatorBin.sl = Convert.ToDouble(ResultBin.Text);
                calculatorBin.valor = calculator.sl;
                calculatorBin.simbolinho = clicked.Text;
                somou = true;
            }
            // criar o simbolo
            if (calculatorBin.simbolinho == null && algo) calculatorBin.simbolinho = clicked.Text;
            // pegar segundo valor ou primeiro valor
            if (calculatorBin.valor != 0) calculatorBin.valor2 = calculatorBin.sl;
            else calculatorBin.valor = calculatorBin.sl;
            if (algo && calculatorBin.simbolinho.Equals("ConvertToDec"))
            {
                calculatorBin.calcular();
                ResultBin.Text = calculatorBin.total.ToString();
                calculatorBin.sl = Convert.ToDouble(ResultBin.Text);
                calculatorBin.valor = calculatorBin.sl;
                calculatorBin.simbolinho = null;
                somou = true;
            }
            simbol = true;
        }

        private void TotalBin(object sender, EventArgs e)
        {
            // testar se existe algum simbolo ativado
            if (calculatorBin.simbolinho != null)
            {
                // pegar o valor escrito
                calculatorBin.sl = Convert.ToDouble(ResultBin.Text);
                // usar a funçao da conta
                calculator.calcular();
                // digitar o total
                ResultBin.Text = calculatorBin.total.ToString();
                // pegar o valor escrito
                calculatorBin.sl = Convert.ToDouble(ResultBin.Text);
                // definir que valor sera o valor escrito
                calculatorBin.valor = calculatorBin.sl;
                // zerador
                calculatorBin.simbolinho = null;
                batata = true;
                somou = true;
            }

        }
    }
}

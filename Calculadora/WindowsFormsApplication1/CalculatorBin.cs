using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class CalculatorBin
    {
        public double sl;
        public string simbolinho;
        public double valor = 0;
        public double valor2 = 0;
        public double total = 0;
        //funcao para converter para binario
        private double bin(double valor)
        {
            string medido = valor.ToString();
            double result = 0;
            for (int i = 0; i < medido.Length; i++)
            {
                result = result * 2 + Convert.ToDouble(medido[i].ToString());
            }
            return result;
        }
        // funcao para calcular
        public void calcular()
        {
            // pegar o valor atual
            valor2 = sl;
            // executar as contas no "total"
            switch (simbolinho)
            {
                case "-":
                    total = valor - valor2;
                    break;
                case "+":
                    total = valor + valor2;
                    break;
                case "ConvertToDec":
                    total = bin(valor);
                    break;
            }
        }
    }
}

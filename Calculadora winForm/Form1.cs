using System.Linq.Expressions;

namespace Calculadora_winForm
{
    public partial class Form1 : Form
    {
        public decimal Valor1 { get; set; }
        public decimal Resultado { get; set; }
        private Operacao TipoOperacao { get; set; }

        private enum Operacao
        {
            adicao,
            subtacao,
            multiplicacao,
            divisao,
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text +="4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";  
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            TipoOperacao = Operacao.adicao;
            Valor1 = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
        }

    private void btnMenos_Click(object sender, EventArgs e)
        {
            TipoOperacao = Operacao.subtacao;
            Valor1 = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
        }

        private void btnVezes_Click(object sender, EventArgs e)
        {
            TipoOperacao = Operacao.multiplicacao;
            Valor1 = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            TipoOperacao = Operacao.divisao;
            Valor1 = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch  (TipoOperacao)
            {
                case Operacao.adicao:
                    Resultado = Valor1 + Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.subtacao:
                    Resultado = Valor1 - Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.multiplicacao:
                    Resultado = Valor1 * Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.divisao:
                    Resultado = Valor1 / Convert.ToDecimal(txtResultado.Text);
                    break;
            }
            txtResultado.Text = Convert.ToString(Resultado);
        }

        private void btnponto_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(","))
            txtResultado.Text += ",";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
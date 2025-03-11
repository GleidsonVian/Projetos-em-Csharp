namespace CalculadoraInterfaceGrafica
{
    public partial class Form1 : Form

    {
        double primeiroValor = 0;
        string operacao = "";

        public Form1()
        {

            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            txtVisor.Text += botao.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            txtVisor.Text += botao.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            txtVisor.Text += botao.Text;

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            txtVisor.Text += botao.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            txtVisor.Text += botao.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            txtVisor.Text += botao.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            txtVisor.Text += botao.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            txtVisor.Text += botao.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            txtVisor.Text += botao.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            txtVisor.Text += botao.Text;

        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            primeiroValor = double.Parse(txtVisor.Text);
            operacao = botao.Text;
            txtVisor.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            double segundoValor = double.Parse(txtVisor.Text);
            double resultado = 0;

            switch (operacao)
            {
                case "+":
                    resultado = primeiroValor + segundoValor;
                    break;
                case "-":
                    resultado = primeiroValor - segundoValor;
                    break;
                case "*":
                    resultado = primeiroValor * segundoValor;
                    break;
                case "/":
                    resultado = primeiroValor / segundoValor;
                    break;
            }

            txtVisor.Text = resultado.ToString();
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            primeiroValor = double.Parse(txtVisor.Text);
            operacao = botao.Text;
            txtVisor.Text = "";

        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            primeiroValor = double.Parse(txtVisor.Text);
            operacao = botao.Text;
            txtVisor.Text = "";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            primeiroValor = double.Parse(txtVisor.Text);
            operacao = botao.Text;
            txtVisor.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtVisor.Text = "";
            primeiroValor = 0;
            operacao = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

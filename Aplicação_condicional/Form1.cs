namespace Aplicação_condicional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            txtX.Clear();
            txtY.Clear();

            rdbSomar.Checked = true;
            txtX.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //declaração das variáveis
            double x, y, total;

            //entrada de dados
            //validação de dados

            //verifica se o que foi digitado em txtX é número. Também faz validação se o txtX está vazio.
            if (double.TryParse(txtX.Text, out x) == false)
            {
                //adiciona o botão Ok e o ícone de Informação no MessageBox
                MessageBox.Show("Informe um valor válido", "Calculadora", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtX.Clear();   // limpa o texto do TextBox
                txtX.Focus();  //coloca o foco do cursor no TextBox
                return;  //sai da sub-rotina, não executa o código que está abaixo
            }

            //verifica se o que foi digitado em txty é número. Também faz validação se o txtX está vazio.
            if (double.TryParse(txtY.Text, out y) == false)
            {
                MessageBox.Show("Informe um valor válido", "Calculadora", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtY.Clear();   // limpa o texto do TextBox
                txtY.Focus();  //coloca o foco do cursor no TextBox
                return;  //sai da sub-rotina, não executa o código que está abaixo
            }

            //processamento
            //Testa na estrutura condicional qual RadioButton está selecionado

            if (rdbSomar.Checked == true)
            {
                total = x + y;
            }

            else if (rdbSubtrair.Checked)
            {
                total = x - y;
            }
            else if (rdbMultiplicar.Checked)
            {
                total = x * y;
            }
            else
            {
                //verifica se está sendo realizada divisão por zero
                if (y == 0)
                {
                    txtTotal.Text = "Divisão por zero";
                    return;     //sai da sub-rotina, não executa o código que está abaixo 
                }

                total = x / y;
            }

            //apresenta a saída de dados convertendo para String

            txtTotal.Text = total.ToString();
        }
    }
}
namespace lists
{
    public partial class Form1 : Form
    {
        //Criação da Lista Global
        public static List<String> nomes = new List<String>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            nomes.Add(txtNome.Text);

            AtualizarNomes();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            nomes.Remove(txtNome.Text);

            AtualizarNomes();
        }

        private void AtualizarNomes()
        {
            txtNome.Clear();
            txtLista.Clear();

            foreach (string nome in nomes)
            {
                txtLista.AppendText(nome + Environment.NewLine);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int idx = nomes.IndexOf(txtNome.Text);

            if (idx > -1)
            {
                nomes[idx] = txtNovoNome.Text;

                txtNovoNome.Clear();
            }

            AtualizarNomes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nomes.Sort();
            AtualizarNomes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nomes.Reverse();
            AtualizarNomes();
        }
    }
}
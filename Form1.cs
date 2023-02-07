namespace MenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SairApp_Click(object sender, EventArgs e)
        {
            //sair do aplicativo
            Application.Exit();
        }

        private void Menu_Click(object sender, EventArgs e)
        {

        }

        private void CadsUser_Click(object sender, EventArgs e)
        {
            //quando clicar, esse procedimento vai trazer um novo formulário
            Form cadastro_usuario = new FormularioUsuário();
            cadastro_usuario.ShowDialog();
        }
    }
}
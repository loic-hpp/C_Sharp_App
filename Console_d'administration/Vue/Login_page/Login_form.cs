namespace login_form
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void boutonFermer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void boutonConnecter_Click(object sender, EventArgs e)
        {
            bool aAcces = Controleur.Login.identifiantValide(this.champNomUtilisateur.Text, this.champMotDePasse.Text);
            if (aAcces) {
                this.Hide();
                Form accueilForm = new Console_d_administration.Vue.Accueil.Accueil();
                accueilForm.Closed += (s, args) => this.Close();
                accueilForm.Show();


            }
        }
    }
}
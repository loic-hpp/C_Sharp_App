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
            bool aAcces = Controleur.Login.aAcces(this.champNomUtilisateur.Text, this.champMotDePasse.Text);
            if (aAcces)
            {
                this.Hide();
                Form accueilForm = new Console_d_administration.Vue.Accueil.Accueil();
                accueilForm.Closed += (s, args) => Application.Exit();
                accueilForm.Show();
            }
            else if (!Controleur.Login.identifiantValide(this.champNomUtilisateur.Text, this.champMotDePasse.Text))
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect");
            else
                MessageBox.Show("Vous n'avez pas d'accès administrateur");

        }
    }
}
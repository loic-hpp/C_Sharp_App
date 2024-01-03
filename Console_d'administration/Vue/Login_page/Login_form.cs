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
                //Application.Exit();

                var accueilForm = new Console_d_administration.Vue.Accueil.Accueil();
                accueilForm.ShowDialog();

                //Application.Run(new Console_d_administration.Vue.Accueil.Accueil());

            }
        }
    }
}
namespace Controleur
{
    class Login
    {
        public static bool aAcces(string nomUtilisateur, string motDePasse)
        {
            return identifiantValide(nomUtilisateur, motDePasse) && estAdmin(nomUtilisateur);
        }
        public static bool identifiantValide(string nomUtilisateur, string motDePasse)
        {
            return true;
        }

        public static bool estAdmin(string nomUtilisateur)
        {
            return true;
        }

    }
}
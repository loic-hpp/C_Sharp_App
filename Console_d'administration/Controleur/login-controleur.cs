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
            return Modele.Login.identifiantValide(nomUtilisateur, motDePasse);
        }

        public static bool estAdmin(string nomUtilisateur)
        {
            return Modele.Login.estAdmin(nomUtilisateur); ;
        }

    }
}
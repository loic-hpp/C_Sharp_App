using System.Collections.ObjectModel;
using System.Management.Automation;
namespace Modele
{
    class Login
    {
        public static bool identifiantValide(string nomUtilisateur, string motDePasse)
        {
            try
            {
                using (PowerShell PowerShellInstance = PowerShell.Create())
                {
                    var script = File.ReadAllText("C:\\Users\\loicn\\Local_doc\\C_Sharp_App\\Console_d'administration\\Modèle\\Scripts\\login-script.ps1");
                    PowerShellInstance.AddScript(script);

                    PowerShellInstance.AddParameter("UserName", nomUtilisateur);
                    PowerShellInstance.AddParameter("Password", motDePasse);

                    Collection<PSObject> PSOutput = PowerShellInstance.Invoke();

                    foreach (PSObject outputItem in PSOutput)
                    {
                        string result = outputItem.ToString();
                        result = result.Split("=")[1];
                        MessageBox.Show(result);
                        //if (resultPropertyValue != null)
                        //    result = resultPropertyValue.ToString();
                        return result == "Valid";

                    }

                    // Vérifier les erreurs
                    if (PowerShellInstance.HadErrors)
                    {
                        foreach (ErrorRecord error in PowerShellInstance.Streams.Error)
                        {
                            // Afficher les erreurs à l'écran seulement en mode debug
                            //MessageBox.Show(error.Exception.Message);
                        }
                    }

                    return false;
                }

            }
            catch (Exception error)
            {
                //MessageBox.Show(error.Message);
                return false;
            }
        }
        public static bool estAdmin(string nomUtilisateur)
        {
            return true;
        }

    }
}
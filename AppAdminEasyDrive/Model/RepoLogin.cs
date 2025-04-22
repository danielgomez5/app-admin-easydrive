using APIProjecte.Models;
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AppAdminEasyDrive.Model
{
    public class RepoLogin
    {
        public RepoLogin()
        {
        }

        public Usuari LoginUsuari(string email, string password)
        {
            Usuari usuari = null;
            try
            {
                LoginRequest login = new LoginRequest { Email = email, Password = password };
                usuari = (Usuari)Repositori.MakeRequest("usuari_login", "POST", login, typeof(Usuari)).Result;
            }
            catch (Exception ex)
            {
            }

            return usuari;
        }

        public void ChangePassword(ChangePasswordRequest pass)
        {
            try
            {
                var result = Repositori.MakeRequest("usuari/canvi-contrasenya", "PUT", pass, typeof(string));

            }
            catch (Exception ex)
            {
            }
        }
    }
}

using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}

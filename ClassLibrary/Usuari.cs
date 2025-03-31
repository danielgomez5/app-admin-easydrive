using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public partial class Usuari
    {
        public string Dni { get; set; } = null;

        public string Nom { get; set; } = null;

        public string Cognom { get; set; } = null;

        public string Email { get; set; } = null;

        public string Telefon { get; set; } = null;

        public DateTime DataNaixement { get; set; }

        public string PasswordHash { get; set; } = null;

        public byte[] FotoPerfil { get; set; }

        public byte[] FotoCarnet { get; set; }

        public bool? Rol { get; set; }

        public DateTime? Horari { get; set; }

        public bool? Disponibilitat { get; set; }

        public int? IdZona { get; set; }

    }
}
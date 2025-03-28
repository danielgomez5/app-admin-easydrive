using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAdminEasyDrive.Model
{
    public partial class DadesPagament
    {
        public int Id { get; set; }

        public string NumeroTarjeta { get; set; }

        public string Titular { get; set; }

        public DateTime DataExpiracio { get; set; }

        public string IdUsuari { get; set; }
    }
}

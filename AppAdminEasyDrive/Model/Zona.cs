using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAdminEasyDrive.Model
{
    public partial class Zona
    {
        public int Id { get; set; }

        public string ComunitatA { get; set; }

        public string Ciutat { get; set; }

        public string Provincia { get; set; }

        public string Pais { get; set; }

        public bool? Estat { get; set; }
    }
}

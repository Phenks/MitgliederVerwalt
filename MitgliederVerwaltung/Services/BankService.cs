using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitgliederVerwaltung.Services
{
    class BankService
    {
        private static BankService _instanz;
        public static BankService Instanz
        {
            get { return _instanz ?? (_instanz = new BankService()); }
        }
    }
}

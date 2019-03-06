using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitgliederVerwaltung.Services
{
    class SimulationsService
    {
        private static SimulationsService _instanz;
        public static SimulationsService Instanz
        {
            get { return _instanz ?? (_instanz = new SimulationsService()); }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitgliederVerwaltung.Services
{
    class SimulationsService
    {
        private const int TagAnWelchemMitgliedsbeitraegeEingezogenWerden  = 1;

        private static SimulationsService _instanz;
        public static SimulationsService Instanz
        {
            get { return _instanz ?? (_instanz = new SimulationsService()); }
        }

        public DateTime MomentanesDatum { get; set; } = DateTime.Today;

        /// <summary>
        /// Simuliert x Tage
        /// </summary>
        /// <param name="anzahlTage"></param>
        /// <returns>Der Tag nachdem die Simulation beendet wurde</returns>
        public DateTime SimuliereTage(int anzahlTage)
        {
            for (int i = 1; i <= anzahlTage; i++)
            {
                SimuliereTag(MomentanesDatum.AddDays(i));
            }

            MomentanesDatum = MomentanesDatum.AddDays(anzahlTage);
            return MomentanesDatum;
        }

        private void SimuliereTag(DateTime tag)
        {
            if (tag.Day == TagAnWelchemMitgliedsbeitraegeEingezogenWerden)
            {
            }
            SimuliereZufallsereignisse();
            
        }

        private void SimuliereZufallsereignisse()
        {
            
        }
    }

}

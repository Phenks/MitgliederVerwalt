using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MitgliederVerwaltung.Basis;
using MitgliederVerwaltung.Objekte;

namespace MitgliederVerwaltung.Services
{
    public class MitgliederService
    {
        public MitgliederService()
        {
            
        }

        public List<Mitglied> ErhalteAlleMitglieder()
        {
            var mitglieder = new List<Mitglied>();


            mitglieder.Add(
                 new Mitglied("Peter", "Oetker", new DateTime(2000, 1, 1),
                    new Anschrift("49124", "Hütte", "Steinstraße", "42"), Konstanten.Erwerbstaetigkeiten.Student,
                    new Konto(1458.42f), "peter.oetker@gmail.com")
                );



            return mitglieder;

        }


    }
}

using System;
using System.Collections.Generic;
using MitgliederVerwaltung.Basis;
using MitgliederVerwaltung.Objekte;

namespace MitgliederVerwaltung.Services
{
    public class MitgliederService
    {
        private static MitgliederService _instanz;

        public static MitgliederService Instanz
        {
            get { return _instanz ?? (_instanz = new MitgliederService()); }
        }

        public List<Mitglied> Mitglieder { get; }

        private MitgliederService()
        {
            Mitglieder = new List<Mitglied>();
            InitialisiereMitglieder();
        }


        public void FuegeMitgliedHinzu(Mitglied mitglied)
        {
            Mitglieder.Add(mitglied);
        }

        private void InitialisiereMitglieder()
        {
            Random random = new Random(42);

            Mitglieder.Add(
                new Mitglied("Peter", "Oetker", new DateTime(2000, 1, 1),
                    new Anschrift("49124", "Hütte", "Steinstraße", "42"), Konstanten.Erwerbstaetigkeiten.Student,
                    new Konto(random.Next(25, 13000)), "peter.oetker@gmail.com")
            );

            Mitglieder.Add(
                new Mitglied("Jonas ", "Herz", new DateTime(1999, 5, 24),
                    new Anschrift("82243", "Fürstenfeldbruck", "Prager Str", "14"),
                    Konstanten.Erwerbstaetigkeiten.Student,
                    new Konto(random.Next(25, 13000)), "JonasHerz@cuvox.de")
            );
        }
    }
}
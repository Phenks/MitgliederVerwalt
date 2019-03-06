using System;
using System.Collections.Generic;
using System.Linq;
using MitgliederVerwaltung.Basis;
using MitgliederVerwaltung.Objekte;

namespace MitgliederVerwaltung.Services
{
    public class MitgliederService
    {
        public delegate  void MitgliedHinzugefuegtEventHandler();

        public event MitgliedHinzugefuegtEventHandler MitgliederUpdated;

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
            OnMitgliederUpdated();
        }

        private void OnMitgliederUpdated()
        {
            MitgliederUpdated?.Invoke();
        }

        public void AktualisiereMitglied(Mitglied mitglied)
        {
            for (int i = 0; i < Mitglieder.Count; i++)
            {
                if (Mitglieder[i].MitgliedId == mitglied.MitgliedId)
                {
                    Mitglieder[i] = mitglied;
                }
            }

            OnMitgliederUpdated();
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

    public class MitgliedEventArgs : EventArgs
    {
        public Mitglied Mitglied { get; set; }

        public MitgliedEventArgs(Mitglied mitglied)
        {
            Mitglied = mitglied;
        }
    }

}
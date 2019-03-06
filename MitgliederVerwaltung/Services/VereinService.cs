using System;
using System.Collections.Generic;
using MitgliederVerwaltung.Basis;
using MitgliederVerwaltung.Objekte;

namespace MitgliederVerwaltung.Services
{
    public class VereinService
    {
        public delegate void MitgliedHinzugefuegtEventHandler();

        private static VereinService _instanz;

        private readonly Verein _verein;

        public static VereinService Instanz
        {
            get { return _instanz ?? (_instanz = new VereinService()); }
        }

        private VereinService()
        {
            _verein = new Verein();
            InitialisiereMitglieder();
        }

        public void AktualisiereMitglied(Mitglied mitglied)
        {
            for (var i = 0; i < _verein.Mitglieder.Count; i++)
                if (_verein.Mitglieder[i].MitgliedId == mitglied.MitgliedId)
                    _verein.Mitglieder[i] = mitglied;

            OnMitgliederUpdated();
        }

        public List<Mitglied> ErhalteMitglieder()
        {
            return _verein.Mitglieder;
        }

        public void FuegeMitgliedHinzu(Mitglied mitglied)
        {
            _verein.Mitglieder.Add(mitglied);
            OnMitgliederUpdated();
        }

        private void InitialisiereMitglieder()
        {
            Random random = new Random(42);

            var initialeMitglieder = new List<Mitglied>
            {
                new Mitglied("Peter", "Oetker", new DateTime(2000, 1, 1),
                    new Anschrift("49124", "Hütte", "Steinstraße", "42"), Konstanten.Erwerbstaetigkeiten.Student,
                    new Konto(random.Next(25, 13000)), "peter.oetker@gmail.com"),

                new Mitglied("Jonas ", "Herz", new DateTime(1999, 5, 24),
                    new Anschrift("82243", "Fürstenfeldbruck", "Prager Str", "14"),
                    Konstanten.Erwerbstaetigkeiten.Student,
                    new Konto(random.Next(25, 13000)), "JonasHerz@cuvox.de"),

                new Mitglied("Luca", "Pfeifer", new DateTime(1975, 1, 29),
                    new Anschrift("01737", "Braunsdorf", "Oldesloer Straße", "7"),
                    Konstanten.Erwerbstaetigkeiten.Arbeitslos,
                    new Konto(random.Next(25, 13000)), "LucasPfeifer@einrot.com"),

                new Mitglied("Sara", "Kunze", new DateTime(1950, 2, 22),
                    new Anschrift("86704", "Tagmersheim", "Alsterkrugchaussee", "34"),
                    Konstanten.Erwerbstaetigkeiten.Rentner,
                    new Konto(random.Next(25, 13000)), "SaraKunze@jourrapide.com"),

                new Mitglied("Philipp", "Beich", new DateTime(1938, 1, 8),
                    new Anschrift("12159", "Berlin Friedenau", "Leopoldstraße", "50"),
                    Konstanten.Erwerbstaetigkeiten.Rentner,
                    new Konto(random.Next(25, 13000)), "PhilippBeich@teleworm.us"),

                new Mitglied("Nicole", "Egger", new DateTime(1985, 3, 18),
                    new Anschrift("57612", "Ölsen", "Gotzkowskystrasse", "27"),
                    Konstanten.Erwerbstaetigkeiten.Berufstaetig,
                    new Konto(random.Next(25, 13000)), "NicoleEgger@teleworm.us"),

                new Mitglied("Anne", "Hertz", new DateTime(1954, 1, 1),
                    new Anschrift("55471", "Keidelheim", "Joachimstaler Str", "23"),
                    Konstanten.Erwerbstaetigkeiten.Berufstaetig,
                    new Konto(random.Next(25, 13000)), "AnneHertz@jourrapide.com"),

                new Mitglied("Marco", "Grunwald", new DateTime(1979, 6, 4),
                    new Anschrift("86654", "Harburg", "Marseiller Str", "30"),
                    Konstanten.Erwerbstaetigkeiten.Berufstaetig,
                    new Konto(random.Next(25, 13000)), "MarcoGrunwald@rhyta.com"),

                new Mitglied("Klaudia", "Ackerman", new DateTime(1997, 4, 23),
                    new Anschrift("54346", "Mehring", "Güntzelstrasse", "42"),
                    Konstanten.Erwerbstaetigkeiten.Student,
                    new Konto(random.Next(25, 13000)), "KlaudiaAckerman@jourrapide.com"),

                new Mitglied("Andreas", "Busch", new DateTime(1987, 12, 30),
                    new Anschrift("95463", "Bindlach", "Ellmenreichstrasse", "75"),
                    Konstanten.Erwerbstaetigkeiten.Arbeitslos,
                    new Konto(random.Next(25, 13000)), "AndreasBusch@rhyta.com"),

                new Mitglied("Susanne", "Ackermann", new DateTime(2002, 5, 9),
                    new Anschrift("82541", "Münsing", "Schillerstrasse", "81"),
                    Konstanten.Erwerbstaetigkeiten.Schueler,
                    new Konto(random.Next(25, 13000)), "SusanneAckermann@teleworm.us"),

                new Mitglied("Dirk", "Ziegler", new DateTime(1953, 2, 12),
                    new Anschrift("94113", "Tiefenbach", "Hoheluftchaussee", "5"),
                    Konstanten.Erwerbstaetigkeiten.Berufstaetig,
                    new Konto(random.Next(25, 13000)), "DirkZiegler@teleworm.us"),

                new Mitglied("Janina", "Blau", new DateTime(1973, 4, 5),
                    new Anschrift("92402", "Schwandorf", "Schaarsteinweg", "69"),
                    Konstanten.Erwerbstaetigkeiten.Berufstaetig,
                    new Konto(random.Next(25, 13000)), "JaninaBlau@jourrapide.com"),

                new Mitglied("Leonie", "Dreher", new DateTime(1987, 7, 8),
                    new Anschrift("51429", "Bergisch Gladbach Bensberg", "Lietzenburger Strasse", "26"),
                    Konstanten.Erwerbstaetigkeiten.Berufstaetig,
                    new Konto(random.Next(25, 13000)), "LeonieDreher@armyspy.com"),

                new Mitglied("Lisa", "Ziegler", new DateTime(1963, 10, 29),
                    new Anschrift("04023", "Leipzig", "Prenzlauer Allee", "9"),
                    Konstanten.Erwerbstaetigkeiten.Arbeitslos,
                    new Konto(random.Next(25, 13000)), "LisaZiegler@rhyta.com")
            };

            _verein.Mitglieder = initialeMitglieder;
        }

        private void OnMitgliederUpdated()
        {
            MitgliederUpdated?.Invoke();
        }

        public event MitgliedHinzugefuegtEventHandler MitgliederUpdated;
    }


}
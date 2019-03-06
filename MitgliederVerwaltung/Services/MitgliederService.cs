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

            Mitglieder.Add(
                new Mitglied("Luca", "Pfeifer", new DateTime(1975, 1, 29),
                    new Anschrift("01737", "Braunsdorf", "Oldesloer Straße", "7"),
                    Konstanten.Erwerbstaetigkeiten.Arbeitslos,
                    new Konto(random.Next(25, 13000)), "LucasPfeifer@einrot.com")
            );

            Mitglieder.Add(
                new Mitglied("Sara", "Kunze", new DateTime(1950, 2, 22),
                    new Anschrift("86704", "Tagmersheim", "Alsterkrugchaussee", "34"),
                    Konstanten.Erwerbstaetigkeiten.Rentner,
                    new Konto(random.Next(25, 13000)), "SaraKunze@jourrapide.com")
            );

            Mitglieder.Add(
                new Mitglied("Philipp", "Beich", new DateTime(1938, 1, 8),
                    new Anschrift("12159", "Berlin Friedenau", "Leopoldstraße", "50"),
                    Konstanten.Erwerbstaetigkeiten.Rentner,
                    new Konto(random.Next(25, 13000)), "PhilippBeich@teleworm.us")
            );

            Mitglieder.Add(
                new Mitglied("Nicole", "Egger", new DateTime(1985, 3, 18),
                    new Anschrift("57612", "Ölsen", "Gotzkowskystrasse", "27"),
                    Konstanten.Erwerbstaetigkeiten.Berufstaetig,
                    new Konto(random.Next(25, 13000)), "NicoleEgger@teleworm.us")
            );

            Mitglieder.Add(
                new Mitglied("Anne", "Hertz", new DateTime(1954, 1, 1),
                    new Anschrift("55471", "Keidelheim", "Joachimstaler Str", "23"),
                    Konstanten.Erwerbstaetigkeiten.Berufstaetig,
                    new Konto(random.Next(25, 13000)), "AnneHertz@jourrapide.com")
            );

            Mitglieder.Add(
                new Mitglied("Marco", "Grunwald", new DateTime(1979, 6, 4),
                    new Anschrift("86654", "Harburg", "Marseiller Str", "30"),
                    Konstanten.Erwerbstaetigkeiten.Berufstaetig,
                    new Konto(random.Next(25, 13000)), "MarcoGrunwald@rhyta.com")
            );

            Mitglieder.Add(
                new Mitglied("Klaudia", "Ackerman", new DateTime(1997, 4, 23),
                    new Anschrift("54346", "Mehring", "Güntzelstrasse", "42"),
                    Konstanten.Erwerbstaetigkeiten.Student,
                    new Konto(random.Next(25, 13000)), "KlaudiaAckerman@jourrapide.com")
            );

            Mitglieder.Add(
                new Mitglied("Andreas", "Busch", new DateTime(1987, 12, 30),
                    new Anschrift("95463", "Bindlach", "Ellmenreichstrasse", "75"),
                    Konstanten.Erwerbstaetigkeiten.Arbeitslos,
                    new Konto(random.Next(25, 13000)), "AndreasBusch@rhyta.com")
            );

            Mitglieder.Add(
                new Mitglied("Susanne", "Ackermann", new DateTime(2002, 5, 9),
                    new Anschrift("82541", "Münsing", "Schillerstrasse", "81"),
                    Konstanten.Erwerbstaetigkeiten.Schueler,
                    new Konto(random.Next(25, 13000)), "SusanneAckermann@teleworm.us")
            );

            Mitglieder.Add(
                new Mitglied("Dirk", "Ziegler", new DateTime(1953, 2, 12),
                    new Anschrift("94113", "Tiefenbach", "Hoheluftchaussee", "5"),
                    Konstanten.Erwerbstaetigkeiten.Berufstaetig,
                    new Konto(random.Next(25, 13000)), "DirkZiegler@teleworm.us")
            );

            Mitglieder.Add(
                new Mitglied("Janina", "Blau", new DateTime(1973, 4, 5),
                    new Anschrift("92402", "Schwandorf", "Schaarsteinweg", "69"),
                    Konstanten.Erwerbstaetigkeiten.Berufstaetig,
                    new Konto(random.Next(25, 13000)), "JaninaBlau@jourrapide.com")
            );

            Mitglieder.Add(
                new Mitglied("Leonie", "Dreher", new DateTime(1987, 7, 8),
                    new Anschrift("51429", "Bergisch Gladbach Bensberg", "Lietzenburger Strasse", "26"),
                    Konstanten.Erwerbstaetigkeiten.Berufstaetig,
                    new Konto(random.Next(25, 13000)), "LeonieDreher@armyspy.com")
            );

            Mitglieder.Add(
                new Mitglied("Lisa", "Ziegler", new DateTime(1963, 10, 29),
                    new Anschrift("04023", "Leipzig", "Prenzlauer Allee", "9"),
                    Konstanten.Erwerbstaetigkeiten.Arbeitslos,
                    new Konto(random.Next(25, 13000)), "LisaZiegler@rhyta.com")
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
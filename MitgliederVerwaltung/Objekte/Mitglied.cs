using System;
using MitgliederVerwaltung.Basis;

namespace MitgliederVerwaltung.Objekte
{
    public class Mitglied : Person
    {
        private static int _naechsteMitgliedId;

        public bool Aktiv { get; set; }
        public DateTime Beitrittsdatum { get; set; }
        public string Email { get; set; }
        public Konstanten.Erwerbstaetigkeiten Erwerbstaetigkeit { get; set; }
        public Konto Konto { get; set; }
        public int MitgliedId { get; set; }

        public float Monatsbeitrag
        {
            get
            {
                switch (Erwerbstaetigkeit)
                {
                    case Konstanten.Erwerbstaetigkeiten.Schueler:
                        return 5;
                    case Konstanten.Erwerbstaetigkeiten.Student:
                        return 12;
                    case Konstanten.Erwerbstaetigkeiten.Berufstaetig:
                        return 25;
                    case Konstanten.Erwerbstaetigkeiten.Arbeitslos:
                        return 17;
                    case Konstanten.Erwerbstaetigkeiten.Rentner:
                        return 15;
                    default:
                        return 15;
                }
            }
        }

        public static int NaechsteMitgliedId
        {
            get
            {
                _naechsteMitgliedId++;
                return _naechsteMitgliedId;
            }
        }


        public Mitglied(string vorname, string nachname, DateTime geburtsdatum, Anschrift anschrift,
            Konstanten.Erwerbstaetigkeiten erwerbstaetigkeit, Konto konto, string email)
            : base(vorname, nachname, geburtsdatum, anschrift)
        {
            Erwerbstaetigkeit = erwerbstaetigkeit;
            Beitrittsdatum = DateTime.Now;
            Konto = konto;
            Aktiv = true;
            Email = email;
            MitgliedId = NaechsteMitgliedId;
        }
    }
}
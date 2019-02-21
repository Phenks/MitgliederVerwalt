using System;
using MitgliederVerwaltung.Basis;

namespace MitgliederVerwaltung.Objekte
{
    public class Mitglied : Person
    {
        public bool Aktiv { get; set; }
        public DateTime Beitrittsdatum { get; set; }
        public string Email { get; set; }
        public Konstanten.Erwerbstaetigkeiten Erwerbstaetigkeit { get; set; }
        public Konto Konto { get; set; }
        

        public Mitglied(string vorname, string nachname, DateTime geburtsdatum, Anschrift anschrift,
            Konstanten.Erwerbstaetigkeiten erwerbstaetigkeit, Konto konto, string email)
            : base(vorname, nachname, geburtsdatum, anschrift)
        {
            Erwerbstaetigkeit = erwerbstaetigkeit;
            Beitrittsdatum = DateTime.Now;
            Konto = konto;
            Aktiv = true;
            Email = email;
            
        }
    }
}
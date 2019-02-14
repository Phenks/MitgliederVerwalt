using System;
using MitgliederVerwaltung.Basis;

namespace MitgliederVerwaltung.Objekte
{
    internal class Mitglied : Person
    {
        public Konstanten.Erwerbstaetigkeiten Erwerbstaetigkeit { get; set; }
        public DateTime Beitrittsdatum { get; set; }
        public Konto Konto { get; set; }
        public bool Aktiv { get; set; }

    }
}
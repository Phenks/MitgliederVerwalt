using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MitgliederVerwaltung.Views.Vereinskonto;

namespace MitgliederVerwaltung.Objekte
{
    class Verein
    {
        public List<Mitglied> Mitglieder { get; private set; }
        public Vereinskonto Konto { get; }

        public Verein(List<Mitglied> mitglieder, Vereinskonto konto)
        {
            Mitglieder = mitglieder;
            Konto = konto;
        }

        public void FuegeMitgliedHinzu(Mitglied mitglied)
        {
            Mitglieder.Add(mitglied);
        }

        public void EntferneMitglied(Mitglied mitglied)
        {
            Mitglieder.Remove(mitglied);
        }
    }
}
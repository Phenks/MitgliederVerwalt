using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MitgliederVerwaltung.Views.VereinskontoView;

namespace MitgliederVerwaltung.Objekte
{
    class Verein
    {
        public List<Mitglied> Mitglieder { get; set; }
        public VereinskontoView Konto { get; }

        public Verein()
        {
            Mitglieder = new List<Mitglied>();
        }

        public Verein(List<Mitglied> mitglieder, VereinskontoView konto)
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
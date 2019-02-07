using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitgliederVerwaltung.System
{
    public static class  Konstanten
    {
        public enum Status
        {
            Aktiv,
            Inatkiv
        }

        public enum Erwerbstaetigkeiten
        {
            Schueler, 
            Student,
            Berufstaetig,
            Arbeitslos,
            Rentner
        }
    }
}

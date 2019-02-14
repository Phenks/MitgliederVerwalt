using System.Windows;

namespace MitgliederVerwaltung.Basis
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

        public class UI
        {
            public static GridLength AktionsmenueHoehe = new GridLength(40);
        }
    }
}

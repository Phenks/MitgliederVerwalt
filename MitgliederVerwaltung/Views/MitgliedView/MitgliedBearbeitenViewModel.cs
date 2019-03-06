using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MitgliederVerwaltung.Basis;
using MitgliederVerwaltung.Objekte;
using MitgliederVerwaltung.Services;

namespace MitgliederVerwaltung.Views.MitgliedView
{
    class MitgliedBearbeitenViewModel : ViewModelBasis
    {
        private string _vorname;
        public string Vorname
        {
            get { return _vorname; }
            set { SetProperty(ref _vorname, value); }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private DateTime _geburtsdatum;
        public DateTime Geburtsdatum
        {
            get { return _geburtsdatum; }
            set { SetProperty(ref _geburtsdatum, value); }
        }

        private string _kontakt;
        public string Kontakt
        {
            get { return _kontakt; }
            set { SetProperty(ref _kontakt, value); }
        }

        private string _strasse;
        public string Strasse
        {
            get { return _strasse; }
            set { SetProperty(ref _strasse, value); }
        }

        public Window Fenster { get; set; }

        private string _hausnr;
        public string Hausnr
        {
            get { return _hausnr; }
            set { SetProperty(ref _hausnr, value); }
        }

        private string _plz;
        public string Plz
        {
            get { return _plz; }
            set { SetProperty(ref _plz, value); }
        }

        private string _ort;
        public string Ort
        {
            get { return _ort; }
            set { SetProperty(ref _ort, value); }
        }

        private string _titel;
        public string Titel
        {
            get { return _titel; }
            set { SetProperty(ref _titel, value); }
        }

        private Konstanten.Erwerbstaetigkeiten _auflistung;
        public Konstanten.Erwerbstaetigkeiten Auflistung
        {
            get { return _auflistung; }
            set
            {
                _auflistung = value;
                SetProperty(ref _auflistung, value);
            }
        }

        public IEnumerable<Konstanten.Erwerbstaetigkeiten> MyEnumTypeValues
        {
            get
            {
                return Enum.GetValues(typeof(Konstanten.Erwerbstaetigkeiten)).Cast<Konstanten.Erwerbstaetigkeiten>();
            }
        }

        public DelegateCommand Speichern { get; set; }

        public DelegateCommand Abbrechen { get; set; }

        public MitgliedBearbeitenViewModel(Window fenster)
        {
            Fenster = fenster;

            Speichern = new DelegateCommand(((o) => OnSpeichernKlick() ));
            Abbrechen = new DelegateCommand(((o) => OnAbbrechenKlick() ));
            Titel = "Mitglied Hinzufügen";
            Geburtsdatum = DateTime.Today;
        }


        public void OnSpeichernKlick()
        {
            if (string.IsNullOrWhiteSpace(Vorname) || string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Kontakt) || string.IsNullOrWhiteSpace(Strasse) || string.IsNullOrWhiteSpace(Hausnr) || string.IsNullOrWhiteSpace(Plz) || string.IsNullOrWhiteSpace(Ort)) {
                System.Windows.MessageBox.Show("Es wurden nicht alle Werte eingegeben.", "Abbruch");
                return;
            }

            var anschrift = new Anschrift(Plz, Ort, Strasse, Hausnr);
            var konto = new Konto(100);
            //DateTime myDate = DateTime.ParseExact(Geburtsdatum, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            var mitglied = new Mitglied(Vorname,Name,Geburtsdatum,anschrift,Auflistung,konto,Kontakt);
            MitgliederService.Instanz.FuegeMitgliedHinzu(mitglied);

            Fenster.Close();
        }

        public void OnAbbrechenKlick()
        {
            Fenster.Close();
        }

        public MitgliedBearbeitenViewModel(Mitglied mitglied,Window fenster) : this(fenster)
        {
            Vorname = mitglied.Vorname;
            Name = mitglied.Nachname;
            Geburtsdatum = mitglied.Geburtsdatum;
            Auflistung = mitglied.Erwerbstaetigkeit;
            Kontakt = mitglied.Email;
            Strasse = mitglied.Anschrift.Strasse;
            Hausnr = mitglied.Anschrift.Hausnummer;
            Plz = mitglied.Anschrift.Postleitzahl;
            Ort = mitglied.Anschrift.Ort;
            Titel = "Mitglied Bearbeiten";
        }

    }
}

﻿using System;
using MitgliederVerwaltung.Basis;

namespace MitgliederVerwaltung.Objekte
{
    public class Mitglied : Person
    {
        private static int _naechsteMitgliedId = 0;
        public static int NaechsteMitgliedId
        {
            get
            {
                _naechsteMitgliedId++;
                return _naechsteMitgliedId;
            }
        }

        public bool Aktiv { get; set; }
        public DateTime Beitrittsdatum { get; set; }
        public string Email { get; set; }
        public Konstanten.Erwerbstaetigkeiten Erwerbstaetigkeit { get; set; }
        public Konto Konto { get; set; }
        public int MitgliedId { get; set; }
        

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
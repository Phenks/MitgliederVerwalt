﻿using System.Windows;

namespace MitgliederVerwaltung.Views.HauptfensterView
{
    /// <summary>
    /// Interaction logic for HauptFensterView.xaml
    /// </summary>
    public partial class HauptFensterView : Window
    {
        public HauptFensterView()
        {
           
            DataContext = new HauptFensterViewModel();

            InitializeComponent();
        }

        private void MitgliederUebersichtView_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}

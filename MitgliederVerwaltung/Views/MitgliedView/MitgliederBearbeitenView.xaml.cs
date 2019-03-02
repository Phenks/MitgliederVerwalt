using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MitgliederVerwaltung.Objekte;
using MitgliederVerwaltung.Services;

namespace MitgliederVerwaltung.Views.MitgliedView
{
    /// <summary>
    /// Interaction logic for MitgliederBearbeitenView.xaml
    /// </summary>
    public partial class MitgliederBearbeitenView : Window
    {
        public MitgliederBearbeitenView()
        {
            DataContext = new MitgliedBearbeitenViewModel(this);
            InitializeComponent();
        }

        public MitgliederBearbeitenView(Mitglied mitglied)
        {
            DataContext = new MitgliedBearbeitenViewModel(mitglied,this);
            InitializeComponent();
        }
    }
}

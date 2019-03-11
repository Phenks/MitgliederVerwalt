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
    /// Interaction logic for MitgliedInfoView.xaml
    /// </summary>
    public partial class MitgliedInfoView : Window
    {
        public MitgliedInfoView()
        {
            InitializeComponent();
        }
        public MitgliedInfoView(Mitglied mitglied)
        {
            DataContext = new MitgliedInfoViewModel(mitglied, this);
            InitializeComponent();
        }
    }
}

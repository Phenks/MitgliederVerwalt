using System.Windows.Controls;

namespace MitgliederVerwaltung.Views.MitgliedView
{
    /// <summary>
    /// Interaction logic for MitgliedView.xaml
    /// </summary>
    public partial class MitgliedView : UserControl
    {
        public MitgliedView(Objekte.Mitglied mitglied)
        {
            DataContext = new MitgliedViewModel(mitglied);
            InitializeComponent();
        }
    }
}

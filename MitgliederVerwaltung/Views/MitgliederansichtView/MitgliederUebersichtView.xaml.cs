using System.Windows.Controls;

namespace MitgliederVerwaltung.Views.MitgliederansichtView
{
    /// <summary>
    /// Interaction logic for MitgliederUebersichtView.xaml
    /// </summary>
    public partial class MitgliederUebersichtView : UserControl
    {
        public MitgliederUebersichtView()
        {
            DataContext = new MitgliederUebersichtViewModel();
            InitializeComponent();
        }
    }
}

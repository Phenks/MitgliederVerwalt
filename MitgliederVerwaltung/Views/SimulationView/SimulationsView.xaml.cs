using System.Windows.Controls;

namespace MitgliederVerwaltung.Views.SimulationView
{
    /// <summary>
    /// Interaction logic for SimulationsView.xaml
    /// </summary>
    public partial class SimulationsView : UserControl
    {
        public SimulationsView()
        {
            DataContext = new SimulationViewModel();
            InitializeComponent();
        }
    }
}

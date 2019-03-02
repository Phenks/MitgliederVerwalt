using System.Windows.Controls;

namespace MitgliederVerwaltung.Views.MitgliedView
{
    /// <summary>
    /// Interaction logic for MitgliedView.xaml
    /// </summary>
    public partial class MitgliedView : UserControl
    {
        public MitgliedView(MitgliedViewModel viewModel)
        {
            DataContext = viewModel;
            InitializeComponent();
        }
    }
}

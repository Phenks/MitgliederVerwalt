using System.Windows;

namespace MitgliederVerwaltung.Views.Hauptfenster
{
    /// <summary>
    /// Interaction logic for HauptFenster.xaml
    /// </summary>
    public partial class HauptFenster : Window
    {
        public HauptFenster()
        {
            var viewModel = new HauptFensterViewModel();
            viewModel.Name = "Test";
            DataContext = viewModel;
            
            InitializeComponent();
        }

        
    }
}

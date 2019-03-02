using System.Windows;

namespace MitgliederVerwaltung.Views.HauptfensterView
{
    /// <summary>
    /// Interaction logic for HauptFensterView.xaml
    /// </summary>
    public partial class HauptFensterView : Window
    {
        public HauptFensterView()
        {
            var viewModel = new HauptFensterViewModel();
            viewModel.Name = "Test";
            DataContext = viewModel;
            
            InitializeComponent();
        }

        
    }
}

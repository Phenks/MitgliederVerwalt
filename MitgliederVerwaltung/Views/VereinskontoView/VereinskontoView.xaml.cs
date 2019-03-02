using System.Windows.Controls;
using MitgliederVerwaltung.Objekte;

namespace MitgliederVerwaltung.Views.VereinskontoView
{
    /// <summary>
    /// Interaction logic for VereinskontoView.xaml
    /// </summary>
    public partial class VereinskontoView : UserControl
    {
        public VereinskontoView()
        {   
            
            DataContext = new VereinskontoViewModel(new Konto(1234));
            InitializeComponent();
        }
    }
}

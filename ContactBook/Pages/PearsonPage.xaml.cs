
using ContactBook.Core.ViewModel.Pages;
using System.Windows.Controls;


namespace ContactBook
{
    /// <summary>
    /// Interaction logic for PearsonPage.xaml
    /// </summary>
    public partial class PearsonPage : Page
    {
        public PearsonPage()
        {
            InitializeComponent();
            DataContext = new PearsonPageViewModel();
        }
    }
}

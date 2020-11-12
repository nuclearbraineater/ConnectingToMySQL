using DataLibrary;
using System.Collections.Generic;
using System.Windows;

namespace WpfSpiceShelf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly SpiceViewModel viewModel;

        public MainWindow()
        {
            InitializeComponent();
            viewModel = new SpiceViewModel();
            this.DataContext = viewModel;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            viewModel.GetSpices();
        }

        private void DisplaySpices(List<SpiceModel> spices)
        {
            viewModel.GetSpices();
        }
    }
}

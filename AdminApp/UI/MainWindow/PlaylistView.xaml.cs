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

namespace AdminApp.UI.MainWindow
{
    /// <summary>
    /// Interaction logic for PlaylistViewUI.xaml
    /// </summary>
    public partial class PlaylistViewUI : Window
    {
        public PlaylistViewUI()
        {
            InitializeComponent();
            FillPlaylistView();
        }

        private void FillPlaylistView()
        {
            throw new NotImplementedException();
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                this.Close();
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Czy napewno chcesz zakończyć?", "Wyjście", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}

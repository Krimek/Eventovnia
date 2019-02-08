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

namespace AdminApp.UI.Playlist
{
    /// <summary>
    /// Interaction logic for AddPlaylist.xaml
    /// </summary>
    public partial class AddPlaylist : Window
    {
        public AddPlaylist()
        {
            InitializeComponent();
            FillComboBoxes(new Uri(""), "");
        }

        public AddPlaylist(string title, params string[] tracks)
        {
            FillComboBoxes(new Uri(""), title, tracks);
        }

        private void FillComboBoxes(Uri folderWithTracks, string title, params string[] currentTracks)
        {
            throw new NotImplementedException();
        }

        private void SearchTrackTextBoxTextChanged(object sender, TextChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MoveToSelectButtonClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MoveUpButtonClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MoveDownButtonClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void RemoveFromSelectButtonClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}

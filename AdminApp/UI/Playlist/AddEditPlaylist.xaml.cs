using AdminApp.Properties;
using Eventovnia.Admin.Common;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

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
            FillComboBoxes();
        }

        public AddPlaylist(params string[] tracks)
        {
            InitializeComponent();
            Title = "Edytuj playliste";
            FillComboBoxes(tracks);
        }

        private void FillComboBoxes(params string[] currentTracks)
        {
            string path = Settings.Default.AdminMusicPath;
            SaveLoadPlaylist loadTracks = new SaveLoadPlaylist();
            List<string> listTracks = loadTracks.GetTracksList(path);
            AllTracksListBox.Items.Clear();
            AllTracksListBox.ItemsSource = listTracks;
            SelectedTracksListBox.Items.Clear();
            SelectedTracksListBox.ItemsSource = currentTracks;
        }

        private void SearchTrackTextBoxTextChanged(object sender, TextChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MoveToSelectButtonClick(object sender, RoutedEventArgs e)
        {
            if (AllTracksListBox.SelectedItems.Count > 0)
            {
                foreach (object selectedItem in AllTracksListBox.SelectedItems)
                {
                    AllTracksListBox.SelectedItems.
                }
            }
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

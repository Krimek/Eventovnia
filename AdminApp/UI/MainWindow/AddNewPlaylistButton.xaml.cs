﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AdminApp.UI.MainWindow
{
    /// <summary>
    /// Interaction logic for AddNewPlaylist.xaml
    /// </summary>
    public partial class AddNewPlaylist : UserControl
    {
        public AddNewPlaylist()
        {
            InitializeComponent();
        }

        private void AddNewPlaylistMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            UI.Playlist.AddPlaylist window = new Playlist.AddPlaylist();
            window.ShowDialog();
        }
    }
}

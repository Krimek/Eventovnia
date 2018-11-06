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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AdminApp.MainWindow
{
    /// <summary>
    /// Interaction logic for AddPlaylistButtonUI.xaml
    /// </summary>
    public partial class AddPlaylistButtonUI : UserControl
    {
        public AddPlaylistButtonUI()
        {
            InitializeComponent();
        }

        private void AddPlaylistButtonMouseUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void ShowAddPlaylistButtonMouseMove(object sender, MouseEventArgs e)
        {
            if (AddPlaylistButtonGrid.IsMouseOver)
            {
                AddPlaylistButtonGrid.Visibility = Visibility.Visible;
            }
        }

        private void HideAddPlaylistButtonMouseMove(object sender, MouseEventArgs e)
        {
            if (!AddPlaylistButtonGrid.IsMouseOver)
            {
                AddPlaylistButtonGrid.Visibility = Visibility.Hidden;
            }
        }

        public void Resize(int width)
        {

        }
    }
}

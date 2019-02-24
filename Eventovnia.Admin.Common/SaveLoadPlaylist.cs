using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventovnia.Admin.Common
{
    public class SaveLoadPlaylist
    {
        public SaveLoadPlaylist()
        {
        }

        public List<string> GetTracksList(string path)
        {
            return Directory.GetFiles(path).ToList();
        }
    }
}

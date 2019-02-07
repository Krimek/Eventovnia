using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eventovnia.Common;

namespace Eventovnia.Client.Common
{
    class EventClient : EventParameters
    {
        public bool IsSpeakingByMicrophone;
        public bool IsPlaylistPlay;
        public bool IsBreakMusic;

        public int Volume
        {
            get => Volume;
            set
            {
                if (value > 100)
                {
                    Volume = 100;
                }
                else if (value < 0)
                {
                    Volume = 0;
                }
            }
        }

        public EventClient()
        {

        }
    }
}

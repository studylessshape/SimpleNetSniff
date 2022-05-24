using System;
using SharpPcap.Npcap;

namespace NetSniff
{
    public class NetSniffHelper
    {
        public NpcapDeviceList Devices { get; private set; }

        public NetSniffHelper()
        {
            Devices = NpcapDeviceList.Instance;
        }
    }
}

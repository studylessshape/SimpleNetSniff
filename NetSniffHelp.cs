using System;
using SharpPcap;
using SharpPcap.Npcap;

namespace NetSniff
{
    public class NetSniffHelper
    {
        public NpcapDeviceList Devices { get; private set; }
        public DeviceMode Mode;
        public int ReadTimeout;

        public NetSniffHelper()
        {
            Devices = NpcapDeviceList.Instance;
            Mode = DeviceMode.Normal;
            ReadTimeout = 1000;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using SharpPcap;
using SharpPcap.Npcap;

namespace NetSniff
{
    public partial class SniffWindow : Form
    {
        readonly NpcapDevice device;

        int countOfPacket = 0;
        bool isInSniff = false;
        readonly List<PacketDotNet.Packet> packets;
        readonly Dictionary<string, int> packetCnt;

        public SniffWindow(NpcapDevice device)
        {
            InitializeComponent();
            this.device = device;
            packets = new List<PacketDotNet.Packet>();
            packetCnt = new Dictionary<string, int>();
            this.Text += $" - {device.Description}";
        }

        private void StartSniff(string filter)
        {
            // 设置嗅探事件，并开始嗅探
            device.OnPacketArrival += Device_OnPacketArrival;
            device.Open(DeviceMode.Promiscuous, 1000);
            
            isInSniff = true;

            bool isError = false;
            try
            {
                device.Filter = filter;
                device.StartCapture();
                sniffStateChangeButton.Text = "暂停嗅探";
            }
            catch (DeviceNotReadyException)
            {
                MessageBox.Show("    指定网卡未能开启，或抓包事件未能绑定成功。", "发生错误！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isError = true;
            }
            catch (PcapException er)
            {
                MessageBox.Show($"    过滤规则设置错误，请检查过滤规则是否正确！{Environment.NewLine}    具体报错：{Environment.NewLine}    {er.Message}", "发生错误！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isError = true;
            }
            finally
            {
                if (isError)
                {
                    StopSniff();
                    sniffStateChangeButton.Text = "开始嗅探";
                }
            }
        }

        private void StopSniff()
        {
            device.OnPacketArrival -= Device_OnPacketArrival;
            device.StopCapture();
            device.Close();
            isInSniff = false;
            sniffStateChangeButton.Text = "开始嗅探";
        }

        private void SniffWindow_Load(object sender, EventArgs e)
        {
            StartSniff(textBoxFilter.Text);
        }

        private void SniffWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopSniff();
        }

        private void sniffStateChangeButton_Click(object sender, EventArgs e)
        {
            if (isInSniff)
            {
                StopSniff();
            }
            else
            {
                StartSniff(textBoxFilter.Text);
            }
        }

        private void Device_OnPacketArrival(object sender, CaptureEventArgs e)
        {
            PacketDotNet.Packet packet = PacketDotNet.Packet.ParsePacket(e.Packet.LinkLayerType, e.Packet.Data);

            try
            {
                do
                {
                    var ethPacket = new PacketDotNet.EthernetPacket(packet.BytesSegment);

                    if (ethPacket.Type == PacketDotNet.EthernetType.Arp)
                    {
                        PacketDotNet.ArpPacket arpPacket = new PacketDotNet.ArpPacket(ethPacket.BytesSegment);

                        countOfPacket++;
                        AddPacketToList(new ListViewItem(
                            new string[4]
                            {
                                    countOfPacket.ToString(),
                                    arpPacket.SenderProtocolAddress.ToString(),
                                    arpPacket.TargetProtocolAddress.ToString(),
                                    "ARP"
                            }
                        ));
                        packets.Add(packet);

                        if (packetCnt.ContainsKey("ARP"))
                        {
                            packetCnt["ARP"]++;
                        }
                        else
                        {
                            packetCnt.Add("ARP", 1);
                        }
                    }
                    else if (ethPacket.Type == PacketDotNet.EthernetType.IPv4)
                    {
                        PacketDotNet.IPv4Packet iPv4Packet = ethPacket.Extract<PacketDotNet.IPv4Packet>();

                        if (iPv4Packet == null)
                            break;

                        countOfPacket++;
                        AddPacketToList(new ListViewItem(
                                new string[4]
                                {
                                    countOfPacket.ToString(),
                                    $"{iPv4Packet.SourceAddress}",
                                    $"{iPv4Packet.DestinationAddress}",
                                    $"{iPv4Packet.Protocol}"
                                }
                            ));
                        packets.Add(packet);

                        if (packetCnt.ContainsKey($"{iPv4Packet.Protocol}"))
                        {
                            packetCnt[$"{iPv4Packet.Protocol}"]++;
                        }
                        else
                        {
                            packetCnt.Add($"{iPv4Packet.Protocol}", 1);
                        }
                    }
                } while (false);
            }
            catch (Exception)
            {

            }
            finally
            {
                SetTextOfStaistics();
            }
        }

        private void AddPacketToList(ListViewItem packetInfo)
        {
            listViewPacket.Items.Add(packetInfo);
        }

        private void SetTextOfStaistics()
        {
            textBoxStatistics.Text = $"[抓包]{Environment.NewLine}";
            foreach (var it in packetCnt)
            {
                textBoxStatistics.Text += $"{it.Key}: {it.Value}{Environment.NewLine}";
            }
            textBoxStatistics.Text += $"总计: {countOfPacket}{Environment.NewLine}";

            textBoxStatistics.Text += $"[网卡]{Environment.NewLine}接收: {device.Statistics.ReceivedPackets}{Environment.NewLine}";
            textBoxStatistics.Text += $"丢失: {device.Statistics.DroppedPackets}";
        }

        private void listViewPacket_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            PacketDotNet.Packet packet = packets[e.ItemIndex];
            // 打印源数据到TextBox中
            textBoxRawData.Text = BytesToHexString(packet.Bytes, " ");
            textBoxConvertRawData.Text = BytesToString(packet.Bytes);

            var ethPacket = new PacketDotNet.EthernetPacket(packet.BytesSegment);
            // 选择新的条目之后，需要清楚原来生成的树
            treeViewDesequencePacket.Nodes.Clear();

            TreeNode ethNode = new TreeNode("EthernetII");
            ethNode.Nodes.Add($"Source Mac: {BytesToHexString(ethPacket.SourceHardwareAddress.GetAddressBytes(), ":")}");
            ethNode.Nodes.Add($"Destination Mac: {BytesToHexString(ethPacket.DestinationHardwareAddress.GetAddressBytes(), ":")}");
            ethNode.Nodes.Add($"Type: {ethPacket.Type}({(ushort)ethPacket.Type})");
            ethNode.Nodes.Add($"Length: {ethPacket.TotalPacketLength}");
            // 将包的Ethernet的信息添加进树中
            treeViewDesequencePacket.Nodes.Add(ethNode);

            if (ethPacket.Type == PacketDotNet.EthernetType.Arp)
            {
                PacketDotNet.ArpPacket arpPacket = new PacketDotNet.ArpPacket(ethPacket.BytesSegment);
                // 新建节点，添加好ARP的各种信息
                TreeNode arpNode = new TreeNode("Address Resolution Protocol");
                arpNode.Nodes.Add($"Hardware Type: {arpPacket.HardwareAddressType}({(ushort)arpPacket.HardwareAddressType})");
                arpNode.Nodes.Add($"Protocol Type: {arpPacket.ProtocolAddressType}({(ushort)arpPacket.ProtocolAddressType})");
                arpNode.Nodes.Add($"Hardware Size: {arpPacket.HardwareAddressLength}");
                arpNode.Nodes.Add($"Protocol Size: {arpPacket.ProtocolAddressLength}");
                arpNode.Nodes.Add($"Opcode: {arpPacket.Operation}({(ushort)arpPacket.Operation})");
                arpNode.Nodes.Add($"Sender MAC address: {BytesToHexString(arpPacket.SenderHardwareAddress.GetAddressBytes(), ":")}");
                arpNode.Nodes.Add($"Target MAC address: {BytesToHexString(arpPacket.TargetHardwareAddress.GetAddressBytes(), ":")}");
                arpNode.Nodes.Add($"Sender IP address: {arpPacket.SenderProtocolAddress}");
                arpNode.Nodes.Add($"Target IP address: {arpPacket.TargetProtocolAddress}");
                // 将包的ARP的信息添加进树中
                treeViewDesequencePacket.Nodes.Add(arpNode);
            }
            else if (ethPacket.Type == PacketDotNet.EthernetType.IPv4)
            {
                PacketDotNet.IPv4Packet iPv4Packet = ethPacket.Extract<PacketDotNet.IPv4Packet>();

                // 新建节点，将IP包的信息添加好
                TreeNode ipNode = new TreeNode("Internet Protocol");
                ipNode.Nodes.Add($"Version: {iPv4Packet.Version}({(int)iPv4Packet.Version})");
                ipNode.Nodes.Add($"Header Length: {iPv4Packet.HeaderLength}");
                ipNode.Nodes.Add($"Differentiated Services: {iPv4Packet.DifferentiatedServices}");
                ipNode.Nodes.Add($"Totoal length: {iPv4Packet.TotalPacketLength}");
                ipNode.Nodes.Add($"Identification: 0x{iPv4Packet.Id.ToString("x")}({iPv4Packet.Id})");
                ipNode.Nodes.Add($"Flag: {iPv4Packet.FragmentFlags}");
                ipNode.Nodes.Add($"Fragment Offset: {iPv4Packet.FragmentOffset}");
                ipNode.Nodes.Add($"Time to Live: {iPv4Packet.TimeToLive}");
                ipNode.Nodes.Add($"Protocol: {iPv4Packet.Protocol}({(byte)iPv4Packet.Protocol})");
                ipNode.Nodes.Add($"Header Checksum: 0x{iPv4Packet.Checksum.ToString("x")}");
                ipNode.Nodes.Add($"Source Address: {iPv4Packet.SourceAddress}");
                ipNode.Nodes.Add($"Destination Address: {iPv4Packet.DestinationAddress}");
                // 将包的ARP的信息添加进树中
                treeViewDesequencePacket.Nodes.Add(ipNode);

                // 根据不同的协议类型，将信息添加到树中
                switch (iPv4Packet.Protocol)
                {
                    case PacketDotNet.ProtocolType.Icmp:
                        PacketDotNet.IcmpV4Packet icmpV4Packet = packet.Extract<PacketDotNet.IcmpV4Packet>();
                        if (icmpV4Packet == null)
                            break;

                        TreeNode icmpNode = new TreeNode("Internet Control Message Protocol");
                        icmpNode.Nodes.Add($"Type Code: {(ushort)icmpV4Packet.TypeCode}({icmpV4Packet.TypeCode})");
                        icmpNode.Nodes.Add($"Checksum: 0x{icmpV4Packet.Checksum.ToString("x")}");
                        icmpNode.Nodes.Add($"Identifier: {icmpV4Packet.Id}(0x{icmpV4Packet.Id.ToString("x")})");
                        icmpNode.Nodes.Add($"Sequence Number: {icmpV4Packet.Sequence}(0x{icmpV4Packet.Sequence.ToString("x")})");

                        TreeNode icmpDataNode = new TreeNode("Data");
                        icmpDataNode.Nodes.Add($"Data: {BytesToHexString(icmpV4Packet.Bytes, "")}");
                        icmpDataNode.Nodes.Add($"[Length: {icmpV4Packet.Data.Length}]");
                        icmpNode.Nodes.Add(icmpDataNode);
                        // 将填好信息的ICMP信息节点加入到树中
                        treeViewDesequencePacket.Nodes.Add(icmpNode);
                        break;
                    case PacketDotNet.ProtocolType.Tcp:
                        PacketDotNet.TcpPacket tcpPacket = packet.Extract<PacketDotNet.TcpPacket>();
                        if (tcpPacket == null)
                            break;

                        TreeNode tcpNode = new TreeNode("Transmission Control Protocol");
                        tcpNode.Nodes.Add($"Source Port: {tcpPacket.SourcePort}");
                        tcpNode.Nodes.Add($"Destination Port: {tcpPacket.DestinationPort}");
                        tcpNode.Nodes.Add($"Sequence Number: {tcpPacket.SequenceNumber}");
                        tcpNode.Nodes.Add($"Acknowledgment Number: {tcpPacket.AcknowledgmentNumber}");
                        tcpNode.Nodes.Add($"Flags: {tcpPacket.Flags}");
                        tcpNode.Nodes.Add($"Window Size: {tcpPacket.WindowSize}");
                        tcpNode.Nodes.Add($"Checksum: 0x{tcpPacket.Checksum.ToString("x")}");
                        tcpNode.Nodes.Add($"Urgent Pointer: {tcpPacket.UrgentPointer}");
                        // 将填好信息的TCP信息节点加入到树中
                        treeViewDesequencePacket.Nodes.Add(tcpNode);
                        break;
                    case PacketDotNet.ProtocolType.Udp:
                        PacketDotNet.UdpPacket udpPacket = packet.Extract<PacketDotNet.UdpPacket>();
                        if (udpPacket == null)
                            break;

                        TreeNode udpNode = new TreeNode("User Datagram Protocol");
                        udpNode.Nodes.Add($"Source Port: {udpPacket.SourcePort}");
                        udpNode.Nodes.Add($"Destination Port: {udpPacket.DestinationPort}");
                        udpNode.Nodes.Add($"Length: {udpPacket.Length}");
                        udpNode.Nodes.Add($"Checksum: 0x{udpPacket.Checksum.ToString("x")}");
                        udpNode.Nodes.Add($"UDP Payload ({udpPacket.PayloadData.Length} bytes)");

                        TreeNode udpDataNode = new TreeNode("Data");
                        udpDataNode.Nodes.Add($"Data: {BytesToHexString(udpPacket.PayloadData, "")}");
                        udpDataNode.Nodes.Add($"[Length: {udpPacket.PayloadData.Length}]");
                        udpNode.Nodes.Add(udpDataNode);
                        // 将填好信息的TCP信息节点加入到树中
                        treeViewDesequencePacket.Nodes.Add(udpNode);
                        break;
                    default:
                        break;
                }
                treeViewDesequencePacket.ExpandAll();
            }
        }

        private string BytesToHexString(byte[] bytes, string spanStr)
        {
            StringBuilder sbmac = new StringBuilder();
            int len = bytes.Length;
            for (int i = 0; i < len - 1; i++)
            {
                sbmac.Append(string.Format("{0:X2}{1}", bytes[i], spanStr));
            }
            sbmac.Append(string.Format("{0:X2}", bytes[len - 1]));
            return sbmac.ToString().Trim();
        }

        private string BytesToString(byte[] bytes)
        {
            StringBuilder bsb = new StringBuilder();
            foreach (byte b in bytes)
            {
                char c = (char)b;
                if (!(
                    char.IsLetterOrDigit(c) ||
                    char.IsPunctuation(c) ||
                    c == '\r' ||
                    c == '\n'
                    ))
                {
                    bsb.Append(' ');
                }
                else
                {
                    bsb.Append(c);
                }
            }
            return bsb.ToString();
        }

        private void enableFilterButton_Click(object sender, EventArgs e)
        {
            StopSniff();
            StartSniff(textBoxFilter.Text);
        }
    }
}

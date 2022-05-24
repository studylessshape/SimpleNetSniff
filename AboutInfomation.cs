using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSniff
{
    public class AboutInfomation
    {
        public static readonly string ProgramName;
        public static readonly string ProgramVersion;
        public static readonly string ProgramIntroduction;
        public static readonly string[] DependenceIntro;
        public static readonly string Author;
        static AboutInfomation()
        {
            ProgramName = "嗅探器";
            ProgramVersion = "V0.1.0";
            ProgramIntroduction = "一个基于C#、SharpPcap和WinForm开发的网络嗅探器，仅用于学习实验开发用。";
            DependenceIntro = new string[] { 
                "SharpPcap：C#中基于LibPcap、NPcap的库。",
                "PacketDotNet: 协议包解析库。"
            };
            Author = "Copyright@ 薛仕豪 2022";
        }

        public static string SequenceString()
        {
            StringBuilder deIntroStrSb = new StringBuilder(Environment.NewLine);

            foreach(var deStr in DependenceIntro)
            {
                deIntroStrSb.Append($"{Environment.NewLine}{deStr}");
            }

            return $"{ProgramName}  {ProgramVersion}{Environment.NewLine}" +
                $"\t{ProgramIntroduction}{Environment.NewLine}" +
                deIntroStrSb.ToString() + Environment.NewLine + Environment.NewLine +
                Author;
        }
    }
}

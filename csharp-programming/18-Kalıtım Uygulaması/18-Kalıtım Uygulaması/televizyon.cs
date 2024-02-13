using System;
using System.Collections.Generic;
using System.Text;

namespace _18_Kalıtım_Uygulaması
{
    public sealed class televizyon : urun
    {
        public bool smartTV { get; set; }
        public bool HDMI { get; set; }
        public string ekranBoyutu { get; set; }
    }
}

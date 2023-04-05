using System;
using System.Collections.Generic;
using System.Linq;

namespace _VGA
{
    public class VGA
    {
        public string merk;
    }
    public class NVIDIA : VGA
    {
        public NVIDIA() { base.merk = "NVIDIA"; }
    }
    public class AMD : VGA
    {
        public AMD() { base.merk = "AMD"; }
    }
}

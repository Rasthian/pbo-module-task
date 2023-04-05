

namespace _Processor
{
    public class Processor
    {
        public string merk, tipe;
    }

    class AMD : Processor
    {
        public AMD() { base.merk = "AMD"; }
    }

    class Ryzen : AMD
    {
        public Ryzen() { base.tipe = "RAYZEN"; }
    }
    class ATHLON : AMD
    {
        public ATHLON() { base.tipe = "ATHLON"; }
    }

    public class Intel : Processor
    {
        public Intel() { base.merk = "Intel"; }
    }

    class Corei3 : Intel
    {
        public Corei3() { base.tipe = "Core i3"; }
    }
    public class Corei5 : Intel
    {
        public Corei5() { base.tipe = "Core i5"; }
    }
    class Corei7 : Intel
    {
        public Corei7() { base.tipe = "Core i7"; }
    }

}

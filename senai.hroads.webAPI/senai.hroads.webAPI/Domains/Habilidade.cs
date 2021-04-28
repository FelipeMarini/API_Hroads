using System;
using System.Collections.Generic;

#nullable disable

namespace senai.hroads.webAPI.Domains
{
    public partial class Habilidade
    {
        public int IdHabilidade { get; set; }
        public int? IdTiposHabilidade { get; set; }
        public string Nome { get; set; }

        public virtual TiposHabilidade TiposHabilidades { get; set; }
    }
}

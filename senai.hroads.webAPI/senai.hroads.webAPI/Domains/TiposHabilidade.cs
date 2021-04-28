using System;
using System.Collections.Generic;

#nullable disable

namespace senai.hroads.webAPI.Domains
{
    public partial class TiposHabilidade
    {
        public TiposHabilidade()
        {
            Habilidades = new HashSet<Habilidade>();
        }

        public int IdTiposHabilidade { get; set; }
        public string NomeTiposHabilidade { get; set; }

        public virtual ICollection<Habilidade> Habilidades { get; set; }
    }
}

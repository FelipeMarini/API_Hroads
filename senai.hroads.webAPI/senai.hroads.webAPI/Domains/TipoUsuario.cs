using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webAPI.Domains
{
    public class TipoUsuario
    {

        public int IdTipoUsuario { get; set; }

        
        [Required(ErrorMessage = "O título do tipo de usuário é obrigatório")]
        [DataType(DataType.Text)]
        public string tituloTipoUsuario { get; set; }

        
    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webAPI.Domains
{
    public class Usuario
    {

        public int IdUsuario { get; set; }

        
        [Required(ErrorMessage = "obrigatório preencher o campo de email")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        
        [Required(ErrorMessage = "obrigatório informar uma senha")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "a senha precisa ter no mínimo 3 caracteres")]
        [DataType(DataType.Password)]
        public string senha { get; set; }


        public int IdTipoUsuario { get; set; }


    }

}

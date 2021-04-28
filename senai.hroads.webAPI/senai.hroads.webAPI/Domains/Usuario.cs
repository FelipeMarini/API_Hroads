using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace senai.hroads.webAPI.Domains
{
    public partial class Usuario
    {
        
        public int IdUsuario { get; set; }

        
        [Required(ErrorMessage = "obrigatório preencher o campo de email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required(ErrorMessage = "obrigatório fornecer uma senha")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "a senha precisa ter no mínimo 3 caracteres")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        public int IdTiposUsuario { get; set; }

        
        public virtual TiposUsuario TiposUsuarios { get; set; }
    
    
    }
}

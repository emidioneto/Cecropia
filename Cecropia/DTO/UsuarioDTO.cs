using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cecropia.DTO
{
    public class UsuarioDTO
    {
        public virtual int Codigo { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Email { get; set; }
        public virtual string Senha { get; set; }
        public virtual IList<UsuarioRedeSocialDTO> UsuariosRedeSocial { get; set; }
        public virtual IList<CategoriaDTO> Categorias { get; set; }
    }
}
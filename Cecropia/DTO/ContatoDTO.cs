using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cecropia.DTO
{
    public class ContatoDTO
    {
        public virtual int Codigo { get; set; }
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual string NomeFoto { get; set; }
        public virtual UsuarioRedeSocialDTO UsuarioRedeSocial { get; set; }
        public virtual IList<CategoriaDTO> Categorias { get; set; }
    }
}
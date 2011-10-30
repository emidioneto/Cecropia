using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cecropia.DTO
{
    public class CategoriaDTO
    {
        public virtual int Codigo { get; set; }
        public virtual string Descricao { get; set; }
        public virtual UsuarioDTO Usuario { get; set; }
        public virtual IList<ContatoDTO> Contatos { get; set; }
    }
}
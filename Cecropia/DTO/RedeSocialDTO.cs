using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cecropia.DTO
{
    public class RedeSocialDTO
    {
        public virtual int Codigo{ get; set; }
        public virtual string Descricao{ get; set; }
        public virtual string ConsumerSecret{ get; set; }
        public virtual string ConsumerKey{ get; set; }
        public virtual IList<UsuarioRedeSocialDTO> UsuariosRedeSocial { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cecropia.DTO
{
    public class UsuarioRedeSocialDTO
    {
        public virtual int Codigo { get; set; }
        public virtual string AccessToken { get; set; }
        public virtual string AccessTokenSecret { get; set; }
        public virtual UsuarioDTO Usuario { get; set; }
        public virtual RedeSocialDTO RedeSocial { get; set; }
    }
}
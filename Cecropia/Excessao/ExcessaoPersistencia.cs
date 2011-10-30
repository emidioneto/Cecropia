using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cecropia.Excessao
{
    public class ExcessaoPersistencia : Exception
    {
        private string mensagem;

        public ExcessaoPersistencia()
        {
        }

        public ExcessaoPersistencia(string mensagem)
        {
            this.mensagem = mensagem;
        }

        public override string Message
        {
            get
            {
                if (string.IsNullOrEmpty(mensagem))
                {
                    mensagem = base.Message;
                }
                return mensagem;
            }
        }
    }
}
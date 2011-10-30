using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;
using Cecropia.Utils;

namespace Cecropia.DAO
{
    public class DAOGenerico
    {
        ISession sessao;
        ITransaction transacao;

        public ISession Sessao
        {
            get { return sessao; }
            set { sessao = value; }
        }

        public ITransaction Transacao
        {
            get { return transacao; }
            set { transacao = value; }
        }

        public void iniciarTrasancao()
        {
            this.sessao = FabricaSessao.obterInstancia().obterSessao();
            this.transacao = sessao.BeginTransaction();
        }

        public void fecharTransacao()
        {
            sessao.Close();
        }

        public void commit()
        {
            transacao.Commit();
        }

        public void rollBack()
        {
            transacao.Rollback();
        }
    }
}
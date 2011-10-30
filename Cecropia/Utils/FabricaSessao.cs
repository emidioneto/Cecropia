using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;
using NHibernate.Cfg;

namespace Cecropia.Utils
{
    public class FabricaSessao
    {
        private static FabricaSessao instancia;
        private ISessionFactory fabrica;

        private FabricaSessao()
        {
            fabrica = new Configuration().Configure().BuildSessionFactory();
        }

        public static FabricaSessao obterInstancia()
        {
            if(instancia == null){
                instancia = new FabricaSessao();
            }

            return instancia;
        }

        public ISession obterSessao()
        {
            return fabrica.OpenSession();
        }
    }
}
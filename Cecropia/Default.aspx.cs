using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NHibernate;
using NHibernate.Cfg;
using Cecropia.DTO;
using Cecropia.DAO;
using System.Collections;

namespace Cecropia
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Configuration config = new Configuration();
            //config.AddAssembly(typeof(UsuarioDTO).Assembly);

            //ISessionFactory sessaoFabrica = new Configuration().Configure().BuildSessionFactory();

            //ISession sessao = sessaoFabrica.OpenSession();

            //ITransaction transancao = sessao.BeginTransaction();

            //RedeSocialDTO redeSocial = new RedeSocialDTO();
            //redeSocial.Descricao = "FaceBook";
            //redeSocial.ConsumerSecret = "adjahdadhag362352sbdv";
            //redeSocial.ConsumerKey = "dsjd5vvgs";

            //List<RedeSocialDTO> redesSociais = new List<RedeSocialDTO>();
            //redesSociais.Add(new RedeSocialDTO { Descricao = "Twitter", ConsumerKey = "adjahdadhag362352sbdv", ConsumerSecret = "dsjd5vvgs" });


            //UsuarioDTO usuario = new UsuarioDTO();
            //usuario.Codigo = 4;
            //usuario.Nome = "Davi";
            //usuario.Email = "teste@gmail.com";
            //usuario.Senha = "123abc";
            //usuario.RedesSociais = redesSociais;

            //new UsuarioDAO().salvar(usuario);
            //new UsuarioDAO().atualizar(usuario);
            //new UsuarioDAO().excluir(usuario);
            IList usuarioBd = new UsuarioDAO().listarTodos();

            string resultado = "";
            foreach(UsuarioDTO usuario in usuarioBd){
                resultado += usuario.Nome + " - " + usuario.Email + " - " + usuario.Senha + "<br/>";
            }

            lbResultado.Text = resultado;

            //sessao.Save(usuario);

            //transancao.Commit();
            //sessaoFabrica.Close();
        }
    }
}

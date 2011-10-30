using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cecropia.DTO;
using Cecropia.Excessao;

namespace Cecropia.DAO
{
    public class UsuarioRedeSocialDAO : DAOGenerico
    {

        public void salvar(UsuarioRedeSocialDTO usuarioRedeSocial)
        {
            try
            {
                iniciarTrasancao();
                Sessao.Save(usuarioRedeSocial);
                commit();
            }
            catch (Exception ex)
            {
                rollBack();
                throw new ExcessaoPersistencia("Erro ao salvar Usuário da Rede Social.");
            }
            finally
            {
                fecharTransacao();
            }
        }

        public void atualizar(UsuarioRedeSocialDTO usuarioRedeSocial)
        {
            try
            {
                iniciarTrasancao();
                Sessao.Update(usuarioRedeSocial);
                commit();
            }
            catch (Exception ex)
            {
                rollBack();
                throw new ExcessaoPersistencia("Erro ao atualizar Usuário da Rede Social.");
            }
            finally
            {
                fecharTransacao();
            }
        }

        public void excluir(UsuarioRedeSocialDTO usuarioRedeSocial)
        {
            try
            {
                iniciarTrasancao();
                Sessao.Delete(usuarioRedeSocial);
                commit();
            }
            catch (Exception ex)
            {
                rollBack();
                throw new ExcessaoPersistencia("Erro ao excluir Usuário da Rede Social.");
            }
            finally
            {
                fecharTransacao();
            }
        }

        public UsuarioRedeSocialDTO buscarPorId(UsuarioRedeSocialDTO usuarioRedeSocial)
        {
            try
            {
                iniciarTrasancao();
                usuarioRedeSocial = (UsuarioRedeSocialDTO)Sessao.Load(typeof(UsuarioRedeSocialDTO), usuarioRedeSocial.Codigo);
                return usuarioRedeSocial;
            }
            catch (Exception ex)
            {
                throw new ExcessaoPersistencia("Erro ao buscar Usuário da Rede Social.");
            }
            finally
            {
                fecharTransacao();
            }
        }

        public IList listarTodos()
        {
            try
            {
                iniciarTrasancao();
                IList UsuariosRedesSociais = Sessao.CreateCriteria(typeof(UsuarioRedeSocialDTO)).List();
                return UsuariosRedesSociais;
            }
            catch (Exception ex)
            {
                throw new ExcessaoPersistencia("Erro ao buscar Usuário da Rede Social.");
            }
            finally
            {
                fecharTransacao();
            }
        }
    }
}
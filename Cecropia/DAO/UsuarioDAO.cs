using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using Cecropia.DTO;
using Cecropia.Excessao;

namespace Cecropia.DAO
{
    public class UsuarioDAO : DAOGenerico
    {

        public void salvar(UsuarioDTO usuario)
        {
            try
            {
                iniciarTrasancao();
                Sessao.Save(usuario);
                commit();
            }
            catch (Exception ex)
            {
                rollBack();
                throw new ExcessaoPersistencia("Erro ao salvar Usuário.");
            }
            finally
            {
                fecharTransacao();
            }
        }

        public void atualizar(UsuarioDTO usuario)
        {
            try
            {
                iniciarTrasancao();
                Sessao.Update(usuario);
                commit();
            }
            catch (Exception ex)
            {
                rollBack();
                throw new ExcessaoPersistencia("Erro ao atualizar Usuário.");
            }
            finally
            {
                fecharTransacao();
            }
        }

        public void excluir(UsuarioDTO usuario)
        {
            try
            {
                iniciarTrasancao();
                Sessao.Delete(usuario);
                commit();
            }
            catch (Exception ex)
            {
                rollBack();
                throw new ExcessaoPersistencia("Erro ao excluir Usuário.");
            }
            finally
            {
                fecharTransacao();
            }
        }

        public UsuarioDTO buscarPorId(UsuarioDTO usuario)
        {
            try
            {
                iniciarTrasancao();
                usuario = (UsuarioDTO)Sessao.Load(typeof(UsuarioDTO), usuario.Codigo);
                return usuario;
            }
            catch (Exception ex)
            {
                throw new ExcessaoPersistencia("Erro ao buscar Usuário.");
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
                IList usuarios = Sessao.CreateCriteria(typeof(UsuarioDTO)).List();
                return usuarios;
            }
            catch (Exception ex)
            {
                throw new ExcessaoPersistencia("Erro ao buscar Usuário.");
            }
            finally
            {
                fecharTransacao();
            }
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cecropia.DTO;
using Cecropia.Excessao;

namespace Cecropia.DAO
{
    public class RedeSocialDAO : DAOGenerico
    {

        public void salvar(RedeSocialDTO redeSocial)
        {
            try
            {
                iniciarTrasancao();
                Sessao.Save(redeSocial);
                commit();
            }
            catch (Exception ex)
            {
                rollBack();
                throw new ExcessaoPersistencia("Erro ao salvar Rede Social.");
            }
            finally
            {
                fecharTransacao();
            }
        }

        public void atualizar(RedeSocialDTO redeSocial)
        {
            try
            {
                iniciarTrasancao();
                Sessao.Update(redeSocial);
                commit();
            }
            catch (Exception ex)
            {
                rollBack();
                throw new ExcessaoPersistencia("Erro ao atualizar Rede Social.");
            }
            finally
            {
                fecharTransacao();
            }
        }

        public void excluir(RedeSocialDTO redeSocial)
        {
            try
            {
                iniciarTrasancao();
                Sessao.Delete(redeSocial);
                commit();
            }
            catch (Exception ex)
            {
                rollBack();
                throw new ExcessaoPersistencia("Erro ao excluir Rede Social.");
            }
            finally
            {
                fecharTransacao();
            }
        }

        public RedeSocialDTO buscarPorId(RedeSocialDTO redeSocial)
        {
            try
            {
                iniciarTrasancao();
                redeSocial = (RedeSocialDTO)Sessao.Load(typeof(RedeSocialDTO), redeSocial.Codigo);
                return redeSocial;
            }
            catch (Exception ex)
            {
                throw new ExcessaoPersistencia("Erro ao buscar Rede Social.");
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
                IList redesSociais = Sessao.CreateCriteria(typeof(RedeSocialDTO)).List();
                return redesSociais;
            }
            catch (Exception ex)
            {
                throw new ExcessaoPersistencia("Erro ao buscar Rede Social.");
            }
            finally
            {
                fecharTransacao();
            }
        }
    }
}
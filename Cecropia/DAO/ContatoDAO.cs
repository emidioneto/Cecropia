using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cecropia.DTO;
using Cecropia.Excessao;

namespace Cecropia.DAO
{
    public class ContatoDAO : DAOGenerico
    {
        public void salvar(ContatoDTO contato)
        {
            try
            {
                iniciarTrasancao();
                Sessao.Save(contato);
                commit();
            }
            catch (Exception ex)
            {
                rollBack();
                throw new ExcessaoPersistencia("Erro ao salvar Contato.");
            }
            finally
            {
                fecharTransacao();
            }
        }

        public void atualizar(ContatoDTO contato)
        {
            try
            {
                iniciarTrasancao();
                Sessao.Update(contato);
                commit();
            }
            catch (Exception ex)
            {
                rollBack();
                throw new ExcessaoPersistencia("Erro ao atualizar Contato.");
            }
            finally
            {
                fecharTransacao();
            }
        }

        public void excluir(ContatoDTO contato)
        {
            try
            {
                iniciarTrasancao();
                Sessao.Delete(contato);
                commit();
            }
            catch (Exception ex)
            {
                rollBack();
                throw new ExcessaoPersistencia("Erro ao excluir Contato.");
            }
            finally
            {
                fecharTransacao();
            }
        }

        public ContatoDTO buscarPorId(ContatoDTO contato)
        {
            try
            {
                iniciarTrasancao();
                contato = (ContatoDTO)Sessao.Load(typeof(ContatoDTO), contato.Codigo);
                return contato;
            }
            catch (Exception ex)
            {
                throw new ExcessaoPersistencia("Erro ao buscar Contato.");
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
                IList contatos = Sessao.CreateCriteria(typeof(ContatoDTO)).List();
                return contatos;
            }
            catch (Exception ex)
            {
                throw new ExcessaoPersistencia("Erro ao buscar Contato.");
            }
            finally
            {
                fecharTransacao();
            }
        }

    }
}
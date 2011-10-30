using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cecropia.DTO;
using Cecropia.Excessao;

namespace Cecropia.DAO
{
    public class CategoriaDAO : DAOGenerico
    {

        public void salvar(CategoriaDTO categoria)
        {
            try
            {
                iniciarTrasancao();
                Sessao.Save(categoria);
                commit();
            }
            catch (Exception ex)
            {
                rollBack();
                throw new ExcessaoPersistencia("Erro ao salvar Categoria.");
            }
            finally
            {
                fecharTransacao();
            }
        }

        public void atualizar(CategoriaDTO categoria)
        {
            try
            {
                iniciarTrasancao();
                Sessao.Update(categoria);
                commit();
            }
            catch (Exception ex)
            {
                rollBack();
                throw new ExcessaoPersistencia("Erro ao atualizar Categoria.");
            }
            finally
            {
                fecharTransacao();
            }
        }

        public void excluir(CategoriaDTO categoria)
        {
            try
            {
                iniciarTrasancao();
                Sessao.Delete(categoria);
                commit();
            }
            catch (Exception ex)
            {
                rollBack();
                throw new ExcessaoPersistencia("Erro ao excluir Categoria.");
            }
            finally
            {
                fecharTransacao();
            }
        }

        public CategoriaDTO buscarPorId(CategoriaDTO categoria)
        {
            try
            {
                iniciarTrasancao();
                categoria = (CategoriaDTO)Sessao.Load(typeof(CategoriaDTO), categoria.Codigo);
                return categoria;
            }
            catch (Exception ex)
            {
                throw new ExcessaoPersistencia("Erro ao buscar Categoria.");
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
                IList categorias = Sessao.CreateCriteria(typeof(CategoriaDTO)).List();
                return categorias;
            }
            catch (Exception ex)
            {
                throw new ExcessaoPersistencia("Erro ao buscar Categoria.");
            }
            finally
            {
                fecharTransacao();
            }
        }
    }
}
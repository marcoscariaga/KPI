using SigProc.Domain.Contratos.Dados;
using SigProc.Domain.Contratos.Servicos;
using SigProc.Domain.Entidades;
using SigProc.Infra.Seguranca.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Domain.Servicos
{
    public class UsuarioDominioServico : IUsuarioDominioServico
    {
        private readonly IUsuarioRepositorio _repository;
        public UsuarioDominioServico(IUsuarioRepositorio repository)
        {
            _repository = repository;
        }

        public Usuario Atualizar(Usuario objeto)
        {
            #region O email atualizado não pode ser igual ao de outro contato
            var contatoByEmail = _repository.BuscarPorEmail(objeto.Email);
            if (contatoByEmail != null && !contatoByEmail.Id.Equals(objeto.Id))
                throw new ArgumentException("O email informado já pertence a outro usuario cadastrado.");
            #endregion

            #region O Cpf atualizado não pode ser igual ao de outro contato
            var contatoByCpf = _repository.BuscarPorCpf(objeto.Cpf);
            if (contatoByCpf != null && !contatoByCpf.Id.Equals(objeto.Id))
                throw new ArgumentException("O Cpf informado já pertence a outro usuario cadastrado.");
            #endregion

            objeto.Senha = CriptografiaServico.Encrypt(objeto.Senha);
            return _repository.Atualizar(objeto);
        }

        public Usuario BuscarPorCpf(string cpf)
            => _repository.BuscarPorCpf(cpf);

        public Usuario BuscarPorEmail(string email)
            => _repository.BuscarPorEmail(email);

        public Usuario Deletar(Usuario objeto)
        {
            return _repository.Deletar(objeto);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

        public Usuario Excluir(int id)
        {
            return _repository.Excluir(id);
        }

        public Usuario Get(string email, string senha)
            => _repository.Get(email, senha);

        public Usuario Inserir(Usuario objeto)
        {
            #region O email do contato deve ser único
            if (_repository.BuscarPorEmail(objeto.Email) != null)
                throw new ArgumentException("O email informado´já está cadastrado, tente outro.");
            #endregion

            #region O Cpf deve ser único
            if (_repository.BuscarPorCpf(objeto.Cpf) != null)
                throw new ArgumentException("O Cpf informado já está cadastrado, tente outro.");
            #endregion

            objeto.Senha = CriptografiaServico.Encrypt(objeto.Senha);
            return _repository.Inserir(objeto);
        }

        public ICollection<Usuario> ListarTudo()
            => _repository.ListarTudo().Where(c => c.DataExclusao == null).ToList();

        public Usuario RetornaPorId(int id)
            => _repository.RetornaPorId(id);
    }
}

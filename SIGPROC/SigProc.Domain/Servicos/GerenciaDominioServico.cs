using System;
using System.Collections.Generic;
using System.Linq;
using SigProc.Domain.Contratos.Servicos;
using SigProc.Domain.Entidades;
using SigProc.Dominio.Contratos.Dados;
using SigProc.Dominio.Contratos.Servicos;
using SigProc.Dominio.Entidades;
using SigProc.Infra.Seguranca.Servico;
using System.Diagnostics;

namespace SigProc.Dominio.Servicos
{
    public class GerenciaDominioServico : BaseDominioServico<Gerencia>, IGerenciaDominioServico
    {
        private readonly IGerenciaRepositorio _repositorio;
        private readonly IGerenciaPrazoDominioServico _repositorioPrazo;
        private readonly IGerenciaUsuarioDominioServico _repositorioGerenciaUsuario;
        private readonly ITipoUsuarioGerenciaDominioServico _repositorioTipoUsuaruiGerencia;

        public GerenciaDominioServico(IGerenciaRepositorio repository, IGerenciaPrazoDominioServico repositorioPrazo, IGerenciaUsuarioDominioServico repositorioGerenciaUsuario, ITipoUsuarioGerenciaDominioServico repositorioTipoUsuaruiGerencia) : base(repository)
        {
            _repositorio = repository;
            _repositorioPrazo = repositorioPrazo;
            _repositorioGerenciaUsuario = repositorioGerenciaUsuario;
            _repositorioTipoUsuaruiGerencia = repositorioTipoUsuaruiGerencia;
        }

        public ICollection<Gerencia> ListarAtivos()
        {
            return _repositorio.ListarAtivos();
        }

        public Gerencia Inserir(Gerencia objeto)
        {
            if (objeto.Prazo <= 0)
                throw new ArgumentException("Informe o prazo da gerência!");

            var verificaCodigo = _repositorio.ListarTudo().FirstOrDefault(x => x.Codigo == objeto.Codigo && x.Sigla == objeto.Sigla);
            if (verificaCodigo != null)
                throw new ArgumentException("A gerência já está cadastrada no sistema.");

            var gerencia = _repositorio.Inserir(objeto);

            GerenciaPrazo prazo = new GerenciaPrazo();
            try
            {
                prazo.IdGerencia = gerencia.Id;
                prazo.IdTipoPrazo = 1;
                prazo.Prazo = objeto.Prazo;
                prazo.IdUsuarioCadastro = objeto.IdUsuarioResp;
                prazo.Status = true;

                _repositorioPrazo.Inserir(prazo);
            }
            catch (Exception)
            {
                _repositorio.Deletar(gerencia);
                throw;
            }

            try
            {
                var tipoUsuario = _repositorioTipoUsuaruiGerencia.ListarAtivos().FirstOrDefault(x => x.Descricao.ToLower().Equals("gerente"));

                GerenciaUsuario usuario = new GerenciaUsuario()
                {
                    IdGerencia = gerencia.Id,
                    IdUsuarioGerencia = objeto.IdUsuarioResp,
                    IdTipoUsuarioGerencia = tipoUsuario.Id,
                    IdUsuarioCadastro = objeto.IdUsuarioResp,
                    Status = true,
                };

                _repositorioGerenciaUsuario.Inserir(usuario);
            }
            catch (Exception)
            {
                _repositorio.Deletar(gerencia);
                _repositorioPrazo.Deletar(prazo);
                throw;
            }

            return gerencia;
        }
        public Gerencia Atualizar(Gerencia objeto)
        {
            if (objeto.Id <= 0)
                throw new ArgumentException("O ID da gerência é inválido!");

            if (objeto.Prazo <= 0)
                throw new ArgumentException("Informe o prazo da gerência!");

            var verificaCodigo = _repositorio.ListarTudo().FirstOrDefault(x =>
                x.Codigo == objeto.Codigo &&
                x.Sigla == objeto.Sigla &&
                x.Id != objeto.Id
            );
            if (verificaCodigo != null)
                throw new ArgumentException("Já existe uma gerência cadastrada com o mesmo código e sigla!");

            var gerenciaAtual = _repositorio.ObterPorId(objeto.Id);
            if (gerenciaAtual == null)
                throw new ArgumentException("A gerência não existe!");

            gerenciaAtual.Codigo = objeto.Codigo;
            gerenciaAtual.Sigla = objeto.Sigla;
            gerenciaAtual.Descricao = objeto.Descricao;
            gerenciaAtual.Prazo = objeto.Prazo;

            _repositorio.Atualizar(gerenciaAtual);
            _repositorio.Salvar(); // Salva as alterações no repositório

            return gerenciaAtual;
        }




        public ICollection<Gerencia> Atualizar()
        {
            throw new NotImplementedException();
        }

        public Gerencia ObterPorId(object id)
        {
            throw new NotImplementedException();
        }
    }
}

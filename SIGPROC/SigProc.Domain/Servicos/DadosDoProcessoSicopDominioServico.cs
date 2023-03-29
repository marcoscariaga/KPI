using AutoMapper;
using SigProc.Domain.Contratos.Servicos;
using SigProc.Domimio.Contratos.Dados;
using SigProc.Domimio.Contratos.Servicos;
using SigProc.Domimio.Entidades;
using SigProc.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Domimio.Servicos
{
    public class DadosDoProcessoSicopDominioServico : IDadosDoProcessoSicopDominioServico
    {
        private readonly IDadosDoProcessoSicopRepositorio _repository;
        private IMapper _mapper;
        public DadosDoProcessoSicopDominioServico(IDadosDoProcessoSicopRepositorio repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public DadosDoProcessoSicop Atualizar(DadosDoProcessoSicop processo)
        {
            return _repository.Atualizar(processo);
        }

        public DadosDoProcessoSicop Deletar(DadosDoProcessoSicop objeto)
        {
            return _repository.Deletar(objeto);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

        public DadosDoProcessoSicop Excluir(int id)
        {
            return _repository.Excluir(id);
        }

        public DadosDoProcessoSicop Inserir(DadosDoProcessoSicop processo)
        {
            var verificaCadatro = _repository.ListarTudo().Where(x => x.NumeroDoProcesso == processo.NumeroDoProcesso).FirstOrDefault();

            if (verificaCadatro != null)
            {
                verificaCadatro.Rotina = "";
                verificaCadatro.NumeroDoProcesso = processo.NumeroDoProcesso;
                verificaCadatro.DocumentacaoDoIdentificador = processo.DocumentacaoDoIdentificador;
                verificaCadatro.InformacaoVolume = processo.InformacaoVolume;
                verificaCadatro.InformacaoTela = processo.InformacaoTela;
                verificaCadatro.PastaDeAssentamento = processo.PastaDeAssentamento;
                verificaCadatro.NomeDoRequerente = processo.NomeDoRequerente;
                verificaCadatro.OrgaoDeOrigem = processo.OrgaoDeOrigem;
                verificaCadatro.Endereco = processo.Endereco;
                verificaCadatro.Cep = processo.Cep;
                verificaCadatro.Bairro = processo.Bairro;
                verificaCadatro.Telefone = processo.Telefone;
                verificaCadatro.TipoDoDocumento = processo.TipoDoDocumento;
                verificaCadatro.DescricaoDoTipoDoDocumento = processo.DescricaoDoTipoDoDocumento;
                verificaCadatro.NumeroDoTipoDoDocumento = processo.NumeroDoTipoDoDocumento;
                verificaCadatro.OrgaoDoDocumento = processo.OrgaoDoDocumento;
                verificaCadatro.InformacaoTela1 = processo.InformacaoTela1;
                verificaCadatro.InformacaoTela2 = processo.InformacaoTela2;
                verificaCadatro.InformacaoTela3 = processo.InformacaoTela3;
                verificaCadatro.InformacaoTela4 = processo.InformacaoTela4;
                verificaCadatro.InformacaoTela5 = processo.InformacaoTela5;
                verificaCadatro.AutoDeInfracao = processo.AutoDeInfracao;
                verificaCadatro.InformacaoTela6 = processo.InformacaoTela6;
                verificaCadatro.InformacaoTela7 = processo.InformacaoTela7;
                verificaCadatro.InformacaoTela8 = processo.InformacaoTela8;
                verificaCadatro.CodigoAssunto = processo.CodigoAssunto;
                verificaCadatro.InformacaoComplementar1 = processo.InformacaoComplementar1;
                verificaCadatro.InformacaoComplementar2 = processo.InformacaoComplementar2;
                verificaCadatro.InformacaoComplementar3 = processo.InformacaoComplementar3;
                verificaCadatro.DataDoProcesso = processo.DataDoProcesso;
                verificaCadatro.DataDeCadastroDeProcesso = processo.DataDeCadastroDeProcesso;
                verificaCadatro.HoraDeCadastroDoProcesso = processo.HoraDeCadastroDoProcesso;
                verificaCadatro.MatriculaRecebedorCadastro = processo.MatriculaRecebedorCadastro;
                verificaCadatro.MatriculaDigitadorProcesso = processo.MatriculaDigitadorProcesso;
                verificaCadatro.ProcessoPrincipal = processo.ProcessoPrincipal;
                verificaCadatro.IdentificacaoProcesso = processo.IdentificacaoProcesso;
                verificaCadatro.NovoPosicionamento = processo.NovoPosicionamento;
                verificaCadatro.InformacaoTela9 = processo.InformacaoTela9;
                verificaCadatro.InformacaoTela10 = processo.InformacaoTela10;
                verificaCadatro.MatriculaDigitadorTramitacao = processo.MatriculaDigitadorTramitacao;
                verificaCadatro.DataDigitacaoTramitacao = processo.DataDigitacaoTramitacao;
                verificaCadatro.DataDeRecebimentoTramitacao = processo.DataDeRecebimentoTramitacao;
                verificaCadatro.InformacaoTela11 = processo.InformacaoTela11;
                verificaCadatro.InformacaoTela12 = processo.InformacaoTela12;
                verificaCadatro.DataDeDespachoTramitacao = processo.DataDeDespachoTramitacao;
                verificaCadatro.MatriculaDoDespachoTramitacao = processo.MatriculaDoDespachoTramitacao;
                verificaCadatro.MatriculaDoRecebedorTramitacao = processo.MatriculaDoRecebedorTramitacao;
                verificaCadatro.NumeroGuiaTramitacao = processo.NumeroGuiaTramitacao;
                verificaCadatro.SequenciaTramitacao = processo.SequenciaTramitacao;
                verificaCadatro.OrgaoOrigemTramitacao = processo.OrgaoOrigemTramitacao;
                verificaCadatro.OrgaoDestinoTramitacao = processo.OrgaoDestinoTramitacao;
                verificaCadatro.EnderecoDestinoProcessoTramitacao = processo.EnderecoDestinoProcessoTramitacao;
                verificaCadatro.DespachoProcessoTramitacao = processo.DespachoProcessoTramitacao;
                verificaCadatro.DataEdicao = new DateTime();
                verificaCadatro.StatusLine = "";
                verificaCadatro.Status = true;
                return _repository.Atualizar(verificaCadatro);
            }
            else
            {
                return _repository.Inserir(_mapper.Map<DadosDoProcessoSicop>(processo));
            }
        }

        public ICollection<DadosDoProcessoSicop> ListarTudo()
            => _repository.ListarTudo().Where(c => c.DataExclusao == null).ToList();

        public DadosDoProcessoSicop RetornaPorId(int id)
            => _repository.RetornaPorId(id);
    }
}

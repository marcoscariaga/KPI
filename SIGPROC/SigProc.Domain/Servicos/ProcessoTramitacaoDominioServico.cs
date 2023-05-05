using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using SigProc.Domain.Contratos.Servicos;
using SigProc.Domain.Entidades;
using SigProc.Domimio.Contratos.Dados;
using SigProc.Domimio.Contratos.Servicos;
using SigProc.Domimio.Entidades;
using SigProc.Dominio.Contratos.Dados;
using SigProc.Dominio.Contratos.Servicos;
using SigProc.Dominio.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SigProc.Dominio.Servicos
{

    public class ProcessoTramitacaoDominioServico : BaseDominioServico<ProcessoTramitacao>, IProcessoTramitacaoDominioServico
    {
        private readonly IProcessoTramitacaoRepositorio _repositorio;
        private readonly IGerenciaPrazoRepositorio _gerenciaPrazo;
        private readonly IGerenciaUsuarioRepositorio _gerenciaUsuario;
        private readonly IGerenciaRepositorio _gerencia;
        private readonly IFeriadoRepositorio _feriadoRepositorio;
        private readonly IDespachoRepositorio _despachoRepositorio;
        private readonly IDadosDeTramitacaoSicopDominioServico _dadosDoProcessodominioServico;

        public ProcessoTramitacaoDominioServico(IProcessoTramitacaoRepositorio repository, IGerenciaPrazoRepositorio gerenciaPrazo,
            IGerenciaUsuarioRepositorio gerenciaUsuario, IGerenciaRepositorio gerencia, IFeriadoRepositorio feriadoRepositorio,
            IDespachoRepositorio despachoRepositorio, IDadosDeTramitacaoSicopDominioServico dadosDoProcessodominioServico) : base(repository)
        {
            _repositorio = repository;
            _gerenciaPrazo = gerenciaPrazo;
            _gerenciaUsuario = gerenciaUsuario;
            _gerencia = gerencia;
            _feriadoRepositorio = feriadoRepositorio;
            _despachoRepositorio = despachoRepositorio;
            _dadosDoProcessodominioServico = dadosDoProcessodominioServico;
        }

        public ProcessoTramitacao BuscarUltimaTramitacaoPorNumeroProcesso(string numeroProcesso)
        {
            return _repositorio.BuscarUltimaTramitacaoPorNumeroProcesso(numeroProcesso);
        }

        public ICollection<ProcessoTramitacao> ListarAtivos()
        {
            return _repositorio.ListarAtivos();
        }
        public ProcessoTramitacao Inserir(ProcessoTramitacao processoTramitacao)
        {
            var tramitacoes = _dadosDoProcessodominioServico.ConsultarProcesso(processoTramitacao.NumeroProcesso);
            var ultimaTramitacao = _repositorio.BuscarUltimaTramitacaoPorNumeroProcesso(processoTramitacao.NumeroProcesso);
            var tramitacaoConvertida = ConverteTramitacao(tramitacoes);

            var desc = tramitacaoConvertida.ItensTramitacao.OrderBy(x=>x.Sequencia).ToList();

            ////excluir a lista
            var list = new List<ProcessoTramitacao>();

            for (var i = 0; i < desc.Count; i++)
            {
                var item = desc[i];

                //if (Convert.ToInt32(ultimaTramitacao.Sequencia) > Convert.ToInt32(tramitacaoConvertida.ItensTramitacao[i].Sequencia) && ultimaTramitacao != null)
                //{
                    var tramitacaoAtual = new ProcessoTramitacao()
                    {
                        IdOrgaoOrigem = item.OrgaoDeOrigem,
                        IdOrgaoDestino = (int?)desc[i].OrgaoDeDestino,
                        Despacho = item.Despacho,
                        IdProcesso = processoTramitacao.IdProcesso,
                        MatriculaRecebedor = item.MatRec,
                        MatriculaDigitador = item.MatDig,
                        NumeroProcesso = processoTramitacao.NumeroProcesso,
                        Prazo = 0,
                        TempoEnvio = _repositorio.ContarDiasUteis(DateTime.Parse(item.DataRecebimento), (DateTime?)DateTime.Parse(item.DataDoDespacho)),
                        TempoPrazo = 0,
                        Guia = Convert.ToInt32(item.Guia),
                        Sequencia = Convert.ToInt32(item.Sequencia),
                        DataEnvio = (DateTime?)DateTime.Parse(item.DataDoDespacho),
                        DataRecebimento = DateTime.Parse(item.DataRecebimento),
                        DataTramitacao = (DateTime?)DateTime.Parse(item.DataDoDespacho),
                        DataPrazo = new DateTime()
                    };

                    list.Add(tramitacaoAtual);

                      _repositorio.Inserir(tramitacaoAtual);
                //}
                //else if (Convert.ToInt32(ultimaTramitacao.Sequencia) == Convert.ToInt32(tramitacaoConvertida.ItensTramitacao[i].Sequencia) && ultimaTramitacao != null)
                //{
                //    var atualizaTramitacaoNova = new ProcessoTramitacao()
                //    {
                //        Id = ultimaTramitacao.Id,
                //        IdOrgaoDestino = (int?)tramitacaoConvertida.ItensTramitacao[i].OrgaoDeDestino,
                //        Despacho = item.Despacho,
                //        IdProcesso = processoTramitacao.IdProcesso,
                //        MatriculaRecebedor = item.MatRec,
                //        MatriculaDigitador = item.MatDig,
                //        NumeroProcesso = processoTramitacao.NumeroProcesso,
                //        TempoEnvio = _repositorio.ContarDiasUteis(DateTime.Parse(item.DataRecebimento), (DateTime?)DateTime.Parse(item.DataDoDespacho)),
                //        TempoPrazo = 0,
                //        Guia = Convert.ToInt32(item.Guia),
                //        Sequencia = Convert.ToInt32(item.Sequencia),
                //        DataEnvio = (DateTime?)DateTime.Parse(item.DataDoDespacho),
                //        DataRecebimento = DateTime.Parse(item.DataRecebimento),
                //        DataTramitacao = (DateTime?)DateTime.Parse(item.DataDoDespacho),
                //        DataPrazo = new DateTime()
                //    };
                //    _repositorio.Atualizar(atualizaTramitacaoNova);
                //}
                //else
                //{
                //    var tramitacaoAtual = new ProcessoTramitacao()
                //    {
                //        IdOrgaoOrigem = item.OrgaoDeOrigem,
                //        IdOrgaoDestino = (int?)tramitacaoConvertida.ItensTramitacao[i].OrgaoDeDestino,
                //        Despacho = item.Despacho,
                //        IdProcesso = processoTramitacao.IdProcesso,
                //        MatriculaRecebedor = item.MatRec,
                //        MatriculaDigitador = item.MatDig,
                //        NumeroProcesso = processoTramitacao.NumeroProcesso,
                //        Prazo = 0,
                //        TempoEnvio = _repositorio.ContarDiasUteis(DateTime.Parse(item.DataRecebimento), (DateTime?)DateTime.Parse(item.DataDoDespacho)),
                //        TempoPrazo = 0,
                //        Guia = Convert.ToInt32(item.Guia),
                //        Sequencia = Convert.ToInt32(item.Sequencia),
                //        DataEnvio = (DateTime?)DateTime.Parse(item.DataDoDespacho),
                //        DataRecebimento = DateTime.Parse(item.DataRecebimento),
                //        DataTramitacao = (DateTime?)DateTime.Parse(item.DataDoDespacho),
                //        DataPrazo = new DateTime()
                //    };

                //    list.Add(tramitacaoAtual);
                //    _repositorio.Inserir(tramitacaoAtual);
                //}

            }
            var prazo = _gerenciaPrazo.ListarTudo().Where(x => x.IdGerencia.Equals(tramitacaoConvertida.ItensTramitacao[11].OrgaoDeDestino)).OrderByDescending(x => x.Prazo).FirstOrDefault();
            var feriados = _feriadoRepositorio.ListarDatas();

            DateTime dataAtual = DateTime.Parse(desc[11].DataDoDespacho);
            int diasParaAcrescentar = prazo.Prazo;

            DateTime dataFutura = dataAtual;
            int diasAcrescentados = 0;
            while (diasAcrescentados < diasParaAcrescentar)
            {
                dataFutura = dataFutura.AddDays(1);
                if (dataFutura.DayOfWeek != DayOfWeek.Saturday && dataFutura.DayOfWeek != DayOfWeek.Sunday && !feriados.Contains(dataFutura))
                {
                    diasAcrescentados++;
                }
            }

            var tempoPrazo = dataFutura - DateTime.Today;

            var novaTramitacao = new ProcessoTramitacao()
            {
                IdOrgaoOrigem = desc[11].OrgaoDeDestino,
                IdOrgaoDestino = null,
                Despacho = null,
                IdProcesso = processoTramitacao.IdProcesso,
                MatriculaRecebedor = null,
                MatriculaDigitador = null,
                NumeroProcesso = processoTramitacao.NumeroProcesso,
                Prazo = diasAcrescentados,
                TempoEnvio = 0,
                TempoPrazo = _repositorio.CalculaPrazo(DateTime.Parse(desc[11].DataDoDespacho), prazo.Prazo).Days,
                Guia = 0,
                Sequencia = Convert.ToInt32(desc[11].Sequencia) + 1,
                DataEnvio = null,
                DataRecebimento = DateTime.Parse(desc[11].DataDoDespacho),
                DataTramitacao = null,
                DataPrazo = dataFutura,
            };
            list.Add(novaTramitacao);
              _repositorio.Inserir(novaTramitacao);



            return (novaTramitacao);
        }

        public ICollection<ProcessoTramitacao> BuscarTramitacoesPorNumeroProcesso(string numeroProcesso)
        {
            return _repositorio.BuscarTramitacoesPorNumeroProcesso(numeroProcesso);
        }

        public ICollection<ProcessoTramitacao> BuscarUltimaTramitacaoPorIdGerenciaAtual(int idGerencia)
        {
            return _repositorio.BuscarUltimaTramitacaoPorIdGerenciaAtual(idGerencia);
        }

        public ICollection<ProcessoTramitacao> BuscarUltimaTramitacaoPorUsuarioGerencial(int idUsuario)
        {
            var gerencias = _gerenciaUsuario.ListarGerenciaPorIdUsuario(idUsuario);

            return gerencias.SelectMany(g => _repositorio.BuscarUltimaTramitacaoPorUsuarioGerencial(g.IdGerencia)).ToList();

        }
        public int VerificaGerencia(string textoGerencia)
        {
            Match numeroGerencia = Regex.Match(textoGerencia, @"\d{8}");
            string codigoGerencia = Convert.ToInt32(numeroGerencia.Value).ToString();

            var gerencia = _gerencia.ListarTudo().Where(x => x.Codigo.Equals(codigoGerencia.Trim())).FirstOrDefault();
            if (gerencia == null)
                throw new ArgumentException($"A gerência {gerencia}, não está cadastrada no sistema.");

            return gerencia.Id;
        }
        public string VerificaDespacho(string textoDespacho)
        {
            Match numeroDespacho = Regex.Match(textoDespacho, @"\d+");
            string codigoDespacho = Convert.ToString(numeroDespacho.Value).ToString();

            var despacho = _despachoRepositorio.ListarTudo().Where(x => x.Codigo.Equals(codigoDespacho.Trim())).FirstOrDefault();
            if (despacho == null)
                throw new ArgumentException($"A gerência {despacho}, não está cadastrada no sistema.");

            return despacho.Descricao;
        }
        public DadosDeTramitacao ConverteTramitacao(DadosDeTramitacaoSicop dados)
        {

            var dadosTramitacao = new DadosDeTramitacao
            {
                Rotina = dados.Rotina,
                NumeroDoProcesso = dados.NumeroDoProcesso,
                Opcao = dados.Opcao,
                Concad = dados.Concad,
                StatusLine = dados.StatusLine,
                ItensTramitacao = new List<ItemTramitacaoSicop>()
            };

            for (int i = 1; i <= 12; i++)
            {
                var item = new ItemTramitacaoSicop
                {
                    Item = (string)dados.GetType().GetProperty($"Item_{i:D2}").GetValue(dados),
                    MatDig = (string)dados.GetType().GetProperty($"MatDig_{i:D2}").GetValue(dados),
                    MatRec = (string)dados.GetType().GetProperty($"MatRec_{i:D2}").GetValue(dados),
                    OrgaoDeDestino = VerificaGerencia((string)dados.GetType().GetProperty($"OrgaoDeDestino_{i:D2}").GetValue(dados)),
                    OrgaoDeOrigem = VerificaGerencia((string)dados.GetType().GetProperty($"OrgaoDeDestino_{i + 1:D2}").GetValue(dados)),
                    DataDoDespacho = (string)dados.GetType().GetProperty($"DataDoDespacho_{i:D2}").GetValue(dados),
                    DataRecebimento = (string)dados.GetType().GetProperty($"DataDoDespacho_{i + 1:D2}").GetValue(dados),
                    Sequencia = (string)dados.GetType().GetProperty($"Sequencia_{i:D2}").GetValue(dados),
                    Guia = (string)dados.GetType().GetProperty($"Guia_{i:D2}").GetValue(dados),
                    Despacho = (string)dados.GetType().GetProperty($"Despacho_{i:D2}").GetValue(dados)
                };

                dadosTramitacao.ItensTramitacao.Add(item);
            }

            return dadosTramitacao;
        }

        public DadosDeTramitacao Testando(DadosDeTramitacaoSicop processoTramitacao)
        {
            var verifica = ConverteTramitacao(processoTramitacao);
            return verifica;
        }


        ICollection<ProcessoTramitacao> IProcessoTramitacaoDominioServico.Verificar(ProcessoTramitacao processoTramitacao)
        {
            var tramitacoes = _dadosDoProcessodominioServico.ConsultarProcesso(processoTramitacao.NumeroProcesso);
            var ultimaTramitacao = _repositorio.BuscarUltimaTramitacaoPorNumeroProcesso(processoTramitacao.NumeroProcesso);
            var tramitacaoConvertida = ConverteTramitacao(tramitacoes);



            ////excluir a lista
            var list = new List<ProcessoTramitacao>();

            for (var i = 0; i < 10; i++)
            {
                var item = tramitacaoConvertida.ItensTramitacao[i];

                if (Convert.ToInt32(ultimaTramitacao.Sequencia) > Convert.ToInt32(tramitacaoConvertida.ItensTramitacao[i].Sequencia) && ultimaTramitacao != null)
                {
                    var tramitacaoAtual = new ProcessoTramitacao()
                    {
                        IdOrgaoOrigem = item.OrgaoDeOrigem,
                        IdOrgaoDestino = (int?)tramitacaoConvertida.ItensTramitacao[i].OrgaoDeDestino,
                        Despacho = item.Despacho,
                        IdProcesso = processoTramitacao.IdProcesso,
                        MatriculaRecebedor = item.MatRec,
                        MatriculaDigitador = item.MatDig,
                        NumeroProcesso = processoTramitacao.NumeroProcesso,
                        Prazo = 0,
                        TempoEnvio = _repositorio.ContarDiasUteis(DateTime.Parse(item.DataRecebimento), (DateTime?)DateTime.Parse(item.DataDoDespacho)),
                        TempoPrazo = 0,
                        Guia = Convert.ToInt32(item.Guia),
                        Sequencia = Convert.ToInt32(item.Sequencia),
                        DataEnvio = (DateTime?)DateTime.Parse(item.DataDoDespacho),
                        DataRecebimento = DateTime.Parse(item.DataRecebimento),
                        DataTramitacao = (DateTime?)DateTime.Parse(item.DataDoDespacho),
                        DataPrazo = new DateTime()
                    };

                    list.Add(tramitacaoAtual);

                    //  _repositorio.Inserir(tramitacaoAtual);
                }
                else if (Convert.ToInt32(ultimaTramitacao.Sequencia) == Convert.ToInt32(tramitacaoConvertida.ItensTramitacao[i].Sequencia) && ultimaTramitacao != null)
                {
                    var atualizaTramitacaoNova = new ProcessoTramitacao()
                    {
                        Id = ultimaTramitacao.Id,
                        IdOrgaoDestino = (int?)tramitacaoConvertida.ItensTramitacao[i].OrgaoDeDestino,
                        Despacho = item.Despacho,
                        IdProcesso = processoTramitacao.IdProcesso,
                        MatriculaRecebedor = item.MatRec,
                        MatriculaDigitador = item.MatDig,
                        NumeroProcesso = processoTramitacao.NumeroProcesso,
                        TempoEnvio = _repositorio.ContarDiasUteis(DateTime.Parse(item.DataRecebimento), (DateTime?)DateTime.Parse(item.DataDoDespacho)),
                        TempoPrazo = 0,
                        Guia = Convert.ToInt32(item.Guia),
                        Sequencia = Convert.ToInt32(item.Sequencia),
                        DataEnvio = (DateTime?)DateTime.Parse(item.DataDoDespacho),
                        DataRecebimento = DateTime.Parse(item.DataRecebimento),
                        DataTramitacao = (DateTime?)DateTime.Parse(item.DataDoDespacho),
                        DataPrazo = new DateTime()
                    };
                    _repositorio.Atualizar(atualizaTramitacaoNova);
                }
                else
                {
                    var tramitacaoAtual = new ProcessoTramitacao()
                    {
                        IdOrgaoOrigem = item.OrgaoDeOrigem,
                        IdOrgaoDestino = (int?)tramitacaoConvertida.ItensTramitacao[i].OrgaoDeDestino,
                        Despacho = item.Despacho,
                        IdProcesso = processoTramitacao.IdProcesso,
                        MatriculaRecebedor = item.MatRec,
                        MatriculaDigitador = item.MatDig,
                        NumeroProcesso = processoTramitacao.NumeroProcesso,
                        Prazo = 0,
                        TempoEnvio = _repositorio.ContarDiasUteis(DateTime.Parse(item.DataRecebimento), (DateTime?)DateTime.Parse(item.DataDoDespacho)),
                        TempoPrazo = 0,
                        Guia = Convert.ToInt32(item.Guia),
                        Sequencia = Convert.ToInt32(item.Sequencia),
                        DataEnvio = (DateTime?)DateTime.Parse(item.DataDoDespacho),
                        DataRecebimento = DateTime.Parse(item.DataRecebimento),
                        DataTramitacao = (DateTime?)DateTime.Parse(item.DataDoDespacho),
                        DataPrazo = new DateTime()
                    };

                    list.Add(tramitacaoAtual);
                }

            }
            var prazo = _gerenciaPrazo.ListarTudo().Where(x => x.IdGerencia.Equals(tramitacaoConvertida.ItensTramitacao[0].OrgaoDeDestino)).OrderByDescending(x => x.Prazo).FirstOrDefault();
            var feriados = _feriadoRepositorio.ListarDatas();

            DateTime dataAtual = DateTime.Parse(tramitacaoConvertida.ItensTramitacao[0].DataDoDespacho);
            int diasParaAcrescentar = prazo.Prazo;

            DateTime dataFutura = dataAtual;
            int diasAcrescentados = 0;
            while (diasAcrescentados < diasParaAcrescentar)
            {
                dataFutura = dataFutura.AddDays(1);
                if (dataFutura.DayOfWeek != DayOfWeek.Saturday && dataFutura.DayOfWeek != DayOfWeek.Sunday && !feriados.Contains(dataFutura))
                {
                    diasAcrescentados++;
                }
            }

            var tempoPrazo = dataFutura - DateTime.Today;

            var novaTramitacao = new ProcessoTramitacao()
            {
                IdOrgaoOrigem = tramitacaoConvertida.ItensTramitacao[0].OrgaoDeDestino,
                IdOrgaoDestino = null,
                Despacho = null,
                IdProcesso = processoTramitacao.IdProcesso,
                MatriculaRecebedor = null,
                MatriculaDigitador = null,
                NumeroProcesso = processoTramitacao.NumeroProcesso,
                Prazo = diasAcrescentados,
                TempoEnvio = 0,
                TempoPrazo = _repositorio.CalculaPrazo(DateTime.Parse(tramitacaoConvertida.ItensTramitacao[0].DataDoDespacho), prazo.Prazo).Days,
                Guia = 0,
                Sequencia = Convert.ToInt32(tramitacaoConvertida.ItensTramitacao[0].Sequencia) + 1,
                DataEnvio = null,
                DataRecebimento = DateTime.Parse(tramitacaoConvertida.ItensTramitacao[0].DataDoDespacho),
                DataTramitacao = null,
                DataPrazo = dataFutura,
            };
            list.Add(novaTramitacao);
            //  _repositorio.Inserir(tramitacaoNova);



            return (list.OrderByDescending(x => x.Sequencia)).ToList();
        }

        public class ItemTramitacaoSicop
        {
            public string Item { get; set; }
            public string MatDig { get; set; }
            public string MatRec { get; set; }
            public int OrgaoDeDestino { get; set; }
            public int OrgaoDeOrigem { get; set; }
            public string DataDoDespacho { get; set; }
            public string? DataRecebimento { get; set; }
            public string Sequencia { get; set; }
            public string Guia { get; set; }
            public string Despacho { get; set; }
        }
        public class DadosDeTramitacao : Base
        {
            public string Rotina { get; set; }
            public string NumeroDoProcesso { get; set; }
            public string Opcao { get; set; }
            public string Concad { get; set; }
            public string StatusLine { get; set; }
            public List<ItemTramitacaoSicop> ItensTramitacao { get; set; }
        }

    }

}


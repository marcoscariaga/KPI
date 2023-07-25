using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using Microsoft.IdentityModel.Tokens;
using SigProc.Domain.Contratos.Servicos;
using SigProc.Domain.Entidades;
using SigProc.Domimio.Contratos.Dados;
using SigProc.Domimio.Contratos.Servicos;
using SigProc.Domimio.Entidades;
using SigProc.Dominio.Contratos.Dados;
using SigProc.Dominio.Contratos.Servicos;
using SigProc.Dominio.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
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
        private readonly IProcessoRepositorio _processoRepositorio;

        public ProcessoTramitacaoDominioServico(IProcessoTramitacaoRepositorio repository, IGerenciaPrazoRepositorio gerenciaPrazo,
            IGerenciaUsuarioRepositorio gerenciaUsuario, IGerenciaRepositorio gerencia, IFeriadoRepositorio feriadoRepositorio,
            IDespachoRepositorio despachoRepositorio, IDadosDeTramitacaoSicopDominioServico dadosDoProcessodominioServico, IProcessoRepositorio processoRepositorio) : base(repository)
        {
            _repositorio = repository;
            _gerenciaPrazo = gerenciaPrazo;
            _gerenciaUsuario = gerenciaUsuario;
            _gerencia = gerencia;
            _feriadoRepositorio = feriadoRepositorio;
            _despachoRepositorio = despachoRepositorio;
            _dadosDoProcessodominioServico = dadosDoProcessodominioServico;
            _processoRepositorio = processoRepositorio;
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
            var processo = _processoRepositorio.BuscarPorNumeroProcesso(processoTramitacao.NumeroProcesso);
            var tramitacoes = _dadosDoProcessodominioServico.ConsultarProcesso(processoTramitacao.NumeroProcesso);
            var ultimaTramitacao = _repositorio.BuscarUltimaTramitacaoPorNumeroProcesso(processoTramitacao.NumeroProcesso);
            var tramitacaoConvertida = ConverteTramitacao(tramitacoes);

            var desc = tramitacaoConvertida.ItensTramitacao.OrderBy(x => x.Sequencia).ToList();
            // condição para tratar se a primeira data for null

            int lastIndex = desc.Count - 1;
            for (var i = 0; i < desc.Count; i++)
            {
                if (desc[0].DataRecebimento == string.Empty)
                {
                    desc[0].DataRecebimento = "01/01/0001";
                    //desc[0].OrgaoDeOrigem = VerificaGerencia(processo.OrgaoCadastro);
                }
                var item = desc[i];

                var prazoTramitacaoSicop = _gerenciaPrazo.ListarTudo().Where(x => x.IdGerencia.Equals(item.OrgaoDeOrigem)).OrderByDescending(x => x.Prazo).FirstOrDefault();
                var tempoRestanteTramitacaoSicop = _repositorio.CalculaPrazo(DateTime.Parse(item.DataDoDespacho), prazoTramitacaoSicop.Prazo);

                bool isLast = i == lastIndex; // Verifica se o índice é o último

                if (isLast)
                {
                    var tramitacaoAtual = new ProcessoTramitacao()
                    {
                        IdOrgaoOrigem = item.OrgaoDeOrigem,
                        IdOrgaoDestino = (int?)desc[i].OrgaoDeDestino,
                        Despacho = item.Despacho,
                        IdProcesso = processoTramitacao.IdProcesso,
                        MatriculaRecebedor = item.MatRec,
                        MatriculaDigitador = item.MatDig,
                        NumeroProcesso = processoTramitacao.NumeroProcesso,
                        Prazo = prazoTramitacaoSicop.Prazo,
                        TempoEnvio = _repositorio.ContarDiasUteis(DateTime.Parse(item.DataRecebimento), (DateTime?)DateTime.Parse(item.DataDoDespacho)).diasUteisRestantes,
                        TempoPrazo = tempoRestanteTramitacaoSicop.diasRestantes.Days,
                        Guia = Convert.ToInt32(item.Guia),
                        Sequencia = Convert.ToInt32(item.Sequencia),
                        DataEnvio = null,
                        DataRecebimento = item.DataRecebimento == "" ? null : DateTime.Parse(item.DataRecebimento),
                        DataTramitacao = (DateTime?)DateTime.Parse(item.DataDoDespacho),
                        DataPrazo = tempoRestanteTramitacaoSicop.dataFutura,
                        Status = true
                    };

                    _repositorio.Inserir(tramitacaoAtual);
                }
                else
                {
                    var tramitacaoAtual = new ProcessoTramitacao()
                    {
                        IdOrgaoOrigem = item.OrgaoDeOrigem,
                        IdOrgaoDestino = (int?)desc[i].OrgaoDeDestino,
                        Despacho = item.Despacho,
                        IdProcesso = processoTramitacao.IdProcesso,
                        MatriculaRecebedor = item.MatRec,
                        MatriculaDigitador = item.MatDig,
                        NumeroProcesso = processoTramitacao.NumeroProcesso,
                        Prazo = prazoTramitacaoSicop.Prazo,
                        TempoEnvio = _repositorio.ContarDiasUteis(DateTime.Parse(item.DataRecebimento), (DateTime?)DateTime.Parse(item.DataDoDespacho)).diasUteisRestantes,
                        TempoPrazo = 0,
                        Guia = Convert.ToInt32(item.Guia),
                        Sequencia = Convert.ToInt32(item.Sequencia),
                        DataEnvio = (DateTime?)DateTime.Parse(item.DataDoDespacho),
                        DataRecebimento = item.DataRecebimento == "" ? null : DateTime.Parse(item.DataRecebimento),
                        DataTramitacao = (DateTime?)DateTime.Parse(item.DataDoDespacho),
                        DataPrazo = tempoRestanteTramitacaoSicop.dataFutura,
                        Status = true
                    };

                    _repositorio.Inserir(tramitacaoAtual);
                }

            }
            return (processoTramitacao);
        }

        public ProcessoTramitacao AtualizaTramitacao(ProcessoTramitacao processoTramitacao)
        {
            var idProcesso = processoTramitacao.IdProcesso;
            var numeroProcesso = processoTramitacao.NumeroProcesso;
            var tramitacoes = _dadosDoProcessodominioServico.ConsultarProcesso(processoTramitacao.NumeroProcesso);
            processoTramitacao = _repositorio.BuscarUltimaTramitacaoPorNumeroProcesso(processoTramitacao.NumeroProcesso);
            var tramitacaoConvertida = ConverteTramitacao(tramitacoes);
            var prazo = 0;
            var desc = tramitacaoConvertida.ItensTramitacao.OrderBy(x => x.Sequencia).ToList();

            if (processoTramitacao != null)
            {
                foreach (var item in desc)
                {
                    bool isLast = item.Equals(desc.Last());
                    if (isLast)
                    {
                        if (Convert.ToInt32(item.Sequencia) > processoTramitacao.Sequencia)
                        {
                            var prazoTramitacaoSicop = _gerenciaPrazo.ListarTudo().Where(x => x.IdGerencia.Equals(item.OrgaoDeDestino)).OrderByDescending(x => x.Prazo).FirstOrDefault();
                            var tempoRestanteTramitacaoSicop = _repositorio.CalculaPrazo(DateTime.Parse(item.DataDoDespacho), prazoTramitacaoSicop.Prazo);
                            var tramitacaoAtual = new ProcessoTramitacao()
                            {
                                IdOrgaoOrigem = item.OrgaoDeOrigem,
                                IdOrgaoDestino = item.OrgaoDeDestino,
                                Despacho = item.Despacho,
                                IdProcesso = processoTramitacao.IdProcesso,
                                MatriculaRecebedor = item.MatRec,
                                MatriculaDigitador = item.MatDig,
                                NumeroProcesso = processoTramitacao.NumeroProcesso,
                                Prazo = prazoTramitacaoSicop.Prazo,
                                TempoEnvio = _repositorio.ContarDiasUteis(DateTime.Parse(item.DataRecebimento), (DateTime?)DateTime.Parse(item.DataDoDespacho)).diasUteisRestantes,
                                TempoPrazo = tempoRestanteTramitacaoSicop.diasRestantes.Days,
                                Guia = Convert.ToInt32(item.Guia),
                                Sequencia = Convert.ToInt32(item.Sequencia),
                                DataEnvio = null,
                                DataRecebimento = DateTime.Parse(item.DataRecebimento),
                                DataTramitacao = (DateTime?)DateTime.Parse(item.DataDoDespacho),
                                DataPrazo = tempoRestanteTramitacaoSicop.dataFutura,
                                Status = true
                            };

                            _repositorio.Inserir(tramitacaoAtual);

                            var sequencia = (Convert.ToInt32(item.Sequencia) - 1);

                            var atualizaProcesso = _repositorio.ListarTudo().Where(x => x.Sequencia.Equals(sequencia) && x.IdProcesso.Equals(tramitacaoAtual.IdProcesso)).FirstOrDefault();
                            var dataRecebimento = item.DataRecebimento;
                            atualizaProcesso.TempoEnvio = string.IsNullOrEmpty(dataRecebimento) ? null : _repositorio.ContarDiasUteis(DateTime.Parse(dataRecebimento), (DateTime?)DateTime.Parse(item.DataDoDespacho)).diasUteisRestantes;
                            atualizaProcesso.DataEnvio = dataRecebimento == null ? null : (DateTime?)DateTime.Parse(item.DataDoDespacho);

                            _repositorio.Atualizar(atualizaProcesso);
                        };
                    }
                    else
                    {
                        if (Convert.ToInt32(item.Sequencia) > processoTramitacao.Sequencia)
                        {
                            prazo = _gerenciaPrazo.ListarTudo().Where(x => x.IdGerencia.Equals(item.OrgaoDeDestino)).OrderByDescending(x => x.Prazo).FirstOrDefault().Prazo;
                            var tramitacaoAtual = new ProcessoTramitacao()
                            {
                                IdOrgaoOrigem = item.OrgaoDeOrigem,
                                IdOrgaoDestino = item.OrgaoDeDestino,
                                Despacho = item.Despacho,
                                IdProcesso = processoTramitacao.IdProcesso,
                                MatriculaRecebedor = item.MatRec,
                                MatriculaDigitador = item.MatDig,
                                NumeroProcesso = processoTramitacao.NumeroProcesso,
                                Prazo = prazo,
                                TempoEnvio = _repositorio.ContarDiasUteis(DateTime.Parse(item.DataRecebimento), (DateTime?)DateTime.Parse(item.DataDoDespacho)).diasUteisRestantes,
                                TempoPrazo = 0,//_repositorio.CalculaPrazo(DateTime.Parse(desc[11].DataDoDespacho), prazo).diasRestantes.Days,
                                Guia = Convert.ToInt32(item.Guia),
                                Sequencia = Convert.ToInt32(item.Sequencia),
                                DataEnvio = (DateTime?)DateTime.Parse(item.DataDoDespacho),
                                DataRecebimento = DateTime.Parse(item.DataRecebimento),
                                DataTramitacao = (DateTime?)DateTime.Parse(item.DataDoDespacho),
                                DataPrazo = _repositorio.CalculaPrazo(DateTime.Parse(item.DataDoDespacho), prazo).dataFutura,
                                Status = true
                            };

                            _repositorio.Inserir(tramitacaoAtual);

                            var sequencia = (Convert.ToInt32(item.Sequencia) - 1);

                            var atualizaProcesso = _repositorio.ListarTudo().Where(x => x.Sequencia.Equals(sequencia) && x.IdProcesso.Equals(tramitacaoAtual.IdProcesso)).FirstOrDefault();
                            var dataRecebimento = item.DataRecebimento;
                            atualizaProcesso.TempoEnvio = string.IsNullOrEmpty(dataRecebimento) ? null : _repositorio.ContarDiasUteis(DateTime.Parse(dataRecebimento), (DateTime?)DateTime.Parse(item.DataDoDespacho)).diasUteisRestantes;
                            atualizaProcesso.DataEnvio = dataRecebimento == null ? null : (DateTime?)DateTime.Parse(item.DataDoDespacho);

                            _repositorio.Atualizar(atualizaProcesso);
                        }
                    }
                }
            }
            else
            {
                int lastIndex = desc.Count - 1;
                for (var i = 0; i < desc.Count; i++)
                {
                    var item = desc[i];

                    var prazoTramitacaoSicop = _gerenciaPrazo.ListarTudo().Where(x => x.IdGerencia.Equals(item.OrgaoDeDestino)).OrderByDescending(x => x.Prazo).FirstOrDefault();
                    var tempoRestanteTramitacaoSicop = _repositorio.CalculaPrazo(DateTime.Parse(item.DataDoDespacho), prazoTramitacaoSicop.Prazo);

                    bool isLast = i == lastIndex; // Verifica se o índice é o último

                    if (isLast)
                    {
                        var tramitacaoAtual = new ProcessoTramitacao()
                        {
                            IdOrgaoOrigem = item.OrgaoDeOrigem,
                            IdOrgaoDestino = (int?)desc[i].OrgaoDeDestino,
                            Despacho = item.Despacho,
                            IdProcesso = idProcesso,
                            MatriculaRecebedor = item.MatRec,
                            MatriculaDigitador = item.MatDig,
                            NumeroProcesso = numeroProcesso,
                            Prazo = prazoTramitacaoSicop.Prazo,
                            TempoEnvio = item.DataRecebimento == "" ? null : _repositorio.ContarDiasUteis(DateTime.Parse(item.DataRecebimento), (DateTime?)DateTime.Parse(item.DataDoDespacho)).diasUteisRestantes,
                            TempoPrazo = tempoRestanteTramitacaoSicop.diasRestantes.Days,
                            Guia = Convert.ToInt32(item.Guia),
                            Sequencia = Convert.ToInt32(item.Sequencia),
                            DataEnvio = null,
                            DataRecebimento = item.DataRecebimento == "" ? null : DateTime.Parse(item.DataRecebimento),
                            DataTramitacao = (DateTime?)DateTime.Parse(item.DataDoDespacho),
                            DataPrazo = tempoRestanteTramitacaoSicop.dataFutura,
                            Status = true
                        };

                        _repositorio.Inserir(tramitacaoAtual);
                    }
                    else
                    {
                        var tramitacaoAtual = new ProcessoTramitacao()
                        {
                            IdOrgaoOrigem = item.OrgaoDeOrigem,
                            IdOrgaoDestino = (int?)desc[i].OrgaoDeDestino,
                            Despacho = item.Despacho,
                            IdProcesso = idProcesso,
                            MatriculaRecebedor = item.MatRec,
                            MatriculaDigitador = item.MatDig,
                            NumeroProcesso = numeroProcesso,
                            Prazo = prazoTramitacaoSicop.Prazo,
                            TempoEnvio = _repositorio.ContarDiasUteis(DateTime.Parse(item.DataRecebimento), (DateTime?)DateTime.Parse(item.DataDoDespacho)).diasUteisRestantes,
                            TempoPrazo = 0,
                            Guia = Convert.ToInt32(item.Guia),
                            Sequencia = Convert.ToInt32(item.Sequencia),
                            DataEnvio = (DateTime?)DateTime.Parse(item.DataDoDespacho),
                            DataRecebimento = item.DataRecebimento == "" ? null : DateTime.Parse(item.DataRecebimento),
                            DataTramitacao = (DateTime?)DateTime.Parse(item.DataDoDespacho),
                            DataPrazo = tempoRestanteTramitacaoSicop.dataFutura,
                            Status = true
                        };

                        _repositorio.Inserir(tramitacaoAtual);
                    }

                }

            }

            return (processoTramitacao);
        }
        public ProcessoTramitacao AtualizaTramitacoesEtapaProcesso(ProcessoTramitacao processoTramitacao)
        {
            var tempoRestanteTramitacaoSicop = _repositorio.CalculaPrazo((DateTime)processoTramitacao.DataRecebimento, processoTramitacao.Prazo);

            processoTramitacao.TempoPrazo = tempoRestanteTramitacaoSicop.diasRestantes.Days;
            processoTramitacao.DataPrazo = tempoRestanteTramitacaoSicop.dataFutura;

            return _repositorio.Atualizar(processoTramitacao);
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


            return _repositorio.BuscarUltimaTramitacaoPorUsuarioGerencial(idUsuario);

        }
        public int VerificaGerencia(string textoGerencia)
        {
            if (textoGerencia == "" || textoGerencia == null)
                throw new ArgumentException($"A gerência {textoGerencia}, não está cadastrada no sistema.");

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
                if ((string)dados.GetType().GetProperty($"Item_{i:D2}").GetValue(dados) != "")
                {
                    string orgaoDestinoAtual = (string)dados.GetType().GetProperty($"OrgaoDeDestino_{i:D2}").GetValue(dados);
                    string orgaoDestinoProximo = (string)dados.GetType().GetProperty($"OrgaoDeDestino_{i + 1:D2}").GetValue(dados);
                    var item = new ItemTramitacaoSicop
                    {
                        Item = (string)dados.GetType().GetProperty($"Item_{i:D2}").GetValue(dados),
                        MatDig = (string)dados.GetType().GetProperty($"MatDig_{i:D2}").GetValue(dados),
                        MatRec = (string)dados.GetType().GetProperty($"MatRec_{i:D2}").GetValue(dados),
                        OrgaoDeDestino = string.IsNullOrEmpty(orgaoDestinoAtual) ? null : VerificaGerencia(orgaoDestinoAtual),
                        OrgaoDeOrigem = string.IsNullOrEmpty(orgaoDestinoProximo) ? null : VerificaGerencia(orgaoDestinoProximo),
                        DataDoDespacho = (string)dados.GetType().GetProperty($"DataDoDespacho_{i:D2}").GetValue(dados),
                        DataRecebimento = (string)dados.GetType().GetProperty($"DataDoDespacho_{i + 1:D2}").GetValue(dados),
                        Sequencia = (string)dados.GetType().GetProperty($"Sequencia_{i:D2}").GetValue(dados),
                        Guia = (string)dados.GetType().GetProperty($"Guia_{i:D2}").GetValue(dados),
                        Despacho = (string)dados.GetType().GetProperty($"Despacho_{i:D2}").GetValue(dados)
                    };

                    dadosTramitacao.ItensTramitacao.Add(item);
                }

            }

            return dadosTramitacao;
        }

        public ProcessoTramitacao SalvarMensagem(ProcessoTramitacao processoTramitacao)
        {
            return _repositorio.Atualizar(processoTramitacao);
        }

        public class ItemTramitacaoSicop
        {
            public string Item { get; set; }
            public string MatDig { get; set; }
            public string MatRec { get; set; }
            public int? OrgaoDeDestino { get; set; }
            public int? OrgaoDeOrigem { get; set; }
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


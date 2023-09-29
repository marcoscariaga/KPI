using KPI.Configurations;
using KPI.Models;
using Microsoft.EntityFrameworkCore;

namespace KPI.Data;

public partial class SisvisaContext : DbContext
{
    public SisvisaContext()
    {
    }

    public SisvisaContext(DbContextOptions<SisvisaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AcaoEducativaO> AcaoEducativaOs { get; set; }

    public virtual DbSet<AcaoEducativaRealizadum> AcaoEducativaRealizada { get; set; }

    public virtual DbSet<AcaoSisvisa> AcaoSisvisas { get; set; }

    public virtual DbSet<AcaoSisvisaNaoConformidadePadronizadum> AcaoSisvisaNaoConformidadePadronizada { get; set; }

    public virtual DbSet<AcaoSisvisaTarefa> AcaoSisvisaTarefas { get; set; }

    public virtual DbSet<AlimentoComercializado> AlimentoComercializados { get; set; }

    public virtual DbSet<AmbulanciaRequerimentoTransitorio> AmbulanciaRequerimentoTransitorios { get; set; }

    public virtual DbSet<Ambulante> Ambulantes { get; set; }

    public virtual DbSet<AnexoAcaoSisvisa> AnexoAcaoSisvisas { get; set; }

    public virtual DbSet<Area> Areas { get; set; }

    public virtual DbSet<ArquivoExtracaoMultum> ArquivoExtracaoMulta { get; set; }

    public virtual DbSet<ArquivoMultum> ArquivoMulta { get; set; }

    public virtual DbSet<ArquivoPostagemMultum> ArquivoPostagemMulta { get; set; }

    public virtual DbSet<ArquivosRepa> ArquivosRepas { get; set; }

    public virtual DbSet<AspnetApplication> AspnetApplications { get; set; }

    public virtual DbSet<AspnetRole> AspnetRoles { get; set; }

    public virtual DbSet<AspnetSchemaVersion> AspnetSchemaVersions { get; set; }

    public virtual DbSet<AspnetUser> AspnetUsers { get; set; }

    public virtual DbSet<AssinaturaCertificadoAcaoEducativa> AssinaturaCertificadoAcaoEducativas { get; set; }

    public virtual DbSet<Assunto> Assuntos { get; set; }

    public virtual DbSet<AssuntoPrograma> AssuntoProgramas { get; set; }

    public virtual DbSet<AssuntosDoModelo> AssuntosDoModelos { get; set; }

    public virtual DbSet<AssuntosDoRoteiro> AssuntosDoRoteiros { get; set; }

    public virtual DbSet<AssuntosDoRoteiroPrograma> AssuntosDoRoteiroProgramas { get; set; }

    public virtual DbSet<Atividade> Atividades { get; set; }

    public virtual DbSet<AtividadeAmbulante> AtividadeAmbulantes { get; set; }

    public virtual DbSet<AtividadeDoRequerimentoTransitorio> AtividadeDoRequerimentoTransitorios { get; set; }

    public virtual DbSet<AtividadeEspecialidade> AtividadeEspecialidades { get; set; }

    public virtual DbSet<AtividadeFeirante> AtividadeFeirantes { get; set; }

    public virtual DbSet<AtividadeParaRequerimentoTransitorio> AtividadeParaRequerimentoTransitorios { get; set; }

    public virtual DbSet<AtividadeProcedimentoFarmacium> AtividadeProcedimentoFarmacia { get; set; }

    public virtual DbSet<AtividadeSecundariaUnidadePublica> AtividadeSecundariaUnidadePublicas { get; set; }

    public virtual DbSet<AtividadeSecundarium> AtividadeSecundaria { get; set; }

    public virtual DbSet<AtividadesDaAutorizacao> AtividadesDaAutorizacaos { get; set; }

    public virtual DbSet<AtividadesDoEstabelecimento> AtividadesDoEstabelecimentos { get; set; }

    public virtual DbSet<AtividadesDoRequerimento> AtividadesDoRequerimentos { get; set; }

    public virtual DbSet<AtividadesDoRequerimentoAdministrativo> AtividadesDoRequerimentoAdministrativos { get; set; }

    public virtual DbSet<AtividadesDoTermoVisitaSanitarium> AtividadesDoTermoVisitaSanitaria { get; set; }

    public virtual DbSet<AtividadesRequerimentoDuplicada> AtividadesRequerimentoDuplicadas { get; set; }

    public virtual DbSet<AtividadesSecundariasDoEstabelecimento> AtividadesSecundariasDoEstabelecimentos { get; set; }

    public virtual DbSet<Auditorium> Auditoria { get; set; }

    public virtual DbSet<AutoInfracaoAssinado> AutoInfracaoAssinados { get; set; }

    public virtual DbSet<AutorizacaoSanitarium> AutorizacaoSanitaria { get; set; }

    public virtual DbSet<BancaJornal> BancaJornals { get; set; }

    public virtual DbSet<BancaJornalProdutoBancaJornal> BancaJornalProdutoBancaJornals { get; set; }

    public virtual DbSet<CapitulacaoLegal> CapitulacaoLegals { get; set; }

    public virtual DbSet<CapitulacaoLegalInspecao> CapitulacaoLegalInspecaos { get; set; }

    public virtual DbSet<CapitulacoesLegaisDoEditalInterdicao> CapitulacoesLegaisDoEditalInterdicaos { get; set; }

    public virtual DbSet<CapitulacoesLegaisDoNotificacaoInfracao> CapitulacoesLegaisDoNotificacaoInfracaos { get; set; }

    public virtual DbSet<CapitulacoesLegaisDoTermoIntimacao> CapitulacoesLegaisDoTermoIntimacaos { get; set; }

    public virtual DbSet<Cargo> Cargos { get; set; }

    public virtual DbSet<CategoriaProduto> CategoriaProdutos { get; set; }

    public virtual DbSet<ChancelaProcesso> ChancelaProcessos { get; set; }

    public virtual DbSet<CobrancaSisvisa> CobrancaSisvisas { get; set; }

    public virtual DbSet<Competencium> Competencia { get; set; }

    public virtual DbSet<ComplementoDeInformaco> ComplementoDeInformacoes { get; set; }

    public virtual DbSet<Complexidade> Complexidades { get; set; }

    public virtual DbSet<ConfiguracaoProgramaColetaAmostrasProduto> ConfiguracaoProgramaColetaAmostrasProdutos { get; set; }

    public virtual DbSet<Creche> Creches { get; set; }

    public virtual DbSet<CursoParaAcaoEducativa> CursoParaAcaoEducativas { get; set; }

    public virtual DbSet<DemandaProcessosOffLine> DemandaProcessosOffLines { get; set; }

    public virtual DbSet<DescricaoAutoInfracao> DescricaoAutoInfracaos { get; set; }

    public virtual DbSet<DespachoAcaoSisvisa> DespachoAcaoSisvisas { get; set; }

    public virtual DbSet<DocumentoAnexado> DocumentoAnexados { get; set; }

    public virtual DbSet<DocumentosAcaoSisvisa> DocumentosAcaoSisvisas { get; set; }

    public virtual DbSet<EditaisInterdicaoEmMonitoramentoDaTarefa> EditaisInterdicaoEmMonitoramentoDaTarefas { get; set; }

    public virtual DbSet<EditalInterdicao> EditalInterdicaos { get; set; }

    public virtual DbSet<EmpresaOutorga> EmpresaOutorgas { get; set; }

    public virtual DbSet<EmpresasRelacionadasEvento> EmpresasRelacionadasEventos { get; set; }

    public virtual DbSet<EscolaMunicipal> EscolaMunicipals { get; set; }

    public virtual DbSet<EspecialidadeClinica> EspecialidadeClinicas { get; set; }

    public virtual DbSet<Estabelecimento> Estabelecimentos { get; set; }

    public virtual DbSet<EstabelecimentoLicenciadoLss> EstabelecimentoLicenciadoLsses { get; set; }

    public virtual DbSet<EstabelecimentoMultum> EstabelecimentoMulta { get; set; }

    public virtual DbSet<EstacaoTransportePublico> EstacaoTransportePublicos { get; set; }

    public virtual DbSet<Evento> Eventos { get; set; }

    public virtual DbSet<EventoAmbulante> EventoAmbulantes { get; set; }

    public virtual DbSet<EventoBancaJornal> EventoBancaJornals { get; set; }

    public virtual DbSet<EventoEstabelecimento> EventoEstabelecimentos { get; set; }

    public virtual DbSet<EventoFeirante> EventoFeirantes { get; set; }

    public virtual DbSet<FaixaDeNumeroAutoInfracao> FaixaDeNumeroAutoInfracaos { get; set; }

    public virtual DbSet<FaixaDeNumeroCorreio> FaixaDeNumeroCorreios { get; set; }

    public virtual DbSet<FaixaNumeracaoNotificacaoLaudo> FaixaNumeracaoNotificacaoLaudos { get; set; }

    public virtual DbSet<FaixaNumeracaoO> FaixaNumeracaoOs { get; set; }

    public virtual DbSet<Feirante> Feirantes { get; set; }

    public virtual DbSet<FeiranteFeira> FeiranteFeiras { get; set; }

    public virtual DbSet<FilaEmail> FilaEmails { get; set; }

    public virtual DbSet<FinalidadeVeiculo> FinalidadeVeiculos { get; set; }

    public virtual DbSet<FinalidadesDoVeiculo> FinalidadesDoVeiculos { get; set; }

    public virtual DbSet<FiscalMultum> FiscalMulta { get; set; }

    public virtual DbSet<FornecedorDoEvento> FornecedorDoEventos { get; set; }

    public virtual DbSet<GenerosAlimenticiosDoVeiculo> GenerosAlimenticiosDoVeiculos { get; set; }

    public virtual DbSet<GrupoAtividade> GrupoAtividades { get; set; }

    public virtual DbSet<GrupoAtividadeClassificadum> GrupoAtividadeClassificada { get; set; }

    public virtual DbSet<HistoricoAmbulante> HistoricoAmbulantes { get; set; }

    public virtual DbSet<HistoricoAtividadeAmbulante> HistoricoAtividadeAmbulantes { get; set; }

    public virtual DbSet<HistoricoAtividadeEconomicaSinae> HistoricoAtividadeEconomicaSinaes { get; set; }

    public virtual DbSet<HistoricoAtividadeFeirante> HistoricoAtividadeFeirantes { get; set; }

    public virtual DbSet<HistoricoAtividadesDoEstabelecimento> HistoricoAtividadesDoEstabelecimentos { get; set; }

    public virtual DbSet<HistoricoBancaJornal> HistoricoBancaJornals { get; set; }

    public virtual DbSet<HistoricoBancaJornalProduto> HistoricoBancaJornalProdutos { get; set; }

    public virtual DbSet<HistoricoDeLicenca> HistoricoDeLicencas { get; set; }

    public virtual DbSet<HistoricoEstabelecimento> HistoricoEstabelecimentos { get; set; }

    public virtual DbSet<HistoricoFeirante> HistoricoFeirantes { get; set; }

    public virtual DbSet<HistoricoFeiranteFeira> HistoricoFeiranteFeiras { get; set; }

    public virtual DbSet<HistoricoInspecao> HistoricoInspecaos { get; set; }

    public virtual DbSet<HistoricoProdutoBancaJornal> HistoricoProdutoBancaJornals { get; set; }

    public virtual DbSet<HistoricoRequerenteTokenCpe> HistoricoRequerenteTokenCpes { get; set; }

    public virtual DbSet<Hotel> Hotels { get; set; }

    public virtual DbSet<Justificativa> Justificativas { get; set; }

    public virtual DbSet<Laboratorio> Laboratorios { get; set; }

    public virtual DbSet<Laudo> Laudos { get; set; }

    public virtual DbSet<Legislacao> Legislacaos { get; set; }

    public virtual DbSet<LicencaCanceladaPorRequerente> LicencaCanceladaPorRequerentes { get; set; }

    public virtual DbSet<LicencaDeVeiculo> LicencaDeVeiculos { get; set; }

    public virtual DbSet<LicencaVeiculoCanceladaPorRequerente> LicencaVeiculoCanceladaPorRequerentes { get; set; }

    public virtual DbSet<LogDeCandidatoMultum> LogDeCandidatoMulta { get; set; }

    public virtual DbSet<LogDeMultum> LogDeMulta { get; set; }

    public virtual DbSet<LogDePagamento> LogDePagamentos { get; set; }

    public virtual DbSet<LogDeTaxa> LogDeTaxas { get; set; }

    public virtual DbSet<ManualSisvisa> ManualSisvisas { get; set; }

    public virtual DbSet<MensagemSisvisa> MensagemSisvisas { get; set; }

    public virtual DbSet<MensagemZapCarioca> MensagemZapCariocas { get; set; }

    public virtual DbSet<ModeloDeDarm> ModeloDeDarms { get; set; }

    public virtual DbSet<ModeloDeEmail> ModeloDeEmails { get; set; }

    public virtual DbSet<ModeloRoteiro> ModeloRoteiros { get; set; }

    public virtual DbSet<MultaArquivoMultum> MultaArquivoMulta { get; set; }

    public virtual DbSet<MultaFaltaLicenciamento> MultaFaltaLicenciamentos { get; set; }

    public virtual DbSet<MultaOld> MultaOlds { get; set; }

    public virtual DbSet<Multum> Multa { get; set; }

    public virtual DbSet<Municipio> Municipios { get; set; }

    public virtual DbSet<NaoConformidadePadronizadum> NaoConformidadePadronizada { get; set; }

    public virtual DbSet<NaoConformidadesDoTermoIntimacao> NaoConformidadesDoTermoIntimacaos { get; set; }

    public virtual DbSet<NotificacaoInfracao> NotificacaoInfracaos { get; set; }

    public virtual DbSet<NotificacaoLaudo> NotificacaoLaudos { get; set; }

    public virtual DbSet<NumeroSicop> NumeroSicops { get; set; }

    public virtual DbSet<ObjetoValorado> ObjetoValorados { get; set; }

    public virtual DbSet<OrdemServico> OrdemServicos { get; set; }

    public virtual DbSet<OutroLocal> OutroLocals { get; set; }

    public virtual DbSet<PagamentoSisvisa> PagamentoSisvisas { get; set; }

    public virtual DbSet<Pai> Pais { get; set; }

    public virtual DbSet<ParametroSisvisa> ParametroSisvisas { get; set; }

    public virtual DbSet<ParceiroParaAcaoEducativa> ParceiroParaAcaoEducativas { get; set; }

    public virtual DbSet<PareceresDoRequerimento> PareceresDoRequerimentos { get; set; }

    public virtual DbSet<PareceresDoRoteiroParaInspecao> PareceresDoRoteiroParaInspecaos { get; set; }

    public virtual DbSet<PareceresDosVeiculosDoRequerimento> PareceresDosVeiculosDoRequerimentos { get; set; }

    public virtual DbSet<PareceresDosVeiculosParaInspecao> PareceresDosVeiculosParaInspecaos { get; set; }

    public virtual DbSet<ParticipanteAcaoEducativaRealizadum> ParticipanteAcaoEducativaRealizada { get; set; }

    public virtual DbSet<PendenciasDoEstabelecimento> PendenciasDoEstabelecimentos { get; set; }

    public virtual DbSet<PerguntaDoAssuntoPrograma> PerguntaDoAssuntoProgramas { get; set; }

    public virtual DbSet<PerguntaPrograma> PerguntaProgramas { get; set; }

    public virtual DbSet<PerguntasDoAssunto> PerguntasDoAssuntos { get; set; }

    public virtual DbSet<PerguntasDoModelo> PerguntasDoModelos { get; set; }

    public virtual DbSet<PerguntasDoRoteiro> PerguntasDoRoteiros { get; set; }

    public virtual DbSet<PerguntasDoRoteiroPrograma> PerguntasDoRoteiroProgramas { get; set; }

    public virtual DbSet<Perguntum> Pergunta { get; set; }

    public virtual DbSet<Piscina> Piscinas { get; set; }

    public virtual DbSet<PontoColetaVigiagua> PontoColetaVigiaguas { get; set; }

    public virtual DbSet<PosicaoFeiranteFeira> PosicaoFeiranteFeiras { get; set; }

    public virtual DbSet<PrioridadeDaAcaoSisvisa> PrioridadeDaAcaoSisvisas { get; set; }

    public virtual DbSet<ProcedimentoFarmacium> ProcedimentoFarmacia { get; set; }

    public virtual DbSet<Produto> Produtos { get; set; }

    public virtual DbSet<ProdutoBancaJornal> ProdutoBancaJornals { get; set; }

    public virtual DbSet<ProdutoTermoApreensao> ProdutoTermoApreensaos { get; set; }

    public virtual DbSet<Programa> Programas { get; set; }

    public virtual DbSet<Protocolo> Protocolos { get; set; }

    public virtual DbSet<RegistroRepa> RegistroRepas { get; set; }

    public virtual DbSet<Requerente> Requerentes { get; set; }

    public virtual DbSet<RequerenteTokenCpe> RequerenteTokenCpes { get; set; }

    public virtual DbSet<RequerimentoAdministrativo> RequerimentoAdministrativos { get; set; }

    public virtual DbSet<RequerimentoAutodeclaracao> RequerimentoAutodeclaracaos { get; set; }

    public virtual DbSet<RequerimentoTransitorio> RequerimentoTransitorios { get; set; }

    public virtual DbSet<RequerimentoTransitorioAnexo> RequerimentoTransitorioAnexos { get; set; }

    public virtual DbSet<RequerimentoTransitorioDeObra> RequerimentoTransitorioDeObras { get; set; }

    public virtual DbSet<RequerimentoTransitorioFornecedorAlimento> RequerimentoTransitorioFornecedorAlimentos { get; set; }

    public virtual DbSet<RequerimentoTransitorioFornecedorSaude> RequerimentoTransitorioFornecedorSaudes { get; set; }

    public virtual DbSet<RequerimentoTransitorioFornecedorZoonose> RequerimentoTransitorioFornecedorZoonoses { get; set; }

    public virtual DbSet<RequerimentoTransitorioObraInfra> RequerimentoTransitorioObraInfras { get; set; }

    public virtual DbSet<RespostasDoRequerimento> RespostasDoRequerimentos { get; set; }

    public virtual DbSet<RespostasDoRequerimentoAdministrativo> RespostasDoRequerimentoAdministrativos { get; set; }

    public virtual DbSet<RespostasDoRoteiroParaInspecao> RespostasDoRoteiroParaInspecaos { get; set; }

    public virtual DbSet<RespostasDoVeiculoAdministrativo> RespostasDoVeiculoAdministrativos { get; set; }

    public virtual DbSet<RespostasDoVeiculoLicenciamento> RespostasDoVeiculoLicenciamentos { get; set; }

    public virtual DbSet<RespostasDoVeiculoParaInspecao> RespostasDoVeiculoParaInspecaos { get; set; }

    public virtual DbSet<RestricoesDoEstabelecimento> RestricoesDoEstabelecimentos { get; set; }

    public virtual DbSet<Risco> Riscos { get; set; }

    public virtual DbSet<Roteiro> Roteiros { get; set; }

    public virtual DbSet<RoteiroPrograma> RoteiroProgramas { get; set; }

    public virtual DbSet<SegmentosDaAcaoSisvisa> SegmentosDaAcaoSisvisas { get; set; }

    public virtual DbSet<SegmentosDoRequerimento> SegmentosDoRequerimentos { get; set; }

    public virtual DbSet<SegmentosDoRequerimentoAdministrativo> SegmentosDoRequerimentoAdministrativos { get; set; }

    public virtual DbSet<SegmentosValidacaoLicenca> SegmentosValidacaoLicencas { get; set; }

    public virtual DbSet<ServicoEventoDoRequerimentoTransitorio> ServicoEventoDoRequerimentoTransitorios { get; set; }

    public virtual DbSet<ServidoArquivoMultum> ServidoArquivoMulta { get; set; }

    public virtual DbSet<Servidor> Servidors { get; set; }

    public virtual DbSet<ServidorArquivoMultum> ServidorArquivoMulta { get; set; }

    public virtual DbSet<ServidorAtividade> ServidorAtividades { get; set; }

    public virtual DbSet<ServidorCertificado> ServidorCertificados { get; set; }

    public virtual DbSet<ServidorCompetencia> ServidorCompetencias { get; set; }

    public virtual DbSet<ServidorEscalaTrabalho> ServidorEscalaTrabalhos { get; set; }

    public virtual DbSet<ServidorGrupoAtividade> ServidorGrupoAtividades { get; set; }

    public virtual DbSet<ServidorInatividade> ServidorInatividades { get; set; }

    public virtual DbSet<ServidoresOrdemServico> ServidoresOrdemServicos { get; set; }

    public virtual DbSet<Setor> Setors { get; set; }

    public virtual DbSet<SmfAtividade> SmfAtividades { get; set; }

    public virtual DbSet<SmfEstabelecimento> SmfEstabelecimentos { get; set; }

    public virtual DbSet<SmfPendente> SmfPendentes { get; set; }

    public virtual DbSet<SmfRestricao> SmfRestricaos { get; set; }

    public virtual DbSet<Surto> Surtos { get; set; }

    public virtual DbSet<Tarefa> Tarefas { get; set; }

    public virtual DbSet<TarifaRepa> TarifaRepas { get; set; }

    public virtual DbSet<TermoApreensao> TermoApreensaos { get; set; }

    public virtual DbSet<TermoApreensaoAmostraAnalise> TermoApreensaoAmostraAnalises { get; set; }

    public virtual DbSet<TermoIntimacao> TermoIntimacaos { get; set; }

    public virtual DbSet<TermoResponsabilidade> TermoResponsabilidades { get; set; }

    public virtual DbSet<TermoVigilanciaSanitarium> TermoVigilanciaSanitaria { get; set; }

    public virtual DbSet<TermoVisitaSanitarium> TermoVisitaSanitaria { get; set; }

    public virtual DbSet<TermosIntimacaoEmMonitoramentoDaTarefa> TermosIntimacaoEmMonitoramentoDaTarefas { get; set; }

    public virtual DbSet<TipoAutorizacaoSanitarium> TipoAutorizacaoSanitaria { get; set; }

    public virtual DbSet<TipoDeAlimentoVeiculo> TipoDeAlimentoVeiculos { get; set; }

    public virtual DbSet<TipoDeLicenciamento> TipoDeLicenciamentos { get; set; }

    public virtual DbSet<TipoDeResiduoDoVeiculo> TipoDeResiduoDoVeiculos { get; set; }

    public virtual DbSet<TipoProdutoVeiculo> TipoProdutoVeiculos { get; set; }

    public virtual DbSet<TipoPublicoAlvoRoteiro> TipoPublicoAlvoRoteiros { get; set; }

    public virtual DbSet<TipoResiduoVeiculo> TipoResiduoVeiculos { get; set; }

    public virtual DbSet<TipoServicoVeiculo> TipoServicoVeiculos { get; set; }

    public virtual DbSet<TipoTermoLicenciamento> TipoTermoLicenciamentos { get; set; }

    public virtual DbSet<TipoVeiculo> TipoVeiculos { get; set; }

    public virtual DbSet<TiposDeProdutoDoVeiculo> TiposDeProdutoDoVeiculos { get; set; }

    public virtual DbSet<TiposDeServicoDoVeiculo> TiposDeServicoDoVeiculos { get; set; }

    public virtual DbSet<UnidadePublicaSaude> UnidadePublicaSaudes { get; set; }

    public virtual DbSet<Veiculo> Veiculos { get; set; }

    public virtual DbSet<Veterinario> Veterinarios { get; set; }

    public virtual DbSet<VisitasDeInspecaoDoEstabelecimento> VisitasDeInspecaoDoEstabelecimentos { get; set; }

    public virtual DbSet<VwAspnetApplication> VwAspnetApplications { get; set; }

    public virtual DbSet<VwAspnetRole> VwAspnetRoles { get; set; }

    public virtual DbSet<VwAspnetUser> VwAspnetUsers { get; set; }

    public virtual DbSet<VwAspnetUsersInRole> VwAspnetUsersInRoles { get; set; }

    public virtual DbSet<VwAtivDoRequAutodecPosTi> VwAtivDoRequAutodecPosTis { get; set; }

    public virtual DbSet<VwAtividadesEstabelecimentoDeliveryCarioca> VwAtividadesEstabelecimentoDeliveryCariocas { get; set; }

    public virtual DbSet<VwAtividadesEstabelecimentoSeloCovid> VwAtividadesEstabelecimentoSeloCovids { get; set; }

    public virtual DbSet<VwAtividadesPosTi> VwAtividadesPosTis { get; set; }

    public virtual DbSet<VwCobrdosRequdeautodecPosTi> VwCobrdosRequdeautodecPosTis { get; set; }

    public virtual DbSet<VwEstabelecimentoDeliveryCarioca> VwEstabelecimentoDeliveryCariocas { get; set; }

    public virtual DbSet<VwEstabelecimentoInterditadoDeliveryCarioca> VwEstabelecimentoInterditadoDeliveryCariocas { get; set; }

    public virtual DbSet<VwEstabelecimentoIsentoSeloCovid> VwEstabelecimentoIsentoSeloCovids { get; set; }

    public virtual DbSet<VwEstabelecimentoSeloCovid> VwEstabelecimentoSeloCovids { get; set; }

    public virtual DbSet<VwEstabelecimentosPosTi> VwEstabelecimentosPosTis { get; set; }

    public virtual DbSet<VwRequeAutodecPosTi> VwRequeAutodecPosTis { get; set; }

    public virtual DbSet<VwRestrdosRequautodecPosTi> VwRestrdosRequautodecPosTis { get; set; }

    public virtual DbSet<Xscript> Xscripts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer(SqlServerConfiguration.GetConnectionString());

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AcaoEducativaO>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AcaoEduc__3214EC07477C86E9");

            entity.HasOne(d => d.ServidorQueAtualizou).WithMany(p => p.AcaoEducativaOServidorQueAtualizous).HasConstraintName("FK_ServidorQueAtualizouNaAcaoEducativa");

            entity.HasOne(d => d.ServidorQueLavrou).WithMany(p => p.AcaoEducativaOServidorQueLavrous)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServidorQueLavrouNaAcaoEducativa");

            entity.HasOne(d => d.Tarefa).WithMany(p => p.AcaoEducativaOs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AcoesEducativaOsDaTarefa");
        });

        modelBuilder.Entity<AcaoEducativaRealizadum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AcaoEduc__3214EC0701741E54");

            entity.HasOne(d => d.CursoParaAcaoEducativa).WithMany(p => p.AcaoEducativaRealizada)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CursoDaAcaoEducativa");

            entity.HasOne(d => d.InstrutorSubvisa).WithMany(p => p.AcaoEducativaRealizadumInstrutorSubvisas).HasConstraintName("FK_InstrutorDaAcaoEducativa");

            entity.HasOne(d => d.ParceiroParaAcaoEducativa).WithMany(p => p.AcaoEducativaRealizada).HasConstraintName("FK_ParceiroDaAcaoEducativa");

            entity.HasOne(d => d.Servidor).WithMany(p => p.AcaoEducativaRealizadumServidors).HasConstraintName("FK_ServidorCriacaoDaAcaoEducativa");
        });

        modelBuilder.Entity<AcaoSisvisa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AcaoSisv__3214EC073E723F9C");

            entity.Property(e => e.Uf).IsFixedLength();

            entity.HasOne(d => d.ConfiguracaoProgramaColetaAmostrasProdutos).WithMany(p => p.AcaoSisvisas).HasConstraintName("FK_ConfiguracaoColetaNoTipoAcaoSisvisa");

            entity.HasOne(d => d.Creche).WithMany(p => p.AcaoSisvisas).HasConstraintName("FK_CrecheNoTipoAcaoSisvisa");

            entity.HasOne(d => d.EscolaMunicipal).WithMany(p => p.AcaoSisvisas).HasConstraintName("FK_EscolaMunicipalNoTipoAcaoSisvisa");

            entity.HasOne(d => d.Estabelecimento).WithMany(p => p.AcaoSisvisas).HasConstraintName("FK_EstabelecimentoNoTipoAcaoSisvisa");

            entity.HasOne(d => d.EstacaoTransportePublico).WithMany(p => p.AcaoSisvisas).HasConstraintName("FK_EstacaoTransportePublicoNoTipoAcaoSisvisa");

            entity.HasOne(d => d.Feirante).WithMany(p => p.AcaoSisvisas).HasConstraintName("FK_FeiranteNoTipoAcaoSisvisa");

            entity.HasOne(d => d.Hotel).WithMany(p => p.AcaoSisvisas).HasConstraintName("FK_HotelNoTipoAcaoSisvisa");

            entity.HasOne(d => d.OutroLocal).WithMany(p => p.AcaoSisvisas).HasConstraintName("FK_OutroLocalNoTipoAcaoSisvisa");

            entity.HasOne(d => d.Piscina).WithMany(p => p.AcaoSisvisas).HasConstraintName("FK_PiscinaNoTipoAcaoSisvisa");

            entity.HasOne(d => d.PontoColetaVigiagua).WithMany(p => p.AcaoSisvisas).HasConstraintName("FK_PontoColetaVigiaguaNoTipoAcaoSisvisa");

            entity.HasOne(d => d.Prioridade).WithMany(p => p.AcaoSisvisas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrioridadeNoTipoAcaoSisvisa");

            entity.HasOne(d => d.Programa).WithMany(p => p.AcaoSisvisas).HasConstraintName("FK_ProgramaNoTipoAcaoSisvisa");

            entity.HasOne(d => d.Requerente).WithMany(p => p.AcaoSisvisas).HasConstraintName("FK_RequerenteNoTipoAcaoSisvisa");

            entity.HasOne(d => d.RequerimentoAdm).WithMany(p => p.AcaoSisvisas).HasConstraintName("FK_RequerimentoAdministrativoNoTipoAcaoSisvisa");

            entity.HasOne(d => d.Requerimento).WithMany(p => p.AcaoSisvisas).HasConstraintName("FK_RequerimentoNoTipoAcaoSisvisa");

            entity.HasOne(d => d.UnidadePublicaSaude).WithMany(p => p.AcaoSisvisas).HasConstraintName("FK_UnidadePublicaSaudeNoTipoAcaoSisvisa");
        });

        modelBuilder.Entity<AcaoSisvisaNaoConformidadePadronizadum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AcaoSisv__3214EC07490FC9A0");

            entity.HasOne(d => d.AcaoSisvisa).WithMany(p => p.AcaoSisvisaNaoConformidadePadronizada)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AcoesSisvisaNaoConformidadesPadronizadas");

            entity.HasOne(d => d.NaoConformidadePadronizada).WithMany(p => p.AcaoSisvisaNaoConformidadePadronizada)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NaoConformidadesPadronizadasAcoesSisvisa");
        });

        modelBuilder.Entity<AcaoSisvisaTarefa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AcaoSisv__3214EC07453F38BC");

            entity.HasOne(d => d.AcaoSisvisa).WithMany(p => p.AcaoSisvisaTarefas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AcaoSisvisaDaTarefa");

            entity.HasOne(d => d.Tarefa).WithMany(p => p.AcaoSisvisaTarefas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AcoesSisvisaDaTarefa");
        });

        modelBuilder.Entity<AlimentoComercializado>(entity =>
        {
            entity.HasKey(e => e.CodigoAlimento).HasName("PK__Alimento__3E6E296C49EEDF40");

            entity.Property(e => e.CodigoAlimento).ValueGeneratedNever();
        });

        modelBuilder.Entity<AmbulanciaRequerimentoTransitorio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ambulanc__3214EC074DBF7024");
        });

        modelBuilder.Entity<Ambulante>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ambulant__3214EC0777168B72");

            entity.HasOne(d => d.Justificativa).WithMany(p => p.Ambulantes).HasConstraintName("FK_JustificativaAmbulante");

            entity.HasOne(d => d.Requerimento).WithMany(p => p.Ambulantes).HasConstraintName("FK_RequerimentoAmbulante");
        });

        modelBuilder.Entity<AnexoAcaoSisvisa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AnexoAca__3214EC074242D080");

            entity.HasOne(d => d.AcaoSisvisa).WithMany(p => p.AnexoAcaoSisvisas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AnexoAcaoSisvisa");
        });

        modelBuilder.Entity<Area>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TB_AREA__3214EC273C5FD9F8");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ArquivoExtracaoMultum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ArquivoE__3214EC072DDCB077");

            entity.HasOne(d => d.IdArquivoPostagemNavigation).WithMany(p => p.ArquivoExtracaoMulta).HasConstraintName("FK__ArquivoEx__IdArq__3E131840");
        });

        modelBuilder.Entity<ArquivoMultum>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("ArquivoMulta_pk")
                .IsClustered(false);
        });

        modelBuilder.Entity<ArquivoPostagemMultum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ArquivoP__3214EC073C2ACFCE");
        });

        modelBuilder.Entity<ArquivosRepa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Arquivos__3214EC0727B9C2CD");

            entity.HasOne(d => d.Requerimento).WithMany(p => p.ArquivosRepas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RequerimentoREPA");
        });

        modelBuilder.Entity<AspnetApplication>(entity =>
        {
            entity.HasKey(e => e.ApplicationId)
                .HasName("PK__aspnet_A__C93A4C98014935CB")
                .IsClustered(false);

            entity.HasIndex(e => e.LoweredApplicationName, "aspnet_Applications_Index").IsClustered();

            entity.Property(e => e.ApplicationId).ValueGeneratedNever();
        });

        modelBuilder.Entity<AspnetRole>(entity =>
        {
            entity.HasKey(e => e.RoleId)
                .HasName("PK__aspnet_R__8AFACE1B1FCDBCEB")
                .IsClustered(false);

            entity.HasIndex(e => new { e.ApplicationId, e.LoweredRoleName }, "aspnet_Roles_index1")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.RoleId).ValueGeneratedNever();

            entity.HasOne(d => d.Application).WithMany(p => p.AspnetRoles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnet_Ro__Appli__21B6055D");
        });

        modelBuilder.Entity<AspnetSchemaVersion>(entity =>
        {
            entity.HasKey(e => new { e.Feature, e.CompatibleSchemaVersion }).HasName("PK__aspnet_S__5A1E6BC11367E606");
        });

        modelBuilder.Entity<AspnetUser>(entity =>
        {
            entity.HasKey(e => e.UserId)
                .HasName("PK__aspnet_U__1788CC4D0BC6C43E")
                .IsClustered(false);

            entity.HasIndex(e => new { e.ApplicationId, e.LoweredUserName }, "aspnet_Users_Index")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.UserId).ValueGeneratedNever();

            entity.HasOne(d => d.Application).WithMany(p => p.AspnetUsers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnet_Us__Appli__0DAF0CB0");

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "AspnetUsersInRole",
                    r => r.HasOne<AspnetRole>().WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__aspnet_Us__RoleI__286302EC"),
                    l => l.HasOne<AspnetUser>().WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__aspnet_Us__UserI__276EDEB3"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId").HasName("PK__aspnet_U__AF2760AD25869641");
                        j.ToTable("aspnet_UsersInRoles");
                        j.HasIndex(new[] { "RoleId" }, "aspnet_UsersInRoles_index");
                    });
        });

        modelBuilder.Entity<AssinaturaCertificadoAcaoEducativa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Assinatu__3214EC07194BA7E5");
        });

        modelBuilder.Entity<Assunto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Assunto__3214EC076AEFE058");

            entity.Property(e => e.Id).HasComment("Código que identifica o assunto");
            entity.Property(e => e.Descricao).HasComment("Descrição do assunto");
            entity.Property(e => e.Nome).HasComment("Nome do assunto");
            entity.Property(e => e.SegmentoId).HasComment("Código que identifica o segmento do assunto");
        });

        modelBuilder.Entity<AssuntoPrograma>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AssuntoP__3214EC074CE05A84");
        });

        modelBuilder.Entity<AssuntosDoModelo>(entity =>
        {
            entity.Property(e => e.AssuntoId).HasComment("Código que identifica o assunto");
            entity.Property(e => e.ModeloRoteiroId).HasComment("Código que identifica o modelo do Roteiro.");
            entity.Property(e => e.Ordem).HasComment("Ordem em que aparecem os assuntos do modelo");

            entity.HasOne(d => d.Assunto).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssuntosNoModelo");

            entity.HasOne(d => d.ModeloRoteiro).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssuntosOrdenados");
        });

        modelBuilder.Entity<AssuntosDoRoteiro>(entity =>
        {
            entity.Property(e => e.AssuntoId).HasComment("Código que identifica o assunto");
            entity.Property(e => e.Ordem).HasComment("Ordem em que aparecem os roteiros");
            entity.Property(e => e.RoteiroId).HasComment("Código que identifica o roteiro");

            entity.HasOne(d => d.Assunto).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssuntosNoRoteiro");

            entity.HasOne(d => d.Roteiro).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssuntosRoteiroOrdenados");
        });

        modelBuilder.Entity<AssuntosDoRoteiroPrograma>(entity =>
        {
            entity.HasOne(d => d.Assunto).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssuntosNoRoteiroPrograma");

            entity.HasOne(d => d.Roteiro).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssuntosRoteiroProgramaOrdenados");
        });

        modelBuilder.Entity<Atividade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Atividad__3214EC0772910220");

            entity.Property(e => e.Id).HasComment("Código que identifica a atividade");
            entity.Property(e => e.Ativo).HasComment("identifica a atividade que pode ser referenciada no SISVISA.  Valores: [Sim/Não]");
            entity.Property(e => e.Codigo)
                .IsFixedLength()
                .HasComment("Código da atividade no SINAE");
            entity.Property(e => e.Descricao).HasComment("Descrição da atividade");
            entity.Property(e => e.ExigeResponsavelTecnico).HasComment("identifica a atividade que obriga a identificação de um responsável técnico. Valores: [Sim/Não]");
            entity.Property(e => e.LicenciamentoId).HasComment("Código que identifica o licenciamento da atividade. Valores: [1-AutoDeclaração/2-Simplificado/3-Tradicional]");
            entity.Property(e => e.RiscoId).HasComment("Código que identifica o risco da atividade. Valores: [1-Baixo/2-Médio/3-Alto]");
            entity.Property(e => e.RoteiroId).HasComment("Código de identifica o roteiro da atividade");
            entity.Property(e => e.SegmentoId).HasComment("Código que identifica o segmento da atividade. Valores: [1-Comum/2-Alimento/3-Engenharia/4-Saúde/5-Zoonose]");

            entity.HasOne(d => d.Roteiro).WithMany(p => p.Atividades).HasConstraintName("FK_AtividadeNoRoteiro");
        });

        modelBuilder.Entity<AtividadeAmbulante>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Atividad__3214EC07009FF5AC");

            entity.HasOne(d => d.Ambulante).WithMany(p => p.AtividadeAmbulantes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AtividadeAmbulante");

            entity.HasOne(d => d.Atividade).WithMany(p => p.AtividadeAmbulantes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AtividadeAmbulanteAtividade");
        });

        modelBuilder.Entity<AtividadeDoRequerimentoTransitorio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Atividad__3214EC0751900108");
        });

        modelBuilder.Entity<AtividadeEspecialidade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Atividad__3214EC07556091EC");
        });

        modelBuilder.Entity<AtividadeFeirante>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Atividad__3214EC0754C1736E");

            entity.HasOne(d => d.Atividade).WithMany(p => p.AtividadeFeirantes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Atividade");

            entity.HasOne(d => d.Feirante).WithMany(p => p.AtividadeFeirantes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Feirante");
        });

        modelBuilder.Entity<AtividadeParaRequerimentoTransitorio>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("PK__Atividad__06370DAD593122D0");
        });

        modelBuilder.Entity<AtividadeProcedimentoFarmacium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Atividad__3214EC075D01B3B4");
        });

        modelBuilder.Entity<AtividadeSecundariaUnidadePublica>(entity =>
        {
            entity.HasOne(d => d.AtividadeSecundaria).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AtividadeNaAtividadeSecundariaDaUnidadePublicaSaude");

            entity.HasOne(d => d.UnidadePublicaSaude).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AtividadesSecundariasDaUnidadePublicaSaude");
        });

        modelBuilder.Entity<AtividadeSecundarium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Atividad__3214EC070A888742");

            entity.HasOne(d => d.Atividade).WithMany(p => p.AtividadeSecundaria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AtividadeDaAtividadeSecundaria");
        });

        modelBuilder.Entity<AtividadesDaAutorizacao>(entity =>
        {
            entity.HasOne(d => d.Atividade).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AtividadeNaAutorizacaoSanitaria");

            entity.HasOne(d => d.AutorizacaoSanitaria).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AtividadesDaAutorizacao");
        });

        modelBuilder.Entity<AtividadesDoEstabelecimento>(entity =>
        {
            entity.Property(e => e.Codigo)
                .IsFixedLength()
                .HasComment("Código da atividade no SINAE");
            entity.Property(e => e.Descricao).HasComment("Descrição da atividade");
            entity.Property(e => e.EstabelecimentoId).HasComment("Código que identifica o estabelecimento");

            entity.HasOne(d => d.Estabelecimento).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AtividadesDoEstabelecimento");
        });

        modelBuilder.Entity<AtividadesDoRequerimento>(entity =>
        {
            entity.Property(e => e.AtividadeId).HasComment("Código que identifica a atividade");
            entity.Property(e => e.RequerimentoId).HasComment("Código que identifica o requerimento");

            entity.HasOne(d => d.Atividade).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AtividadesNoRequerimento");

            entity.HasOne(d => d.Requerimento).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RequerimentoComAtividades");
        });

        modelBuilder.Entity<AtividadesDoRequerimentoAdministrativo>(entity =>
        {
            entity.HasOne(d => d.Atividade).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AtividadesNoRequerimentoAdministrativo");

            entity.HasOne(d => d.RequerimentoAdministrativo).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RequerimentoAdministrativoComAtividades");
        });

        modelBuilder.Entity<AtividadesDoTermoVisitaSanitarium>(entity =>
        {
            entity.HasOne(d => d.Atividade).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AtividadeNoTermoVisitaSanitaria");

            entity.HasOne(d => d.TermoVisitaSanitaria).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AtividadesDoTermoVisitaSanitaria");
        });

        modelBuilder.Entity<AtividadesSecundariasDoEstabelecimento>(entity =>
        {
            entity.HasOne(d => d.AtividadeSecundaria).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AtividadeNaAtividadeSecundaria");

            entity.HasOne(d => d.Estabelecimento).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AtividadesSecundariasDoEstabelecimento");
        });

        modelBuilder.Entity<Auditorium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Auditori__3214EC077C1A6C5A");

            entity.Property(e => e.Id).HasComment("Código que identifica a auditoria");
            entity.Property(e => e.Data).HasComment("Data e hora da ação realizada");
            entity.Property(e => e.Descricao).HasComment("Descrição da ação auditada");
            entity.Property(e => e.Identificacao).HasComment("Código que identifica o objeto auditado");
            entity.Property(e => e.Login).HasComment("Login do funcionário responsável pela ação realizada");
            entity.Property(e => e.Matricula).HasComment("Matrícula do funcionário responsável pela ação realizada");
            entity.Property(e => e.ObjetoAuditado).HasComment("Código do objeto auditado. Valores: [1-Usuário/ 2- Requerimento/ 3- Legislação/ 4-Estabelecimento].");
        });

        modelBuilder.Entity<AutoInfracaoAssinado>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("AutoInfracaoAssinado_pk")
                .IsClustered(false);

            entity.HasOne(d => d.IdMultaNavigation).WithMany(p => p.AutoInfracaoAssinados)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("AutoInfracaoAssinado_Multa_Id_fk");
        });

        modelBuilder.Entity<AutorizacaoSanitarium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Autoriza__3214EC0746136164");

            entity.HasOne(d => d.Justificativa).WithMany(p => p.AutorizacaoSanitaria).HasConstraintName("FK_JustificativaDaRevogacaoAutorizacaoSanitaria");

            entity.HasOne(d => d.Requerente).WithMany(p => p.AutorizacaoSanitaria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AutorizacoesSanitariasDoRequerente");

            entity.HasOne(d => d.RequerimentoAdm).WithMany(p => p.AutorizacaoSanitaria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RequerimentoAdministrativoNaAutorizacaoSanitaria");
        });

        modelBuilder.Entity<BancaJornal>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.Property(e => e.Uftitular).IsFixedLength();
        });

        modelBuilder.Entity<BancaJornalProdutoBancaJornal>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_BancaProdutoBancaJornal")
                .IsClustered(false);

            entity.HasOne(d => d.IdBancaJornalNavigation).WithMany(p => p.BancaJornalProdutoBancaJornals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BancaProdutoBanca");

            entity.HasOne(d => d.IdProdutoBancaJornalNavigation).WithMany(p => p.BancaJornalProdutoBancaJornals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BancaProdutoProdBanca");
        });

        modelBuilder.Entity<CapitulacaoLegal>(entity =>
        {
            entity.HasOne(d => d.Legislacao).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CapitulacaoLegalNaPergunta");

            entity.HasOne(d => d.Pergunta).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CapitulacaoLegalDaPergunta");
        });

        modelBuilder.Entity<CapitulacaoLegalInspecao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Capitula__3214EC0727E3DFFF");

            entity.HasOne(d => d.Legislacao).WithOne(p => p.CapitulacaoLegalInspecao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LegislacaoNaCapitulacaoLegalInspecao");
        });

        modelBuilder.Entity<CapitulacoesLegaisDoEditalInterdicao>(entity =>
        {
            entity.HasOne(d => d.CapitulacaoLegal).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CapitulacaoLegalNoEditalInterdicao");

            entity.HasOne(d => d.EditalInterdicao).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CapitulacoesLegaisDoEditalInterdicao");
        });

        modelBuilder.Entity<CapitulacoesLegaisDoNotificacaoInfracao>(entity =>
        {
            entity.HasOne(d => d.CapitulacaoLegal).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CapitulacaoLegalNoNotificaoInfracao");

            entity.HasOne(d => d.NotificacaoInfracao).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CapitulacoesLegaisDoNotificacaoInfracao");
        });

        modelBuilder.Entity<CapitulacoesLegaisDoTermoIntimacao>(entity =>
        {
            entity.HasOne(d => d.CapitulacaoLegal).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CapitulacaoLegalNoTermoIntimacao");

            entity.HasOne(d => d.TermoIntimacao).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CapitulacoesLegaisDoTermoIntimacao");
        });

        modelBuilder.Entity<Cargo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cargo__3214EC07575DE8F7");
        });

        modelBuilder.Entity<CategoriaProduto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Categori__3214EC075090EFD7");
        });

        modelBuilder.Entity<ChancelaProcesso>(entity =>
        {
            entity.HasKey(e => e.CodigoDaValidacao)
                .HasName("ChancelaProcesso_pk")
                .IsClustered(false);
        });

        modelBuilder.Entity<CobrancaSisvisa>(entity =>
        {
            entity.HasKey(e => e.NrGuia).HasName("PK_BoletoSisvisa");

            entity.Property(e => e.CdLinhaDigitavel).IsFixedLength();
        });

        modelBuilder.Entity<Competencium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Competen__3214EC07573DED66");
        });

        modelBuilder.Entity<ComplementoDeInformaco>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Compleme__3214EC075DEAEAF5");

            entity.HasOne(d => d.RequerimentoAdm).WithMany(p => p.ComplementoDeInformacos).HasConstraintName("FK_ComplementoDeInformacoesDoRequerimento");
        });

        modelBuilder.Entity<Complexidade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TB_COMPL__3214EC2740306ADC");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ConfiguracaoProgramaColetaAmostrasProduto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Configur__3214EC075EFF0ABF");

            entity.HasOne(d => d.Programa).WithMany(p => p.ConfiguracaoProgramaColetaAmostrasProdutos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConfiguracoesDoPrograma");
        });

        modelBuilder.Entity<Creche>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Creche__3214EC07770B9E7A");

            entity.Property(e => e.Uf).IsFixedLength();
        });

        modelBuilder.Entity<CursoParaAcaoEducativa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CursoPar__3214EC07741A2336");

            entity.HasOne(d => d.AssinaturaCertificadoAcaoEducativa).WithMany(p => p.CursoParaAcaoEducativas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssinaturaCertificadoAcaoEducativaNoCurso");
        });

        modelBuilder.Entity<DemandaProcessosOffLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DemandaP__3214EC0703BB8E22");

            entity.Property(e => e.Id).HasComment("Código que identifica a demanda do processo off-line");
            entity.Property(e => e.DataConclusao).HasComment("Data em que a demanda do processo off-line foi concluída");
            entity.Property(e => e.DataCriacao).HasComment("Data em que a demanda do processo off-line foi criada");
            entity.Property(e => e.DataExecucao).HasComment("Data em que a demanda do processo off-line foi executada");
            entity.Property(e => e.IdEstabelecimento).HasComment("Código que identifica o estabelecimento do processo off-line");
            entity.Property(e => e.IdRequerimento).HasComment("Código que identifica o requerimento do processo off-line");
            entity.Property(e => e.LoginDeRede).HasComment("Login do funcionário responsável pela criação da demanda do processo off-line");
            entity.Property(e => e.Matricula).HasComment("Matrícula do funcionário responsável pela criação da demanda do processo off-line");
            entity.Property(e => e.ResultadoDaOperacao).HasComment("Mensagem de retorno do serviço TIS");
            entity.Property(e => e.TipoDoProcessoOffLineId).HasComment("Código que identifica o tipo de processo off-line. Valores: [1-Incluir contribuinte na TIS/ 4-Alterar área na TIS].");
            entity.Property(e => e.TipoOrigemDoProcessoOffLineId).HasComment("Código que identifica o tipo de origem para o processo off-line.Valores: [1-Tis]");
        });

        modelBuilder.Entity<DescricaoAutoInfracao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Descrica__3214EC0760D24498");

            entity.Property(e => e.MoedaMonetaria).IsFixedLength();
            entity.Property(e => e.UfAutuado).IsFixedLength();
        });

        modelBuilder.Entity<DespachoAcaoSisvisa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Despacho__3214EC0761BB7BD9");

            entity.HasOne(d => d.AcaoSisvisa).WithMany(p => p.DespachoAcaoSisvisas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DespachoAcaoSisvisa");
        });

        modelBuilder.Entity<DocumentoAnexado>(entity =>
        {
            entity.HasOne(d => d.RequerimentoAdm).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DocumentosAnexadosDoRequerimento");
        });

        modelBuilder.Entity<DocumentosAcaoSisvisa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Document__3214EC0762CF9BA3");

            entity.HasOne(d => d.AcaoSisvisa).WithMany(p => p.DocumentosAcaoSisvisas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DocumentosDaAcaoSisvisa");
        });

        modelBuilder.Entity<EditaisInterdicaoEmMonitoramentoDaTarefa>(entity =>
        {
            entity.HasIndex(e => e.TarefaId, "gqs_tarefaid").IsClustered();

            entity.HasOne(d => d.EditalInterdicao).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EditalInterdicaoEmMonitoramentoNaTarefa");

            entity.HasOne(d => d.Tarefa).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EditaisInterdicaoMonitoramentoDaTarefa");
        });

        modelBuilder.Entity<EditalInterdicao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EditalIn__3214EC074E298478");

            entity.HasOne(d => d.ServidorQueAtualizou).WithMany(p => p.EditalInterdicaoServidorQueAtualizous).HasConstraintName("FK_ServidorQueAtualizouNoEditalInterdicao");

            entity.HasOne(d => d.ServidorQueLavrou).WithMany(p => p.EditalInterdicaoServidorQueLavrous)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServidorQueLavrouNoEditalInterdicao");

            entity.HasOne(d => d.Tarefa).WithMany(p => p.EditalInterdicaos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EditaisInterdicaoDaTarefa");

            entity.HasOne(d => d.TermoIntimacao).WithMany(p => p.EditalInterdicaos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TermoIntimacaoNoEditalInterdicao");
        });

        modelBuilder.Entity<EmpresaOutorga>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.IdHistoricoDeLicencaNavigation).WithMany().HasConstraintName("FK_EmpresaOutorga_HistoricoLicenca");
        });

        modelBuilder.Entity<EmpresasRelacionadasEvento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Empresas__3214EC2764A2D57C");
        });

        modelBuilder.Entity<EscolaMunicipal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EscolaMu__3214EC077DB89C09");

            entity.Property(e => e.Uf).IsFixedLength();
        });

        modelBuilder.Entity<EspecialidadeClinica>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Especial__3214EC0768736660");
        });

        modelBuilder.Entity<Estabelecimento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Estabele__3214EC07078C1F06");

            entity.Property(e => e.Id).HasComment("Código que identifica o estabelecimento");
            entity.Property(e => e.AreaOcupada).HasComment("Metragem da área ocupada pelo estabelecimento");
            entity.Property(e => e.Ativo).HasComment("Identifica se o estabelecimento está ativo no SISVISA. Valores: [1/0]");
            entity.Property(e => e.Bairro).HasComment("Descreve o bairro onde o estabelecimento se localiza");
            entity.Property(e => e.BairroDaLocalizacao).HasComment("Descreve o bairro onde o estabelecimento se localiza");
            entity.Property(e => e.CepComplemento).HasComment("Três últimos números do CEP onde o estabelecimento se localiza");
            entity.Property(e => e.CepNumero).HasComment("Cinco primeiros números do CEP onde o estabelecimento se localiza");
            entity.Property(e => e.CodigoLogradouro).HasComment("Código que identifica o tipo de Logradouro. Ex: Acesso. 002, Alameda. 005...");
            entity.Property(e => e.Complemento).HasComment("Complemento do endereço onde o estabelecimento se localiza");
            entity.Property(e => e.CpfCnpj).HasComment("Número do CPF ou CNPJ");
            entity.Property(e => e.DataCriacao).HasComment("Data da criação da licença do estabelecimento");
            entity.Property(e => e.DataValidade).HasComment("Data de validade da licença do estabelecimento");
            entity.Property(e => e.Domingo).HasComment("Identifica se o estabelecimento funciona no Domingo. Valores: Valores: [1/0]");
            entity.Property(e => e.Feriados).HasComment("Identifica se o estabelecimento funciona no Feriado. Valores: Valores: [1/0]");
            entity.Property(e => e.InscricaoMunicipal).HasComment("Número da Inscrição Municipal");
            entity.Property(e => e.Latitude).HasComment("Descreve a latitude da localização do estabelecimento");
            entity.Property(e => e.Logradouro).HasComment("Endereço para a localização do estabelecimento");
            entity.Property(e => e.Longitude).HasComment("Descreve a longitude da localização do estabelecimento");
            entity.Property(e => e.Manha).HasComment("Identifica se o estabelecimento funciona no período da manhã. Valores: Valores: [1/0]");
            entity.Property(e => e.Noite).HasComment("Identifica se o estabelecimento funciona no período da noite. Valores: Valores: [1/0]");
            entity.Property(e => e.NomeFantasia).HasComment("Nome fantasia relativo ao CPF/CNPJ");
            entity.Property(e => e.Numero).HasComment("Número do endereço onde o estabelecimento se localiza");
            entity.Property(e => e.NumeroDeAutenticacao).HasComment("Número da autenticação da licença do estabelecimento");
            entity.Property(e => e.NumeroLicenca).HasComment("Número da licença para funcionamento do estabelecimento");
            entity.Property(e => e.PreenchidoPeloServico).HasComment("identifica os estabelecimentos que foram preenchidos pelo serviço SINAE ou preenchido manualmente pelo funcionário. Valores: [1/0]");
            entity.Property(e => e.Quarta).HasComment("Identifica se o estabelecimento funciona na Quarta-feira. Valores: Valores: [1/0]");
            entity.Property(e => e.Quinta).HasComment("Identifica se o estabelecimento funciona na Quinta-feira. Valores: Valores: [1/0]");
            entity.Property(e => e.Ra).HasComment("Descreve a Região Administrativa na qual o estabelecimento se localiza");
            entity.Property(e => e.RazaoSocial).HasComment("Nome da razão social relativo ao CPF/CNPJ");
            entity.Property(e => e.RequerimentoId).HasComment("Código que identifica o requerimento");
            entity.Property(e => e.Sabado).HasComment("Identifica se o estabelecimento funciona no Sábado. Valores: Valores: [1/0]");
            entity.Property(e => e.Segunda).HasComment("Identifica se o estabelecimento funciona na Segunda-feira. Valores: Valores: [1/0]");
            entity.Property(e => e.Sexta).HasComment("Identifica se o estabelecimento funciona na Sexta-feira. Valores: Valores: [1/0]");
            entity.Property(e => e.SituacaoDaLicencaSanitaria).HasComment("Situação da licença sanitária");
            entity.Property(e => e.SituacaoDoAlvara).HasComment("Descrição da situação da Inscrição Municipal existente no SINAE");
            entity.Property(e => e.Tarde).HasComment("Identifica se o estabelecimento funciona no período da tarde. Valores: Valores: [1/0]");
            entity.Property(e => e.Terca).HasComment("Identifica se o estabelecimento funciona na Terça-feira. Valores: Valores: [1/0]");
            entity.Property(e => e.TipoLogradouro).HasComment("Representa o tipo do logradouro para a localização do estabelecimento. Ex:travessa, viela, viaduto...");
            entity.Property(e => e.Uf).IsFixedLength();

            entity.HasOne(d => d.Justificativa).WithMany(p => p.Estabelecimentos).HasConstraintName("FK_JustificativaDaRevogacaoLicencaSanitaria");

            entity.HasOne(d => d.RequerimentoAdmRt).WithMany(p => p.Estabelecimentos).HasConstraintName("FK_RequerimentoAdmRTNoEstabelecimento");

            entity.HasOne(d => d.Requerimento).WithMany(p => p.Estabelecimentos).HasConstraintName("FK_RequerimentoDaLicencaSanitaria");
        });

        modelBuilder.Entity<EstabelecimentoLicenciadoLss>(entity =>
        {
            entity.Property(e => e.DescricaoStatus).UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.IdAtividadeEconomica)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS");
        });

        modelBuilder.Entity<EstacaoTransportePublico>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EstacaoT__3214EC0766A02C87");

            entity.Property(e => e.Uf).IsFixedLength();
        });

        modelBuilder.Entity<Evento>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("Evento_pk")
                .IsClustered(false);
        });

        modelBuilder.Entity<EventoAmbulante>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EventoAm__3214EC07074CF33B");

            entity.HasOne(d => d.Ambulante).WithMany(p => p.EventoAmbulantes).HasConstraintName("FK_EventoAmbulante");

            entity.HasOne(d => d.Justificativa).WithMany(p => p.EventoAmbulantes).HasConstraintName("FK_AmbulanteJustificativa");

            entity.HasOne(d => d.Requerimento).WithMany(p => p.EventoAmbulantes).HasConstraintName("FK_EventoAmbulanteRequerimento");
        });

        modelBuilder.Entity<EventoBancaJornal>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasOne(d => d.BancaJornal).WithMany(p => p.EventoBancaJornals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EventoBancaJornal");

            entity.HasOne(d => d.Justificativa).WithMany(p => p.EventoBancaJornals).HasConstraintName("FK_EventoBancaJustif");

            entity.HasOne(d => d.Requerimento).WithMany(p => p.EventoBancaJornals).HasConstraintName("FK_EventoBancaRequerimento");
        });

        modelBuilder.Entity<EventoEstabelecimento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EventoEs__3214EC07668030F6");

            entity.HasOne(d => d.Estabelecimento).WithMany(p => p.EventoEstabelecimentos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EventosDoEstabelecimento");

            entity.HasOne(d => d.Justificativa).WithMany(p => p.EventoEstabelecimentos).HasConstraintName("FK_JustificativaDoEventoEstabelecimento");

            entity.HasOne(d => d.Requerimento).WithMany(p => p.EventoEstabelecimentos).HasConstraintName("FK_EventosComRequerimento");
        });

        modelBuilder.Entity<EventoFeirante>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EventoFe__3214EC075A7A4CC4");

            entity.HasOne(d => d.Feirante).WithMany(p => p.EventoFeirantes).HasConstraintName("FK_EventoFeirante");

            entity.HasOne(d => d.Justificativa).WithMany(p => p.EventoFeirantes).HasConstraintName("FK_FeiranteFeiraJustificativa");

            entity.HasOne(d => d.Requerimento).WithMany(p => p.EventoFeirantes).HasConstraintName("FK_EventoFeiranteRequerimento");
        });

        modelBuilder.Entity<FaixaDeNumeroAutoInfracao>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("FaixaDeNumeroAutoInfracao_pk")
                .IsClustered(false);
        });

        modelBuilder.Entity<FaixaDeNumeroCorreio>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("FaixaDeNumeroCorreios_pk")
                .IsClustered(false);
        });

        modelBuilder.Entity<FaixaNumeracaoNotificacaoLaudo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FaixaNum__3214EC07094A4A46");
        });

        modelBuilder.Entity<FaixaNumeracaoO>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FaixaNum__3214EC070F183235");
        });

        modelBuilder.Entity<Feirante>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Feirante__3214EC07457F2FDE");

            entity.HasOne(d => d.Justificativa).WithMany(p => p.Feirantes).HasConstraintName("FK_JustificativaFeirante");

            entity.HasOne(d => d.Requerimento).WithMany(p => p.Feirantes).HasConstraintName("FK_RequerimentoFeirante");
        });

        modelBuilder.Entity<FeiranteFeira>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Feirante__3214EC074FFCBE51");

            entity.HasOne(d => d.Feirante).WithMany(p => p.FeiranteFeiras).HasConstraintName("FK_FeiranteFeira");
        });

        modelBuilder.Entity<FilaEmail>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("FIlaEmail_pk")
                .IsClustered(false);
        });

        modelBuilder.Entity<FinalidadeVeiculo>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<FiscalMultum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FiscalMu__3213E83F141CDE74");
        });

        modelBuilder.Entity<FornecedorDoEvento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Forneced__3214EC0773E5190C");
        });

        modelBuilder.Entity<GenerosAlimenticiosDoVeiculo>(entity =>
        {
            entity.HasOne(d => d.Veiculo).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GenerosAlimenticiosDoVeiculo");
        });

        modelBuilder.Entity<GrupoAtividade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__GrupoAti__3214EC07253C7D7E");
        });

        modelBuilder.Entity<GrupoAtividadeClassificadum>(entity =>
        {
            entity.HasOne(d => d.Atividade).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AtividadeNoGrupoAtividade");

            entity.HasOne(d => d.GrupoAtividade).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AtividadesDoGrupo");
        });

        modelBuilder.Entity<HistoricoAmbulante>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Historic__3214EC070DF9F0CA");

            entity.HasOne(d => d.Ambulante).WithMany(p => p.HistoricoAmbulantes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HistoricoAmbulante");
        });

        modelBuilder.Entity<HistoricoAtividadeAmbulante>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Historic__3214EC0712BEA5E7");

            entity.Property(e => e.Codigo).IsFixedLength();

            entity.HasOne(d => d.Atividade).WithMany(p => p.HistoricoAtividadeAmbulantes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HistoricoAtividadeAmbulanteAtividade");

            entity.HasOne(d => d.HistoricoAmbulante).WithMany(p => p.HistoricoAtividadeAmbulantes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HistoricoAtividadeAmbulante");
        });

        modelBuilder.Entity<HistoricoAtividadeEconomicaSinae>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Historic__3214EC0777B5A9F0");

            entity.Property(e => e.Codigo).IsFixedLength();
        });

        modelBuilder.Entity<HistoricoAtividadeFeirante>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Historic__3214EC076D8D2138");

            entity.HasOne(d => d.Atividade).WithMany(p => p.HistoricoAtividadeFeirantes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AtividadeHistoricoAtividadeFeirante");

            entity.HasOne(d => d.HistoricoFeirante).WithMany(p => p.HistoricoAtividadeFeirantes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HistoricoFeiranteHistoricoAtividadeFeirante");
        });

        modelBuilder.Entity<HistoricoAtividadesDoEstabelecimento>(entity =>
        {
            entity.HasIndex(e => e.HistoricoEstabelecimentoId, "gqs_idx_idestabelecimento").IsClustered();

            entity.Property(e => e.Codigo).IsFixedLength();
        });

        modelBuilder.Entity<HistoricoBancaJornal>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.Property(e => e.Uftitular).IsFixedLength();
        });

        modelBuilder.Entity<HistoricoBancaJornalProduto>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);
        });

        modelBuilder.Entity<HistoricoDeLicenca>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("HistoricoDeLicenca_pk")
                .IsClustered(false);

            entity.HasIndex(e => e.Id, "HistoricoDeLicenca_pk1").IsClustered();
        });

        modelBuilder.Entity<HistoricoEstabelecimento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Historic__3214EC077F56CBB8");

            entity.Property(e => e.Uf).IsFixedLength();
        });

        modelBuilder.Entity<HistoricoFeirante>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Historic__3214EC0761274A53");

            entity.HasOne(d => d.Feirante).WithMany(p => p.HistoricoFeirantes).HasConstraintName("FK_HistoricoFeirante");
        });

        modelBuilder.Entity<HistoricoFeiranteFeira>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Historic__3214EC0765EBFF70");

            entity.HasOne(d => d.HistoricoFeirante).WithMany(p => p.HistoricoFeiranteFeiras).HasConstraintName("FK_HistoricoFeiranteFeira");
        });

        modelBuilder.Entity<HistoricoInspecao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Historic__3214EC0754D68207");

            entity.HasOne(d => d.Creche).WithMany(p => p.HistoricoInspecaos).HasConstraintName("FK_CrecheNoHistoricoInspecao");

            entity.HasOne(d => d.EscolaMunicipal).WithMany(p => p.HistoricoInspecaos).HasConstraintName("FK_EscolaMunicipalNoHistoricoInspecao");

            entity.HasOne(d => d.EstacaoTransportePublico).WithMany(p => p.HistoricoInspecaos).HasConstraintName("FK_EstacaoTransportePublicoNoHistoricoInspecao");

            entity.HasOne(d => d.Hotel).WithMany(p => p.HistoricoInspecaos).HasConstraintName("FK_HotelNoHistoricoInspecao");

            entity.HasOne(d => d.OutroLocal).WithMany(p => p.HistoricoInspecaos).HasConstraintName("FK_OutroLocalNoHistoricoInspecao");

            entity.HasOne(d => d.Piscina).WithMany(p => p.HistoricoInspecaos).HasConstraintName("FK_PiscinaNoHistoricoInspecao");

            entity.HasOne(d => d.Requerente).WithMany(p => p.HistoricoInspecaos).HasConstraintName("FK_RequerenteNoHistoricoInspecao");

            entity.HasOne(d => d.UnidadePublicaSaude).WithMany(p => p.HistoricoInspecaos).HasConstraintName("FK_UnidadePublicaSaudeNoHistoricoInspecao");
        });

        modelBuilder.Entity<HistoricoProdutoBancaJornal>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_HistProdutoBancaJornal")
                .IsClustered(false);
        });

        modelBuilder.Entity<HistoricoRequerenteTokenCpe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_HistoricoRequerenteTokenCPE");
        });

        modelBuilder.Entity<Hotel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Hotel__3214EC074A6E022D");

            entity.Property(e => e.Uf).IsFixedLength();
        });

        modelBuilder.Entity<Justificativa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Justific__3214EC0717C286CF");

            entity.Property(e => e.Id).HasComment("Chave primária");
            entity.Property(e => e.Nome).HasComment("Nome");
            entity.Property(e => e.TipoId).HasComment("1-Deferimento  2-Indeferimento  3-Exigência");
        });

        modelBuilder.Entity<Laboratorio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Laborato__3214EC07150615B5");

            entity.Property(e => e.Uf).IsFixedLength();
        });

        modelBuilder.Entity<Laudo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Laudo__3214EC0758A712EB");

            entity.HasOne(d => d.AcaoSisvisa).WithMany(p => p.Laudos).HasConstraintName("FK_AcaoSisvisaNoLaudo");

            entity.HasOne(d => d.Laboratorio).WithMany(p => p.Laudos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LaboratorioNoLaudo");

            entity.HasOne(d => d.TermoApreensaoAmostraAnalise).WithMany(p => p.Laudos).HasConstraintName("FK_TermoApreensaoAmostraAnaliseNoLaudo");

            entity.HasOne(d => d.TermoVisitaSanitaria).WithMany(p => p.Laudos).HasConstraintName("FK_TermoVisitaSanitariaNoLaudo");
        });

        modelBuilder.Entity<Legislacao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Legislac__3214EC071E6F845E");

            entity.Property(e => e.Id).HasComment("Chave primária");
            entity.Property(e => e.AscendenciaId).HasComment("Ascendente");
            entity.Property(e => e.Ativa).HasComment("True-ativa  False-inativa");
            entity.Property(e => e.DataDesativacao).HasComment("Data da desativação");
            entity.Property(e => e.Nome).HasComment("Nome da lei");

            entity.HasOne(d => d.Ascendencia).WithMany(p => p.InverseAscendencia).HasConstraintName("FK_Ascendencia");
        });

        modelBuilder.Entity<LicencaCanceladaPorRequerente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LicencaC__3214EC0759F03CDF");

            entity.HasOne(d => d.Ambulante).WithMany(p => p.LicencaCanceladaPorRequerentes).HasConstraintName("FK_LicencaCanceladaPorRequerente_Ambulante");
        });

        modelBuilder.Entity<LicencaDeVeiculo>(entity =>
        {
            entity.HasIndex(e => e.Id, "LicencaDeVeiculo_pk")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.RequerimentoAdministrativo).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RequerimentoAdministrativoLicencaDeVeiculo");

            entity.HasOne(d => d.Veiculo).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VeiculoLicencaDeVeiculo");
        });

        modelBuilder.Entity<LicencaVeiculoCanceladaPorRequerente>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LogDeTaxa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LG_TAXA___3214EC2703275C9C");
        });

        modelBuilder.Entity<ManualSisvisa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ManualSi__3214EC072759D01A");
        });

        modelBuilder.Entity<MensagemSisvisa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Mensagem__3214EC072799C73C");

            entity.HasOne(d => d.Servidor).WithMany(p => p.MensagemSisvisas).HasConstraintName("FK_ServidorCriacaoDaMensagem");
        });

        modelBuilder.Entity<MensagemZapCarioca>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Mensagem__3214EC07157B1701");
        });

        modelBuilder.Entity<ModeloDeDarm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ModeloDe__3214EC0706F7ED80");

            entity.Property(e => e.CodigoDaReceitaDigito).IsFixedLength();
        });

        modelBuilder.Entity<ModeloDeEmail>(entity =>
        {
            entity.HasKey(e => e.TipoDeEmail).HasName("PK__ModeloDe__0EFB54D8552B87C2");

            entity.Property(e => e.TipoDeEmail).ValueGeneratedNever();
        });

        modelBuilder.Entity<ModeloRoteiro>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ModeloRo__3214EC07251C81ED");

            entity.Property(e => e.Id).HasComment("Chave primária");
            entity.Property(e => e.Nome).HasComment("Nome");
            entity.Property(e => e.SegmentoId).HasComment("1-Comum  2-Alimento  3-Engenharia  4-Saúde  5-Zoonose");
        });

        modelBuilder.Entity<MultaArquivoMultum>(entity =>
        {
            entity.HasOne(d => d.IdArquivoNavigation).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ArquivoMulta___fk");

            entity.HasOne(d => d.IdMultaNavigation).WithMany().HasConstraintName("ArquivoMulta_Multa_Id_fk");
        });

        modelBuilder.Entity<MultaFaltaLicenciamento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MultaFal__3214EC070AC87E64");

            entity.Property(e => e.Uf).IsFixedLength();
        });

        modelBuilder.Entity<MultaOld>(entity =>
        {
            entity.Property(e => e.DocumentoRequerente).IsFixedLength();
            entity.Property(e => e.Uf).IsFixedLength();
        });

        modelBuilder.Entity<Multum>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("Multa_pk")
                .IsClustered(false);

            entity.Property(e => e.DocumentoRequerente).IsFixedLength();
            entity.Property(e => e.Uf).IsFixedLength();

            entity.HasOne(d => d.IdArquivoExtracaoNavigation).WithMany(p => p.Multa).HasConstraintName("FK__Multa__IdArquivo__43CBF196");

            entity.HasOne(d => d.IdTipoDeLicenciamentoNavigation).WithMany(p => p.Multa).HasConstraintName("FK_TipoDeLicenciamento");

            entity.HasOne(d => d.MatriculaServidorAssinaturaNavigation).WithMany(p => p.Multa)
                .HasPrincipalKey(p => p.Matricula)
                .HasForeignKey(d => d.MatriculaServidorAssinatura)
                .HasConstraintName("Multa_Servidor_Matricula_fk");
        });

        modelBuilder.Entity<Municipio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Municipi__3214EC076B44E613");

            entity.Property(e => e.SiglaUf).IsFixedLength();
        });

        modelBuilder.Entity<NaoConformidadePadronizadum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NaoConfo__3214EC0731A25463");
        });

        modelBuilder.Entity<NaoConformidadesDoTermoIntimacao>(entity =>
        {
            entity.HasOne(d => d.NaoConformidade).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NaoConformidadeNoTermoIntimacao");

            entity.HasOne(d => d.TermoIntimacao).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NaoConformidadesDoTermoIntimacao");
        });

        modelBuilder.Entity<NotificacaoInfracao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Notifica__3214EC075F54107A");

            entity.HasOne(d => d.ServidorQueAtualizou).WithMany(p => p.NotificacaoInfracaoServidorQueAtualizous).HasConstraintName("FK_ServidorQueAtualizouNaNotificacaoInfracao");

            entity.HasOne(d => d.ServidorQueLavrou).WithMany(p => p.NotificacaoInfracaoServidorQueLavrous)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServidorQueLavrouNaNotificacaoInfracao");

            entity.HasOne(d => d.Tarefa).WithMany(p => p.NotificacaoInfracaos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NotificacoesInfracaoDaTarefa");

            entity.HasOne(d => d.TermoIntimacao).WithMany(p => p.NotificacaoInfracaos).HasConstraintName("FK_TermoIntimacaoNaNotificacaoInfracao");
        });

        modelBuilder.Entity<NotificacaoLaudo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Notifica__3214EC0766010E09");

            entity.HasOne(d => d.Laudo).WithMany(p => p.NotificacaoLaudos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LaudoNaNotificacaoLaudo");
        });

        modelBuilder.Entity<NumeroSicop>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NumeroSi__3214EC072DB1C7EE");

            entity.Property(e => e.Id).HasComment("Chave primária");
            entity.Property(e => e.Data).HasComment("Data da geração do número");
            entity.Property(e => e.JustificativaId).HasComment("Código da tabela de justificativa");
            entity.Property(e => e.LoginDeRede).HasComment("Login de rede");
            entity.Property(e => e.Matricula).HasComment("Matrícula");
            entity.Property(e => e.Numero).HasComment("Número");
            entity.Property(e => e.ProtocoloId).HasComment("Código da tabela de protocolo");

            entity.HasOne(d => d.Justificativa).WithMany(p => p.NumeroSicops)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JustificativaDoNumeroSicopAutodeclaracao");

            entity.HasOne(d => d.Protocolo).WithMany(p => p.NumeroSicops)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Protocolo");
        });

        modelBuilder.Entity<ObjetoValorado>(entity =>
        {
            entity.HasKey(e => new { e.Tipo, e.Valor }).HasName("PK__ObjetoVa__3E0BBA1473A521EA");
        });

        modelBuilder.Entity<OrdemServico>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OrdemSer__3214EC077834CCDD");
        });

        modelBuilder.Entity<OutroLocal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OutroLoc__3214EC0715C52FC4");

            entity.Property(e => e.Uf).IsFixedLength();
        });

        modelBuilder.Entity<Pai>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pais__3214EC076F1576F7");
        });

        modelBuilder.Entity<ParametroSisvisa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Parametr__3214EC0772E607DB");
        });

        modelBuilder.Entity<ParceiroParaAcaoEducativa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Parceiro__3214EC0767B44C51");
        });

        modelBuilder.Entity<PareceresDoRequerimento>(entity =>
        {
            entity.Property(e => e.Data).HasComment("Data");
            entity.Property(e => e.Matricula).HasComment("Matrícula");
            entity.Property(e => e.Observacao).HasComment("Observação");
            entity.Property(e => e.Ordem).HasComment("Ordem");
            entity.Property(e => e.PerguntaId).HasComment("Código da pergunta");
            entity.Property(e => e.RequerimentoId).HasComment("Código do requerimento");
            entity.Property(e => e.TipoParecerId).HasComment("1-Aceitar  2-Rejeitar  3-Exigência");

            entity.HasOne(d => d.Pergunta).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ParecerDaPerguntaNoRequerimento");

            entity.HasOne(d => d.Requerimento).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PareceresDoRequerimento");
        });

        modelBuilder.Entity<PareceresDoRoteiroParaInspecao>(entity =>
        {
            entity.HasOne(d => d.DemandaAcaoSisvisa).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PareceresDoRoteiroParaInspecao");

            entity.HasOne(d => d.Pergunta).WithMany().HasConstraintName("FK_ParecerDaPerguntaNaDemandaAcaoSisvisa");

            entity.HasOne(d => d.PerguntaPrograma).WithMany().HasConstraintName("FK_ParecerDaPerguntaProgramaNaDemandaAcaoSisvisa");
        });

        modelBuilder.Entity<PareceresDosVeiculosDoRequerimento>(entity =>
        {
            entity.HasOne(d => d.Pergunta).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ParecerDaPerguntaDoVeiculoNoRequerimento");

            entity.HasOne(d => d.Requerimento).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PareceresDosVeiculosDoRequerimento");

            entity.HasOne(d => d.Veiculo).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ParecerDoVeiculoNoRequerimento");
        });

        modelBuilder.Entity<PareceresDosVeiculosParaInspecao>(entity =>
        {
            entity.HasOne(d => d.DemandaAcaoSisvisa).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PareceresDosVeiculosParaInspecao");

            entity.HasOne(d => d.Pergunta).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ParecerDaPerguntaDoVeiculoNaDemandaAcaoSisvisa");

            entity.HasOne(d => d.Veiculo).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ParecerDoVeiculoNaDemandaAcaoSisvisa");
        });

        modelBuilder.Entity<ParticipanteAcaoEducativaRealizadum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Particip__3214EC070915401C");

            entity.HasOne(d => d.AcaoEducativaRealizada).WithMany(p => p.ParticipanteAcaoEducativaRealizada)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AcaoEducativaRealizadaNoParticipante");
        });

        modelBuilder.Entity<PendenciasDoEstabelecimento>(entity =>
        {
            entity.Property(e => e.Codigo)
                .IsFixedLength()
                .HasComment("Código");
            entity.Property(e => e.Descricao).HasComment("Descrição");
            entity.Property(e => e.EstabelecimentoId).HasComment("Código do estabelecimento");

            entity.HasOne(d => d.Estabelecimento).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PendenciasDoEstabelecimento");
        });

        modelBuilder.Entity<PerguntaDoAssuntoPrograma>(entity =>
        {
            entity.HasOne(d => d.Assunto).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PerguntasDoAssuntoPrograma");

            entity.HasOne(d => d.Pergunta).WithOne()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PerguntaNoAssuntoPrograma");
        });

        modelBuilder.Entity<PerguntaPrograma>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pergunta__3214EC077B9B496D");

            entity.HasOne(d => d.Assunto).WithMany(p => p.PerguntaProgramas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssuntoNaPerguntaPrograma");
        });

        modelBuilder.Entity<PerguntasDoAssunto>(entity =>
        {
            entity.Property(e => e.AssuntoId).HasComment("Código do assunto");
            entity.Property(e => e.Ordem).HasComment("Ordem");
            entity.Property(e => e.PerguntaId).HasComment("Código da pergunta");

            entity.HasOne(d => d.Assunto).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PerguntasDoAssunto");

            entity.HasOne(d => d.Pergunta).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PerguntaNoAssunto");
        });

        modelBuilder.Entity<PerguntasDoModelo>(entity =>
        {
            entity.Property(e => e.ModeloRoteiroId).HasComment("Modelo do roteiro");
            entity.Property(e => e.PerguntaId).HasComment("Código da pergunta");

            entity.HasOne(d => d.ModeloRoteiro).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ModeloComPerguntas");

            entity.HasOne(d => d.Pergunta).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PerguntaNoModelo");
        });

        modelBuilder.Entity<PerguntasDoRoteiro>(entity =>
        {
            entity.Property(e => e.PerguntaId).HasComment("Código da pergunta");
            entity.Property(e => e.RoteiroId).HasComment("Código do roteiro");

            entity.HasOne(d => d.Pergunta).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PerguntaNoRoteiro");

            entity.HasOne(d => d.Roteiro).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RoteiroComPerguntas");
        });

        modelBuilder.Entity<PerguntasDoRoteiroPrograma>(entity =>
        {
            entity.HasOne(d => d.PerguntaPrograma).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PerguntaNoRoteiroPrograma");

            entity.HasOne(d => d.RoteiroPrograma).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RoteiroProgramaComPerguntas");
        });

        modelBuilder.Entity<Perguntum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pergunta__3214EC07345EC57D");

            entity.Property(e => e.Id).HasComment("Chave primária");
            entity.Property(e => e.AnexarDocumento).HasComment("Anexar Documento");
            entity.Property(e => e.AssuntoId).HasComment("Código do assunto");
            entity.Property(e => e.Ativo).HasComment("Ativo");
            entity.Property(e => e.Descricao).HasComment("Descrição");
            entity.Property(e => e.Enunciado).HasComment("Enunciado da pergunta");
            entity.Property(e => e.Gabarito).HasComment("Gabarito");
            entity.Property(e => e.LegislacaoId).HasComment("Código da legislação");
            entity.Property(e => e.TipoRespostaId).HasComment("1-Texto  2-Sim Não Não se aplica  3-Sim/Não/Não se Aplica - Com Anexo  4-Númerico");

            entity.HasOne(d => d.Assunto).WithMany(p => p.Pergunta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssuntoNaPergunta");
        });

        modelBuilder.Entity<Piscina>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Piscina__3214EC0758BC2184");

            entity.Property(e => e.Uf).IsFixedLength();
        });

        modelBuilder.Entity<PontoColetaVigiagua>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PontoCol__3214EC0704659998");

            entity.Property(e => e.Uf).IsFixedLength();
        });

        modelBuilder.Entity<PosicaoFeiranteFeira>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PosicaoF__3214EC077345FA8E");

            entity.HasOne(d => d.FeiranteFeira).WithMany(p => p.PosicaoFeiranteFeiras)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FeiraFeirante");
        });

        modelBuilder.Entity<PrioridadeDaAcaoSisvisa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Priorida__3214EC0703DB89B3");
        });

        modelBuilder.Entity<ProcedimentoFarmacium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Procedim__3214EC070E990F48");
        });

        modelBuilder.Entity<Produto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Produto__3214EC077A8729A3");

            entity.HasOne(d => d.CategoriaProduto).WithMany(p => p.Produtos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProdutoNaCategoriaDeProduto");

            entity.HasOne(d => d.Estabelecimento).WithMany(p => p.Produtos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProdutoNoEstabelecimento");

            entity.HasOne(d => d.Justificativa).WithMany(p => p.Produtos).HasConstraintName("FK_JustificativaDoProduto");

            entity.HasOne(d => d.PaisOrigem).WithMany(p => p.Produtos).HasConstraintName("FK_ProdutoNoPais");

            entity.HasOne(d => d.Requerente).WithMany(p => p.Produtos).HasConstraintName("FK_ProdutosDoRequerente");

            entity.HasOne(d => d.RequerimentoAdm).WithMany(p => p.Produtos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProdutoNoRequerimentoAdministrativo");
        });

        modelBuilder.Entity<ProdutoBancaJornal>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasOne(d => d.TipoDeLicenciamento).WithMany(p => p.ProdutoBancaJornals).HasConstraintName("FK_TipoDeLicenciamentoNoProdutoBancaJornal");
        });

        modelBuilder.Entity<ProdutoTermoApreensao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ProdutoT__3214EC0718F6A22A");

            entity.HasOne(d => d.TermoApreensao).WithMany(p => p.ProdutoTermoApreensaos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TermoApreensaoNoProduto");
        });

        modelBuilder.Entity<Programa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Programa__3214EC07727BF387");

            entity.HasOne(d => d.Atividade).WithMany(p => p.Programas).HasConstraintName("FK_AtividadeDoPrograma");

            entity.HasOne(d => d.AtividadeSecundaria).WithMany(p => p.Programas).HasConstraintName("FK_AtividadeSecundariaDoPrograma");

            entity.HasOne(d => d.GrupoAtividade).WithMany(p => p.Programas).HasConstraintName("FK_GrupoAtividadeDoPrograma");

            entity.HasOne(d => d.Justificativa).WithMany(p => p.Programas).HasConstraintName("FK_JustificativaDoPrograma");

            entity.HasOne(d => d.Laboratorio).WithMany(p => p.Programas).HasConstraintName("FK_LaboratorioDoPrograma");

            entity.HasOne(d => d.RoteiroLicenciamento).WithMany(p => p.Programas).HasConstraintName("FK_RoteiroDoLicenciamento");

            entity.HasOne(d => d.RoteiroPrograma).WithMany(p => p.Programas).HasConstraintName("FK_RoteiroDoPrograma");
        });

        modelBuilder.Entity<Protocolo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Protocol__3214EC073B0BC30C");

            entity.Property(e => e.Id).HasComment("Chave primária");
            entity.Property(e => e.Ano).HasComment("Ano base");
            entity.Property(e => e.FaixaFinal).HasComment("Faixa final");
            entity.Property(e => e.FaixaInicial).HasComment("Faixa inicial");
            entity.Property(e => e.TipoNumeracaoSicopId).HasComment("1-Outros Processos  9-AutoDeclaração");
            entity.Property(e => e.UltimoNumeroUtilizado).HasComment("Último número utilizado");
        });

        modelBuilder.Entity<RegistroRepa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Registro__3214EC072C7E77EA");

            entity.HasOne(d => d.Requerimento).WithMany(p => p.RegistroRepas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RegistroREPA_RequerimentoREPA");
        });

        modelBuilder.Entity<Requerente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Requeren__3214EC077E57BA87");

            entity.Property(e => e.Uf).IsFixedLength();

            entity.HasOne(d => d.Justificativa).WithMany(p => p.Requerentes).HasConstraintName("FK_JustificativaRequerenteAdm");

            entity.HasOne(d => d.RequerimentoAdm).WithMany(p => p.Requerentes).HasConstraintName("FK_RequerimentoAdministrativoRequerente");
        });

        modelBuilder.Entity<RequerenteTokenCpe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_RequerenteTokenCPE");
        });

        modelBuilder.Entity<RequerimentoAdministrativo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Requerim__3214EC070504B816");

            entity.HasOne(d => d.EstabelecimentoCifCii).WithMany(p => p.RequerimentoAdministrativoEstabelecimentoCifCiis).HasConstraintName("FK_EstabelecimentoCifCiiNoRequerimentoAdministrativo");

            entity.HasOne(d => d.Estabelecimento).WithMany(p => p.RequerimentoAdministrativoEstabelecimentos).HasConstraintName("FK_EstabelecimentoDoRequerimentoAdministrativo");

            entity.HasOne(d => d.IdMultaNavigation).WithMany(p => p.RequerimentoAdministrativos).HasConstraintName("RequerimentoAdministrativo_Multa_Id_fk");

            entity.HasOne(d => d.Justificativa).WithMany(p => p.RequerimentoAdministrativos).HasConstraintName("FK_JustificativaDoRequerimentoAdministrativo");

            entity.HasOne(d => d.NotificacaoInfracao).WithMany(p => p.RequerimentoAdministrativos).HasConstraintName("FK_NotificacaoInfracaoDoRequerimentoAdministrativo");

            entity.HasOne(d => d.NotificacaoLaudo).WithMany(p => p.RequerimentoAdministrativos).HasConstraintName("FK_NotificacaoLaudoDoRequerimentoAdministrativo");

            entity.HasOne(d => d.Requerente).WithMany(p => p.RequerimentoAdministrativos).HasConstraintName("FK_RequerenteDoRequerimentoAdministrativo");

            entity.HasOne(d => d.TermoApreensaoAmostraAnalise).WithMany(p => p.RequerimentoAdministrativos).HasConstraintName("FK_TermoApreensaoAmostraAnaliseDoRequerimentoAdministrativo");

            entity.HasOne(d => d.TermoApreensao).WithMany(p => p.RequerimentoAdministrativos).HasConstraintName("FK_TermoApreensaoDoRequerimentoAdministrativo");

            entity.HasOne(d => d.TermoIntimacao).WithMany(p => p.RequerimentoAdministrativos).HasConstraintName("FK_TermoIntimacaoNoRequerimentoAdministrativo");

            entity.HasOne(d => d.TermoResponsabilidade).WithMany(p => p.RequerimentoAdministrativos).HasConstraintName("FK_RequerimentoAdministrativo_TermoResponsabilidade");

            entity.HasOne(d => d.TipoDeLicenciamento).WithMany(p => p.RequerimentoAdministrativos).HasConstraintName("FK_TipoDeLicenciamentoNoRequerimentoAdministrativo");

            entity.HasOne(d => d.Veiculo).WithMany(p => p.RequerimentoAdministrativos).HasConstraintName("FK_RequerimentoVeiculo");
        });

        modelBuilder.Entity<RequerimentoAutodeclaracao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Requerim__3214EC0741B8C09B");

            entity.Property(e => e.Id).HasComment("Chave primária");
            entity.Property(e => e.Cpf).HasComment("CPF");
            entity.Property(e => e.DataDeEnvio).HasComment("Data de envio");
            entity.Property(e => e.DataExigencia).HasComment("Data da exigência");
            entity.Property(e => e.DataFim).HasComment("Data de fim");
            entity.Property(e => e.DataInicio).HasComment("Data de início");
            entity.Property(e => e.DataInicioAnalise).HasComment("Data início da análise");
            entity.Property(e => e.DataLimiteParaCumprimentoExigencia).HasComment("Data limite para cumprimento de exigência");
            entity.Property(e => e.DataLimiteParaEnvio).HasComment("Data limite para envio");
            entity.Property(e => e.DiasParaTerminoDaAnalise).HasComment("Dias para término da análise");
            entity.Property(e => e.Email).HasComment("Email");
            entity.Property(e => e.EstabelecimentoId).HasComment("Código do estabelecimento");
            entity.Property(e => e.JustificativaId).HasComment("Código da justificativa");
            entity.Property(e => e.LicenciamentoId).HasComment("1-Autodeclaração  2-Simplificado  3-Tradicional");
            entity.Property(e => e.LoginDeRede).HasComment("Login de rede");
            entity.Property(e => e.Matricula).HasComment("Matrícula");
            entity.Property(e => e.Nome).HasComment("Nome");
            entity.Property(e => e.Numero).HasComment("Número");
            entity.Property(e => e.SituacaoId).HasComment("0-Novo  1-Preenchendo  2-Enviado  3-Exigência  4-Respondida  5-Análise  6-Analisado  7-Deferido  8-Indeferido  9-Cancelado");
            entity.Property(e => e.TipoId).HasComment("1-Requerimento de Licenciamento por Autodeclaração  2-Requerimento de Licenciamento");

            entity.HasOne(d => d.Ambulante).WithMany(p => p.RequerimentoAutodeclaracaos).HasConstraintName("FK_RequerimentoAutodeclaracao_Ambulante");

            entity.HasOne(d => d.BancaJornal).WithMany(p => p.RequerimentoAutodeclaracaos).HasConstraintName("FK_RequeBancaJornal");

            entity.HasOne(d => d.Estabelecimento).WithMany(p => p.RequerimentoAutodeclaracaos).HasConstraintName("FK_EstabelecimentoNoRequerimentoDeAutodeclaracao");

            entity.HasOne(d => d.Feirante).WithMany(p => p.RequerimentoAutodeclaracaos).HasConstraintName("FK_RequerimentoAutodeclaracaoFeirante");

            entity.HasOne(d => d.Justificativa).WithMany(p => p.RequerimentoAutodeclaracaos).HasConstraintName("FK_JustificativaDoRequerimentoDeAutodeclaracao");

            entity.HasOne(d => d.TermoResponsabilidade).WithMany(p => p.RequerimentoAutodeclaracaos).HasConstraintName("FK_Requerimento_TermoResponsabilidade");
        });

        modelBuilder.Entity<RequerimentoTransitorio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Requerim__3214EC071269A02C");

            entity.HasOne(d => d.TermoResponsabilidade).WithMany(p => p.RequerimentoTransitorios).HasConstraintName("FK_RequerimentoTransitorio_TermoResponsabilidade");
        });

        modelBuilder.Entity<RequerimentoTransitorioAnexo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Requerim__3214EC07163A3110");
        });

        modelBuilder.Entity<RequerimentoTransitorioDeObra>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Requerim__3214EC071A0AC1F4");
        });

        modelBuilder.Entity<RequerimentoTransitorioFornecedorAlimento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Requerim__3214EC071DDB52D8");
        });

        modelBuilder.Entity<RequerimentoTransitorioFornecedorSaude>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Requerim__3214EC0721ABE3BC");
        });

        modelBuilder.Entity<RequerimentoTransitorioFornecedorZoonose>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Requerim__3214EC07257C74A0");
        });

        modelBuilder.Entity<RequerimentoTransitorioObraInfra>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Requerim__3214EC07294D0584");
        });

        modelBuilder.Entity<RespostasDoRequerimento>(entity =>
        {
            entity.Property(e => e.Assunto).HasComment("Assunto");
            entity.Property(e => e.Enunciado).HasComment("Enunciado");
            entity.Property(e => e.Ordem).HasComment("Ordem");
            entity.Property(e => e.PerguntaId).HasComment("Código da pergunta");
            entity.Property(e => e.RequerimentoId).HasComment("Código do requerimento");
            entity.Property(e => e.SegmentoId).HasComment("1-Comum  2-Alimento  3-Engenharia  4-Saúde  5-Zoonose");
            entity.Property(e => e.TipoParecerId).HasComment("1-Aceitar  2-Rejeitar  3-Exigência");
            entity.Property(e => e.Valor).HasComment("Valor");
            entity.Property(e => e.ValorArquivo).HasComment("Valor do arquivo");

            entity.HasOne(d => d.Pergunta).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PerguntaNoRequerimento");

            entity.HasOne(d => d.Requerimento).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RespostasDoRequerimento");
        });

        modelBuilder.Entity<RespostasDoRequerimentoAdministrativo>(entity =>
        {
            entity.HasOne(d => d.Pergunta).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PerguntaNoRequerimentoAdministrativo");

            entity.HasOne(d => d.RequerimentoAdm).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RespostasDoRequerimentoAdministrativo");
        });

        modelBuilder.Entity<RespostasDoRoteiroParaInspecao>(entity =>
        {
            entity.HasOne(d => d.DemandaAcaoSisvisa).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RespostasDoRoteiroParaInspecao");

            entity.HasOne(d => d.Pergunta).WithMany().HasConstraintName("FK_PerguntaNaDemandaAcaoSisvisa");

            entity.HasOne(d => d.PerguntaPrograma).WithMany().HasConstraintName("FK_PerguntaProgramaNaDemandaAcaoSisvisa");
        });

        modelBuilder.Entity<RespostasDoVeiculoAdministrativo>(entity =>
        {
            entity.HasOne(d => d.Pergunta).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PerguntaNaRespostaDoVeiculoAdministrativo");

            entity.HasOne(d => d.RequerimentoAdm).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RespostasDoVeiculoAdministrativo");

            entity.HasOne(d => d.Veiculo).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VeiculoNaRespostaDoVeiculoAdministrativo");
        });

        modelBuilder.Entity<RespostasDoVeiculoLicenciamento>(entity =>
        {
            entity.HasOne(d => d.Pergunta).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PerguntaNaRespostaDoVeiculoLicenciamento");

            entity.HasOne(d => d.Requerimento).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RespostasDoVeiculoLicenciamento");

            entity.HasOne(d => d.Veiculo).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VeiculoNaRespostaDoVeiculoLicenciamento");
        });

        modelBuilder.Entity<RespostasDoVeiculoParaInspecao>(entity =>
        {
            entity.HasOne(d => d.DemandaAcaoSisvisa).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RespostasDoVeiculoParaInspecao");

            entity.HasOne(d => d.Pergunta).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PerguntaNaRespostaDoVeiculoDaDemandaAcaoSisvisa");

            entity.HasOne(d => d.Veiculo).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VeiculoNaRespostaDoVeiculoDaDemandaAcaoSisvisa");
        });

        modelBuilder.Entity<RestricoesDoEstabelecimento>(entity =>
        {
            entity.Property(e => e.Codigo)
                .IsFixedLength()
                .HasComment("Código");
            entity.Property(e => e.Descricao).HasComment("Descrição");
            entity.Property(e => e.EstabelecimentoId).HasComment("Estabelecimento");

            entity.HasOne(d => d.Estabelecimento).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RestricoesDoEstabelecimento");
        });

        modelBuilder.Entity<Risco>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TB_RISCO__3214EC2747D18CA4");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Roteiro>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Roteiro__3214EC075006DFF2");

            entity.Property(e => e.Id).HasComment("Chave primária");
            entity.Property(e => e.ModeloId).HasComment("Código do modelo");
            entity.Property(e => e.Nome).HasComment("Nome");

            entity.HasOne(d => d.Modelo).WithMany(p => p.Roteiros)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ModeloNoRoteiro");
        });

        modelBuilder.Entity<RoteiroPrograma>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RoteiroP__3214EC07033C6B35");
        });

        modelBuilder.Entity<SegmentosDaAcaoSisvisa>(entity =>
        {
            entity.HasOne(d => d.AcaoSisvisa).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SegmentosDaAcaoSisvisa");
        });

        modelBuilder.Entity<SegmentosDoRequerimento>(entity =>
        {
            entity.Property(e => e.DataFimAnalise).HasComment("Data de fim da análise");
            entity.Property(e => e.DataFimDeferimento).HasComment("Data de fim do deferimento");
            entity.Property(e => e.DataFimExigencia).HasComment("Data de fim da exigência");
            entity.Property(e => e.DataInicioAnalise).HasComment("Data de início da análise");
            entity.Property(e => e.DataInicioDeferimento).HasComment("Data de início do deferimento");
            entity.Property(e => e.DataInicioExigencia).HasComment("Data de início da exigência");
            entity.Property(e => e.RequerimentoId).HasComment("Código do requerimento");
            entity.Property(e => e.SegmentoId).HasComment("1-Comum  2-Alimento  3-Engenharia  4-Saúde  5-Zoonose");

            entity.HasOne(d => d.Requerimento).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SegmentosDoRequerimento");
        });

        modelBuilder.Entity<SegmentosDoRequerimentoAdministrativo>(entity =>
        {
            entity.HasOne(d => d.RequerimentoAdm).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SegmentosDoRequerimentoAdministrativo");
        });

        modelBuilder.Entity<SegmentosValidacaoLicenca>(entity =>
        {
            entity.HasOne(d => d.Estabelecimento).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SegmentosValidacaoLicencaDoEstabelecimento");
        });

        modelBuilder.Entity<ServicoEventoDoRequerimentoTransitorio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ServicoE__3214EC075DC0CDC3");
        });

        modelBuilder.Entity<ServidoArquivoMultum>(entity =>
        {
            entity.HasKey(e => e.MatriculaDoServidor)
                .HasName("ServidoArquivoMulta_pk")
                .IsClustered(false);

            entity.HasOne(d => d.IdArquivoMultaNavigation).WithMany(p => p.ServidoArquivoMulta).HasConstraintName("ServidoArquivoMulta_ArquivoMulta_id_fk");

            entity.HasOne(d => d.MatriculaDoServidorNavigation).WithOne(p => p.ServidoArquivoMultum)
                .HasPrincipalKey<Servidor>(p => p.Matricula)
                .HasForeignKey<ServidoArquivoMultum>(d => d.MatriculaDoServidor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ServidoArquivoMulta_Servidor_Matricula_fk");
        });

        modelBuilder.Entity<Servidor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Servidor__3214EC07589C25F3");

            entity.Property(e => e.Id).HasComment("Chave primária");
            entity.Property(e => e.Ativo).HasComment("Ativo-true  Inativo-false");
            entity.Property(e => e.CargoFuncao).HasComment("Cargo ou função");
            entity.Property(e => e.Email).HasComment("Email");
            entity.Property(e => e.LoginDeRede).HasComment("Login do servidor, funcionário na rede");
            entity.Property(e => e.Lotacao).HasComment("Lugar em que está lotado");
            entity.Property(e => e.Matricula).HasComment("Matrícula");
            entity.Property(e => e.Nome).HasComment("Nome");
            entity.Property(e => e.SegmentoId).HasComment("1-Comum  2-Alimento  3-Engenharia  4-Saúde  5-Zoonose");
            entity.Property(e => e.Uf).IsFixedLength();

            entity.HasOne(d => d.Cargo).WithMany(p => p.Servidors).HasConstraintName("FK_CargoDoServidor");
        });

        modelBuilder.Entity<ServidorArquivoMultum>(entity =>
        {
            entity.HasKey(e => new { e.IdArquivoMulta, e.IdServidor })
                .HasName("ServidorArquivoMulta_pk")
                .IsClustered(false);
        });

        modelBuilder.Entity<ServidorAtividade>(entity =>
        {
            entity.HasOne(d => d.Atividade).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AtividadeNoservidor");

            entity.HasOne(d => d.Servidor).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AtividadesDoServidor");
        });

        modelBuilder.Entity<ServidorCertificado>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("ServidorCertificado_pk")
                .IsClustered(false);

            entity.HasOne(d => d.IdDoServidorNavigation).WithMany(p => p.ServidorCertificados)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ServidorCertificado_Servidor_Id_fk");
        });

        modelBuilder.Entity<ServidorCompetencia>(entity =>
        {
            entity.HasOne(d => d.Competencia).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CompetenciaNoServidor");

            entity.HasOne(d => d.Servidor).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CompetenciasDoServidor");
        });

        modelBuilder.Entity<ServidorEscalaTrabalho>(entity =>
        {
            entity.HasOne(d => d.Servidor).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EscalasDeTrabalhoDoServidor");
        });

        modelBuilder.Entity<ServidorGrupoAtividade>(entity =>
        {
            entity.HasOne(d => d.GrupoAtividade).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GrupoAtividadeNoServidor");

            entity.HasOne(d => d.Servidor).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GruposDeAtividadesDoServidor");
        });

        modelBuilder.Entity<ServidorInatividade>(entity =>
        {
            entity.HasOne(d => d.Servidor).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InatividadesDoServidor");
        });

        modelBuilder.Entity<ServidoresOrdemServico>(entity =>
        {
            entity.HasOne(d => d.OrdemServico).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServidoresDaOrdemDeServico");

            entity.HasOne(d => d.Servidor).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServidorNaOrdemDeServico");
        });

        modelBuilder.Entity<Setor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Setor__3214EC070CA5D9DE");
        });

        modelBuilder.Entity<SmfAtividade>(entity =>
        {
            entity.HasIndex(e => e.InscricaomunicipalOrig, "idx_insc").IsClustered();
        });

        modelBuilder.Entity<SmfEstabelecimento>(entity =>
        {
            entity.HasIndex(e => e.InscricaomunicipalOrig, "idx_insc").IsClustered();
        });

        modelBuilder.Entity<SmfPendente>(entity =>
        {
            entity.HasIndex(e => e.InscricaomunicipalOrig, "idx_insc").IsClustered();
        });

        modelBuilder.Entity<SmfRestricao>(entity =>
        {
            entity.HasIndex(e => e.InscricaomunicipalOrig, "idx_insc").IsClustered();
        });

        modelBuilder.Entity<Surto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Surto__3214EC0709E968C4");

            entity.Property(e => e.UfReclamante).IsFixedLength();

            entity.HasOne(d => d.AcaoSisvisa).WithMany(p => p.Surtos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AcaoSisvisaDoSurto");
        });

        modelBuilder.Entity<Tarefa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tarefa__3214EC076AC5C326");

            entity.Property(e => e.Uf).IsFixedLength();

            entity.HasOne(d => d.Justificatica).WithMany(p => p.Tarefas).HasConstraintName("FK_JustificaticaDaTarefa");

            entity.HasOne(d => d.OrdemServico).WithMany(p => p.Tarefas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TarefasDaOrdemServico");

            entity.HasOne(d => d.TermoVisitaSanitaria).WithMany(p => p.Tarefas).HasConstraintName("FK_TermoVisitaSanitariaDaTarefa");
        });

        modelBuilder.Entity<TarifaRepa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TarifaRE__3214EC0732375140");
        });

        modelBuilder.Entity<TermoApreensao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TermoApr__3214EC076E96540A");

            entity.HasOne(d => d.CapitulacaoLegal).WithMany(p => p.TermoApreensaos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CapitulacaoLegalNoTermoDeApreensao");

            entity.HasOne(d => d.ServidorQueAtualizou).WithMany(p => p.TermoApreensaoServidorQueAtualizous).HasConstraintName("FK_ServidorQueAtualizouNoTermoDeApreensao");

            entity.HasOne(d => d.ServidorQueLavrou).WithMany(p => p.TermoApreensaoServidorQueLavrous)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServidorQueLavrouNoTermoDeApreensao");

            entity.HasOne(d => d.Tarefa).WithMany(p => p.TermoApreensaos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TermosApreensaoDaTarefa");

            entity.HasOne(d => d.TermoApreensaoAmostraAnalise).WithMany(p => p.TermoApreensaos).HasConstraintName("FK_TermoApreensaoAmostraAnaliseNoTermoApreensao");
        });

        modelBuilder.Entity<TermoApreensaoAmostraAnalise>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TermoApr__3214EC0775435199");

            entity.HasOne(d => d.CapitulacaoLegal).WithMany(p => p.TermoApreensaoAmostraAnalises)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CapitulacaoLegalDoTermoApreensaoAmostraAnalise");

            entity.HasOne(d => d.Laboratorio).WithMany(p => p.TermoApreensaoAmostraAnalises)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LaboratorioNoTermoApreensaoAmostraAnalise");

            entity.HasOne(d => d.ServidorQueAtualizou).WithMany(p => p.TermoApreensaoAmostraAnaliseServidorQueAtualizous).HasConstraintName("FK_ServidorQueAtualizouNoTermoApreensaoAmostraAnalise");

            entity.HasOne(d => d.ServidorQueLavrou).WithMany(p => p.TermoApreensaoAmostraAnaliseServidorQueLavrous)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServidorQueLavrouNoTermoApreensaoAmostraAnalise");

            entity.HasOne(d => d.Tarefa).WithMany(p => p.TermoApreensaoAmostraAnalises)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TermosApreensaoAmostraAnaliseDaTarefa");

            entity.HasOne(d => d.TermoApreensao).WithMany(p => p.TermoApreensaoAmostraAnalises).HasConstraintName("FK_TermoApreensaoNoTermoApreensaoAmostraAnalise");
        });

        modelBuilder.Entity<TermoIntimacao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TermoInt__3214EC077BF04F28");

            entity.HasOne(d => d.EditalInterdicao).WithMany(p => p.TermoIntimacaos).HasConstraintName("FK_EditalInterdicaoNoTermoIntimacao");

            entity.HasOne(d => d.ServidorQueAtualizou).WithMany(p => p.TermoIntimacaoServidorQueAtualizous).HasConstraintName("FK_ServidorQueAtualizouNoTermoIntimacao");

            entity.HasOne(d => d.ServidorQueLavrou).WithMany(p => p.TermoIntimacaoServidorQueLavrous)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServidorQueLavrouNoTermoIntimacao");

            entity.HasOne(d => d.Tarefa).WithMany(p => p.TermoIntimacaos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TermosIntimacaoDaTarefa");

            entity.HasOne(d => d.TermoAnterior).WithMany(p => p.InverseTermoAnterior).HasConstraintName("FK_TermoIntimacaoAnteriorNoTermoIntimacao");
        });

        modelBuilder.Entity<TermoResponsabilidade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TermoRes__3214EC072200E977");

            entity.HasOne(d => d.TipoTermoLicenciamento).WithMany(p => p.TermoResponsabilidades)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TermoResponsabilidade_TipoTermoLicenciamento");
        });

        modelBuilder.Entity<TermoVigilanciaSanitarium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TermosVigilanciaSanitaria");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<TermoVisitaSanitarium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TermoVis__3214EC07029D4CB7");

            entity.HasOne(d => d.ServidorQueAtualizou).WithMany(p => p.TermoVisitaSanitariumServidorQueAtualizous).HasConstraintName("FK_ServidorQueAtualizouNoTermoVisitaSanitaria");

            entity.HasOne(d => d.ServidorQueLavrou).WithMany(p => p.TermoVisitaSanitariumServidorQueLavrous)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServidorQueLavrouNoTermoVisitaSanitaria");

            entity.HasOne(d => d.Tarefa).WithMany(p => p.TermoVisitaSanitariaNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TarefaNoTermoVisitaSanitaria");
        });

        modelBuilder.Entity<TermosIntimacaoEmMonitoramentoDaTarefa>(entity =>
        {
            entity.HasIndex(e => e.TarefaId, "gqs_tarefaId").IsClustered();

            entity.HasOne(d => d.Tarefa).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TermosIntimacaoMonitoramentoDaTarefa");

            entity.HasOne(d => d.TermoIntimacao).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TermoIntimacaoEmMonitoramentoNaTarefa");
        });

        modelBuilder.Entity<TipoAutorizacaoSanitarium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TipoAuto__3214EC071352D76D");

            entity.HasOne(d => d.Roteiro).WithMany(p => p.TipoAutorizacaoSanitaria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RoteiroNoTipoAutorizacaoSanitaria");
        });

        modelBuilder.Entity<TipoDeAlimentoVeiculo>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TipoDeLicenciamento>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("TipoDeLicenciamento_pk")
                .IsClustered(false);

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<TipoProdutoVeiculo>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TipoPublicoAlvoRoteiro>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TipoPubl__3214EC071D9B5BB6");

            entity.HasOne(d => d.Roteiro).WithMany(p => p.TipoPublicoAlvoRoteiros)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RoteiroNoTipoPublicoAlvoRoteiro");
        });

        modelBuilder.Entity<TipoResiduoVeiculo>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TipoServicoVeiculo>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TipoTermoLicenciamento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TipoTerm__3214EC071E305893");
        });

        modelBuilder.Entity<TipoVeiculo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TipoVeic__3214EC0719FFD4FC");

            entity.HasOne(d => d.Roteiro).WithMany(p => p.TipoVeiculos).HasConstraintName("FK_RoteiroNoTipoDeVeiculo");
        });

        modelBuilder.Entity<TiposDeServicoDoVeiculo>(entity =>
        {
            entity.HasKey(e => e.VeiculoId).HasName("PK__TiposDeS__A5253AB834BEB830");

            entity.Property(e => e.VeiculoId).ValueGeneratedNever();
        });

        modelBuilder.Entity<UnidadePublicaSaude>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UnidadeP__3214EC07384F51F2");

            entity.Property(e => e.Uf).IsFixedLength();
        });

        modelBuilder.Entity<Veiculo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Veiculo__3214EC0720ACD28B");

            entity.Property(e => e.AnoFabricacao).IsFixedLength();
            entity.Property(e => e.Uf).IsFixedLength();

            entity.HasOne(d => d.Estabelecimento).WithMany(p => p.Veiculos).HasConstraintName("FK_VeiculosDoEstabelecimento");

            entity.HasOne(d => d.Requerente).WithMany(p => p.Veiculos).HasConstraintName("FK_VeiculosDoRequerente");

            entity.HasOne(d => d.TipoVeiculo).WithMany(p => p.Veiculos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TipoDeVeiculoNoVeiculo");

            entity.HasOne(d => d.UltimoRequerimentoAdministrativo).WithMany(p => p.Veiculos).HasConstraintName("FK_UltimoRequerimentoAdministrativoNoVeiculo");

            entity.HasOne(d => d.UltimoRequerimentoLicencimento).WithMany(p => p.Veiculos).HasConstraintName("FK_UltimoRequerimentoLicencimentoNoVeiculo");
        });

        modelBuilder.Entity<Veterinario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Veterina__3214EC07388F4914");
        });

        modelBuilder.Entity<VisitasDeInspecaoDoEstabelecimento>(entity =>
        {
            entity.HasOne(d => d.Estabelecimento).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VisitasDeInspecaoDoEstabelecimento");

            entity.HasOne(d => d.TermoVisitaSanitaria).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TermoVisitaSanitariaNaVistaDeInspecao");
        });

        modelBuilder.Entity<VwAspnetApplication>(entity =>
        {
            entity.ToView("vw_aspnet_Applications");
        });

        modelBuilder.Entity<VwAspnetRole>(entity =>
        {
            entity.ToView("vw_aspnet_Roles");
        });

        modelBuilder.Entity<VwAspnetUser>(entity =>
        {
            entity.ToView("vw_aspnet_Users");
        });

        modelBuilder.Entity<VwAspnetUsersInRole>(entity =>
        {
            entity.ToView("vw_aspnet_UsersInRoles");
        });

        modelBuilder.Entity<VwAtivDoRequAutodecPosTi>(entity =>
        {
            entity.ToView("Vw_AtivDoRequAutodecPosTIS");

            entity.Property(e => e.Codigo).IsFixedLength();
        });

        modelBuilder.Entity<VwAtividadesEstabelecimentoDeliveryCarioca>(entity =>
        {
            entity.ToView("Vw_AtividadesEstabelecimento_DeliveryCarioca");

            entity.Property(e => e.Codigo).IsFixedLength();
        });

        modelBuilder.Entity<VwAtividadesEstabelecimentoSeloCovid>(entity =>
        {
            entity.ToView("Vw_AtividadesEstabelecimento_SeloCovid");

            entity.Property(e => e.Codigo).IsFixedLength();
        });

        modelBuilder.Entity<VwAtividadesPosTi>(entity =>
        {
            entity.ToView("Vw_AtividadesPosTIS");

            entity.Property(e => e.Codigo).IsFixedLength();
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<VwCobrdosRequdeautodecPosTi>(entity =>
        {
            entity.ToView("Vw_CobrdosRequdeautodecPosTIS");

            entity.Property(e => e.NrGuia).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<VwEstabelecimentoDeliveryCarioca>(entity =>
        {
            entity.ToView("Vw_Estabelecimento_DeliveryCarioca");
        });

        modelBuilder.Entity<VwEstabelecimentoInterditadoDeliveryCarioca>(entity =>
        {
            entity.ToView("Vw_EstabelecimentoInterditado_DeliveryCarioca");
        });

        modelBuilder.Entity<VwEstabelecimentoIsentoSeloCovid>(entity =>
        {
            entity.ToView("Vw_EstabelecimentoIsento_SeloCovid");
        });

        modelBuilder.Entity<VwEstabelecimentoSeloCovid>(entity =>
        {
            entity.ToView("Vw_Estabelecimento_SeloCovid");
        });

        modelBuilder.Entity<VwEstabelecimentosPosTi>(entity =>
        {
            entity.ToView("Vw_EstabelecimentosPosTIS");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<VwRequeAutodecPosTi>(entity =>
        {
            entity.ToView("Vw_RequeAutodecPosTIS");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<VwRestrdosRequautodecPosTi>(entity =>
        {
            entity.ToView("Vw_RestrdosRequautodecPosTIS");

            entity.Property(e => e.Codigo).IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

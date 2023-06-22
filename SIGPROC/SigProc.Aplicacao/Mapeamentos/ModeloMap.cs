using AutoMapper;
using SigProc.Aplicacao.Modelos;
using SigProc.Aplicacao.Modelos.ModeloEntrada;
using SigProc.Domain.Entidades;
using SigProc.Domimio.Entidades;
using SigProc.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SigProc.Aplicacao.Mapeamentos
{
    public class ModeloMap : Profile
    {
        public ModeloMap()
        {
            CreateMap<UsuarioModelo, Usuario>().AfterMap((command, entity) =>
            {
                entity.Id = 0;
            });
            CreateMap<AutenticacaoModelo, Usuario>();
            CreateMap<GerenciaUpdateModelo, Gerencia>();
            CreateMap<GerenciaPrazoModelo, GerenciaPrazo>();
            CreateMap<GerenciaUsuarioModelo, GerenciaUsuario>();
            CreateMap<GerenciaPrazoUpdateModelo, GerenciaPrazo>();
            CreateMap<ProcessoModelo, Processo>();
            CreateMap<MensagemModelo, Mensagem>();
            CreateMap<TipoContratacaoModelo, TipoContratacao>();
            CreateMap<TipoProcessoModelo, TipoProcesso>();
            CreateMap<EtapaProcessoModelo, EtapaProcesso>();
            CreateMap<StatusProcessoModelo, StatusProcesso>();
            CreateMap<TipoPrazoModelo, TipoPrazo>(); ;
            CreateMap<TipoUsuarioGerenciaModelo, TipoUsuarioGerencia>(); ;
            CreateMap<DadosDoProcessoSicopModelo, DadosDoProcessoSicop>().AfterMap((command, entity) =>
            {
                entity.Id = 0;
            });
        }
    }
}

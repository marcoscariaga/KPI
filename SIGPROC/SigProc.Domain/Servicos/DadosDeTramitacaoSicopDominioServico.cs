using AutoMapper;
using SigProc.Domimio.Contratos.Dados;
using SigProc.Domimio.Contratos.Servicos;
using SigProc.Domimio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Domimio.Servicos
{
    public class DadosDeTramitacaoSicopDominioServico : IDadosDeTramitacaoSicopDominioServico
    {
        private readonly IDadosDeTramitacaoSicopRepositorio _repository;
        private IMapper _mapper;
        public DadosDeTramitacaoSicopDominioServico(IDadosDeTramitacaoSicopRepositorio repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public DadosDeTramitacaoSicop Atualizar(DadosDeTramitacaoSicop tramitacao)
        {
            return _repository.Atualizar(tramitacao);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

        public DadosDeTramitacaoSicop Excluir(int id)
        {
            return _repository.Excluir(id);
        }

        public DadosDeTramitacaoSicop Inserir(DadosDeTramitacaoSicop tramitacao)
        {
            var verificaCadatro = _repository.ListarTudo().Where(x => x.NumeroDoProcesso == tramitacao.NumeroDoProcesso).FirstOrDefault();

            if (verificaCadatro != null)
            {
                verificaCadatro.Rotina = "";
                verificaCadatro.NumeroDoProcesso = tramitacao.NumeroDoProcesso;
                verificaCadatro.Opcao = "";


                verificaCadatro.Item_01 = tramitacao.Item_01;
                verificaCadatro.MatDig_01 = tramitacao.MatDig_01;
                verificaCadatro.MatRec_01 = tramitacao.MatRec_01;
                verificaCadatro.OrgaoDeDestino_01 = tramitacao.OrgaoDeDestino_01;
                verificaCadatro.DataDoDespacho_01 = tramitacao.DataDoDespacho_01;
                verificaCadatro.Sequencia_01 = tramitacao.Sequencia_01;
                verificaCadatro.Guia_01 = tramitacao.Guia_01;
                verificaCadatro.Despacho_01 = tramitacao.Despacho_01;
                verificaCadatro.Item_02 = tramitacao.Item_02;
                verificaCadatro.MatDig_02 = tramitacao.MatDig_02;
                verificaCadatro.MatRec_02 = tramitacao.MatRec_02;
                verificaCadatro.OrgaoDeDestino_02 = tramitacao.OrgaoDeDestino_02;
                verificaCadatro.DataDoDespacho_02 = tramitacao.DataDoDespacho_02;
                verificaCadatro.Sequencia_02 = tramitacao.Sequencia_02;
                verificaCadatro.Guia_02 = tramitacao.Guia_02;
                verificaCadatro.Despacho_02 = tramitacao.Despacho_02;
                verificaCadatro.Item_03 = tramitacao.Item_03;
                verificaCadatro.MatDig_03 = tramitacao.MatDig_03;
                verificaCadatro.MatRec_03 = tramitacao.MatRec_03;
                verificaCadatro.OrgaoDeDestino_03 = tramitacao.OrgaoDeDestino_03;
                verificaCadatro.DataDoDespacho_03 = tramitacao.DataDoDespacho_03;
                verificaCadatro.Sequencia_03 = tramitacao.Sequencia_03;
                verificaCadatro.Guia_03 = tramitacao.Guia_03;
                verificaCadatro.Despacho_03 = tramitacao.Despacho_03;
                verificaCadatro.Item_04 = tramitacao.Item_04;
                verificaCadatro.MatDig_04 = tramitacao.MatDig_04;
                verificaCadatro.MatRec_04 = tramitacao.MatRec_04;
                verificaCadatro.OrgaoDeDestino_04 = tramitacao.OrgaoDeDestino_04;
                verificaCadatro.DataDoDespacho_04 = tramitacao.DataDoDespacho_04;
                verificaCadatro.Sequencia_04 = tramitacao.Sequencia_04;
                verificaCadatro.Guia_04 = tramitacao.Guia_04;
                verificaCadatro.Despacho_04 = tramitacao.Despacho_04;
                verificaCadatro.Item_05 = tramitacao.Item_05;
                verificaCadatro.MatDig_05 = tramitacao.MatDig_05;
                verificaCadatro.MatRec_05 = tramitacao.MatRec_05;
                verificaCadatro.OrgaoDeDestino_05 = tramitacao.OrgaoDeDestino_05;
                verificaCadatro.DataDoDespacho_05 = tramitacao.DataDoDespacho_05;
                verificaCadatro.Sequencia_05 = tramitacao.Sequencia_05;
                verificaCadatro.Guia_05 = tramitacao.Guia_05;
                verificaCadatro.Despacho_05 = tramitacao.Despacho_05;
                verificaCadatro.Item_06 = tramitacao.Item_06;
                verificaCadatro.MatDig_06 = tramitacao.MatDig_06;
                verificaCadatro.MatRec_06 = tramitacao.MatRec_06;
                verificaCadatro.OrgaoDeDestino_06 = tramitacao.OrgaoDeDestino_06;
                verificaCadatro.DataDoDespacho_06 = tramitacao.DataDoDespacho_06;
                verificaCadatro.Sequencia_06 = tramitacao.Sequencia_06;
                verificaCadatro.Guia_06 = tramitacao.Guia_06;
                verificaCadatro.Despacho_06 = tramitacao.Despacho_06;
                verificaCadatro.Item_07 = tramitacao.Item_07;
                verificaCadatro.MatDig_07 = tramitacao.MatDig_07;
                verificaCadatro.MatRec_07 = tramitacao.MatRec_07;
                verificaCadatro.OrgaoDeDestino_07 = tramitacao.OrgaoDeDestino_07;
                verificaCadatro.DataDoDespacho_07 = tramitacao.DataDoDespacho_07;
                verificaCadatro.Sequencia_07 = tramitacao.Sequencia_07;
                verificaCadatro.Guia_07 = tramitacao.Guia_07;
                verificaCadatro.Despacho_07 = tramitacao.Despacho_07;
                verificaCadatro.Item_08 = tramitacao.Item_08;
                verificaCadatro.MatDig_08 = tramitacao.MatDig_08;
                verificaCadatro.MatRec_08 = tramitacao.MatRec_08;
                verificaCadatro.OrgaoDeDestino_08 = tramitacao.OrgaoDeDestino_08;
                verificaCadatro.DataDoDespacho_08 = tramitacao.DataDoDespacho_08;
                verificaCadatro.Sequencia_08 = tramitacao.Sequencia_08;
                verificaCadatro.Guia_08 = tramitacao.Guia_08;
                verificaCadatro.Despacho_08 = tramitacao.Despacho_08;
                verificaCadatro.Item_09 = tramitacao.Item_09;
                verificaCadatro.MatDig_09 = tramitacao.MatDig_09;
                verificaCadatro.MatRec_09 = tramitacao.MatRec_09;
                verificaCadatro.OrgaoDeDestino_09 = tramitacao.OrgaoDeDestino_09;
                verificaCadatro.DataDoDespacho_09 = tramitacao.DataDoDespacho_09;
                verificaCadatro.Sequencia_09 = tramitacao.Sequencia_09;
                verificaCadatro.Guia_09 = tramitacao.Guia_09;
                verificaCadatro.Despacho_09 = tramitacao.Despacho_09;
                verificaCadatro.Item_10 = tramitacao.Item_10;
                verificaCadatro.MatDig_10 = tramitacao.MatDig_10;
                verificaCadatro.MatRec_10 = tramitacao.MatRec_10;
                verificaCadatro.OrgaoDeDestino_10 = tramitacao.OrgaoDeDestino_10;
                verificaCadatro.DataDoDespacho_10 = tramitacao.DataDoDespacho_10;
                verificaCadatro.Sequencia_10 = tramitacao.Sequencia_10;
                verificaCadatro.Guia_10 = tramitacao.Guia_10;
                verificaCadatro.Despacho_10 = tramitacao.Despacho_10;
                verificaCadatro.Item_11 = tramitacao.Item_11;
                verificaCadatro.MatDig_11 = tramitacao.MatDig_11;
                verificaCadatro.MatRec_11 = tramitacao.MatRec_11;
                verificaCadatro.OrgaoDeDestino_11 = tramitacao.OrgaoDeDestino_11;
                verificaCadatro.DataDoDespacho_11 = tramitacao.DataDoDespacho_11;
                verificaCadatro.Sequencia_11 = tramitacao.Sequencia_11;
                verificaCadatro.Guia_11 = tramitacao.Guia_11;
                verificaCadatro.Despacho_11 = tramitacao.Despacho_11;
                verificaCadatro.Item_12 = tramitacao.Item_12;
                verificaCadatro.MatDig_12 = tramitacao.MatDig_12;
                verificaCadatro.MatRec_12 = tramitacao.MatRec_12;
                verificaCadatro.OrgaoDeDestino_12 = tramitacao.OrgaoDeDestino_12;
                verificaCadatro.DataDoDespacho_12 = tramitacao.DataDoDespacho_12;
                verificaCadatro.Sequencia_12 = tramitacao.Sequencia_12;
                verificaCadatro.Guia_12 = tramitacao.Guia_12;
                verificaCadatro.Despacho_12 = tramitacao.Despacho_12;
                verificaCadatro.Item_13 = tramitacao.Item_13;
                verificaCadatro.MatDig_13 = tramitacao.MatDig_13;
                verificaCadatro.MatRec_13 = tramitacao.MatRec_13;
                verificaCadatro.OrgaoDeDestino_13 = tramitacao.OrgaoDeDestino_13;
                verificaCadatro.DataDoDespacho_13 = tramitacao.DataDoDespacho_13;
                verificaCadatro.Sequencia_13 = tramitacao.Sequencia_13;
                verificaCadatro.Guia_13 = tramitacao.Guia_13;
                verificaCadatro.Despacho_13 = tramitacao.Despacho_13;
                verificaCadatro.Item_14 = tramitacao.Item_14;
                verificaCadatro.MatDig_14 = tramitacao.MatDig_14;
                verificaCadatro.MatRec_14 = tramitacao.MatRec_14;
                verificaCadatro.OrgaoDeDestino_14 = tramitacao.OrgaoDeDestino_14;
                verificaCadatro.DataDoDespacho_14 = tramitacao.DataDoDespacho_14;
                verificaCadatro.Sequencia_14 = tramitacao.Sequencia_14;
                verificaCadatro.Guia_14 = tramitacao.Guia_14;
                verificaCadatro.Despacho_14 = tramitacao.Despacho_14;
                verificaCadatro.Concad = tramitacao.Concad;
                verificaCadatro.DataEdicao = new DateTime();
                verificaCadatro.StatusLine = "";
                verificaCadatro.Status = true;

                return _repository.Atualizar(verificaCadatro);
            }
            else
            {
                return _repository.Inserir(_mapper.Map<DadosDeTramitacaoSicop>(tramitacao));
            }
        }

        public ICollection<DadosDeTramitacaoSicop> ListarTudo()
            => _repository.ListarTudo().Where(c => c.DataExclusao == null).ToList();

        public DadosDeTramitacaoSicop RetornaPorId(int id)
            => _repository.RetornaPorId(id);
    }
}


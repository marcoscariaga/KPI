using Microsoft.EntityFrameworkCore;
using SigProc.Dominio.Contratos.Dados;
using SigProc.Dominio.Entidades;
using SigProc.infra.dados.Contextos;
using SigProc.infra.dados.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.infra.dados.Repositorios
{
    public class GerenciaUsuarioRepositorio : BaseRepositorio<GerenciaUsuario>, IGerenciaUsuarioRepositorio
    {
        private readonly SqlServidorContexto contexto;

        public GerenciaUsuarioRepositorio(SqlServidorContexto sqlServerContext) : base(sqlServerContext)
        {
            contexto = sqlServerContext;
        }

        public ICollection<GerenciaUsuario> ListarAtivos()
        {
            return contexto.GerenciaUsuario.Include(a => a.Gerencia).Include(a => a.TipoUsuarioGerencia).Include(a => a.UsuarioGerencia).Include(a => a.UsuarioCadastro).Where(a => a.Status == true).ToList();
        }
        public ICollection<GerenciaUsuario> ListarGerenciaPorIdUsuario(int idUsuario)
        {
            //var resultado = contexto.GerenciaUsuario.Include(a => a.Gerencia).Include(a => a.TipoUsuarioGerencia).Include(a => a.UsuarioGerencia).Include(a => a.UsuarioCadastro).Where(a => a.Status == true).ToList()
            //        .Where(x => x.IdUsuarioGerencia == idUsuario)
            //        .Join(contexto.ProcessoTramitacao.Where(pt => pt.DataEnvio == null),
            //              gu => gu.IdGerencia,
            //              pt => pt.IdOrgaoDestino,
            //              (gu, pt) => new { GerenciaUsuario = gu, ProcessoTramitacao = pt })
            //        .ToList();


            var resultado = contexto.GerenciaUsuario.Include(a => a.Gerencia).Include(a => a.TipoUsuarioGerencia).Include(a => a.UsuarioGerencia).Include(a => a.UsuarioCadastro).Where(a => a.Status == true).ToList()

            .Where(x => x.IdUsuarioGerencia == idUsuario)
            .Join(contexto.ProcessoTramitacao
                    .Where(pt => pt.DataEnvio == null),
                gu => gu.IdGerencia,
                pt => pt.IdOrgaoDestino,
                (gu, pt) => new { GerenciaUsuario = gu, ProcessoTramitacao = pt })
            .GroupBy(x => x.GerenciaUsuario.IdGerencia)
            .Select(x => x.FirstOrDefault())
            .ToList();

        var lista = new List<GerenciaUsuario>();
            foreach (var item in resultado)
            {
                var model = new GerenciaUsuario();
                model = item.GerenciaUsuario;
                lista.Add(model);
            }
            return lista;
        }

        public ICollection<GerenciaUsuario> RetornaPorIdGerencia(int id_gerencia)
        {
            return contexto.GerenciaUsuario.Include(a => a.Gerencia).Include(a => a.TipoUsuarioGerencia).Include(a => a.UsuarioGerencia).Include(a => a.UsuarioCadastro).Where(x => (x.IdGerencia == id_gerencia) && x.Status == true).ToList();
        }
    }
}

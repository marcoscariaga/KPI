using SigProc.Domain.Contratos.Servicos;
using SigProc.Dominio.Entidades;


namespace SigProc.Dominio.Contratos.Servicos
{
    public interface IGerenciaPrazoDominioServico : IBaseDominioServico<GerenciaPrazo>
    {
        public ICollection<GerenciaPrazo> ListarAtivos();
        public ICollection<GerenciaPrazo> RetornaPorIdGerencia(int id_gerencia);
        
    }
}

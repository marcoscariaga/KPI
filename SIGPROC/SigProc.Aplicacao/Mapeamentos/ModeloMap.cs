using AutoMapper;
using SigProc.Aplicacao.Modelos.ModeloEntrada;
using SigProc.Domain.Entidades;
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
        }
    }
}

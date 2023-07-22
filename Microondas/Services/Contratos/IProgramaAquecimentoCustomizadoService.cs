using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microondas.Models;

namespace Microondas.Services.Contratos
{
    public interface IProgramaAquecimentoCustomizadoService
    {
        Task<IEnumerable<ProgramaAquecimento>> GetProgramasAquecimento();
        ProgramaAquecimento AddProgramaCustomizado(ProgramaAquecimento programaAquecimento);
    }
}
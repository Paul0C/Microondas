using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microondas.Data;
using Microondas.Models;
using System.Data.SqlClient;
using Microondas.Services.Contratos;
using Microsoft.EntityFrameworkCore;
using Dapper;

namespace Microondas.Services
{
    public class ProgramaAquecimentoCustomizadoService : IProgramaAquecimentoCustomizadoService
    {
        private readonly DataContext _dataContext;
        private readonly string _connectionString;
        private readonly IConfiguration _configuration;

        public ProgramaAquecimentoCustomizadoService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public ProgramaAquecimento AddProgramaCustomizado(ProgramaAquecimento programaAquecimento)
        {
            var programa = _dataContext.ProgramasAquecimento
                                        .Select(p => p.CaracterAquecimento == programaAquecimento.CaracterAquecimento);
            
            if(programa != null) return null;

            _dataContext.Add(programaAquecimento);
            return programaAquecimento;
        }

        public async Task<IEnumerable<ProgramaAquecimento>> GetProgramasAquecimento()
        {
            return await _dataContext.ProgramasAquecimento.ToListAsync();
        }
    }
}
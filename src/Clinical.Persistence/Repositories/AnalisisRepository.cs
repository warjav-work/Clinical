﻿using Clinical.Application.Interface.Repositories;
using Clinical.Domain.Entities;
using Clinical.Persistence.Context;
using Dapper;
using System.Data;

namespace Clinical.Persistence.Repositories
{
    public class AnalisisRepository : IAnalysisRepository
    {
        private readonly ApplicationDbContext _context;

        public AnalisisRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Analysis>> ListAnalysis()
        {
            using var connection = _context.CreateConnection;
            var query = "uspAnalysisList";
            var analisis = await connection.QueryAsync<Analysis>(query, commandType: CommandType.StoredProcedure);
            return analisis;
        }
    }
}

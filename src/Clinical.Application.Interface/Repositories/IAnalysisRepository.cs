﻿using Clinical.Domain.Entities;

namespace Clinical.Application.Interface.Repositories
{
    public interface IAnalysisRepository
    {
        Task<IEnumerable<Analysis>> ListAnalysis();
        Task<Analysis> AnalysisById(int analysisId);
        Task<bool> AnalysisRegister(Analysis analysis);
        Task<bool> AnalysisEdit(Analysis analysis);
    }
}

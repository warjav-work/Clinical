﻿namespace Clinical.Application.Dtos.Analysis.Response
{
    public class GetAllAnalysisResponseDto
    {
        public int AnalysisId { get; set; }
        public string? Name { get; set; }
        public int State { get; set; }
        public DateTime AuditCreateDate { get; set; }
        public string? StateAnalysis { get; set; }
    }
}

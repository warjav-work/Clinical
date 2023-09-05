using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinical.Application.Dtos.Exam
{
    public class GetAllExamResponseDto
    {
        public int ExamId { get; set; }
        public string? Name { get; set; }
        public string? Analysis { get; set; }
        public string? StateExam { get; set; }
        public DateTime? AuditCreateDate { get; set; }
    }
}

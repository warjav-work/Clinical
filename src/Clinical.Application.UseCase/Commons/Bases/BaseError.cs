using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinical.Application.UseCase.Commons.Bases
{
    public class BaseError
    {
        public string? Propertyname { get; set; }
        public string? ErrorMessage { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IzinYonetim.Contracts.V1.Requests
{
    public class IzinHareketiUpdateRequest
    {
        public Guid  Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}

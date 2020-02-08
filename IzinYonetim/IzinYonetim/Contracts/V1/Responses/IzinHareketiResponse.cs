using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IzinYonetim.Contracts.V1.Responses
{
    public class IzinHareketiResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime LeaveBeginDateDate { get; set; }
        public DateTime LeaveEndDate { get; set; }
        public decimal Duration { get; set; }
    }
}

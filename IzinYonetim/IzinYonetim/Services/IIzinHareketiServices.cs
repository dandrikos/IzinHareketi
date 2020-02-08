using IzinYonetim.Contracts.V1.Responses;
using IzinYonetim.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IzinYonetim.Services
{
    public interface IIzinHareketiServices
    {
        Task<List<IzinHareketiResponse>> GetAllIzinHareketi();
        Task<IzinHareketiResponse> GetIzinHareketiById(Guid Id);
        Task<bool> UpdateIzinHareketi(IzinHareketi izinHareketi);
        Task<bool> DeleteIzinHareketi(Guid Id);
        Task<bool> CreateIzinHareketi(IzinHareketi izinHareketi);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IzinYonetim.Contracts.V1.Responses;
using IzinYonetim.Data;
using IzinYonetim.Domain;
using Microsoft.EntityFrameworkCore;

namespace IzinYonetim.Services
{
    public class IzinHareketiServices : IIzinHareketiServices
    {
        private DataContext _dataContext;
        private List<IzinHareketi> _izinhareketleriList;
        public IzinHareketiServices(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IzinHareketiResponse> GetIzinHareketiById(Guid izinHareketiId)
        {
          IzinHareketi izinhareketi =await _dataContext.IzinHareketleri.
                Include(x=>x.Personel).SingleOrDefaultAsync(x => x.ID == izinHareketiId);

            if (izinhareketi == null)
                return null;

            IzinHareketiResponse izinhareketiResponse = new IzinHareketiResponse();
  
            izinhareketiResponse.Id = izinhareketi.ID;
            izinhareketiResponse.Name = izinhareketi.Personel.Adi;
            izinhareketiResponse.Surname = izinhareketi.Personel.Soyadi;
            izinhareketiResponse.LeaveBeginDateDate = izinhareketi.Baslangic;
            izinhareketiResponse.LeaveEndDate = izinhareketi.Bitis;
            izinhareketiResponse.Duration = izinhareketi.Sure;


            return izinhareketiResponse;

        }

        public async Task<List<IzinHareketiResponse>> GetAllIzinHareketi()
        {
            List<IzinHareketiResponse> izinHarekelteriResponseList=new List<IzinHareketiResponse>();
            List<IzinHareketi> izinhareketiList = await _dataContext.IzinHareketleri.
                Include(x=>x.Personel).Take(2).ToListAsync();

            foreach (var item in izinhareketiList)
            {
                IzinHareketiResponse izinhareketiResponse = new IzinHareketiResponse();

                izinhareketiResponse.Id = item.ID;
                izinhareketiResponse.Name = item.Personel.Adi;
                izinhareketiResponse.Surname = item.Personel.Soyadi;
                izinhareketiResponse.LeaveBeginDateDate = item.Baslangic;
                izinhareketiResponse.LeaveEndDate = item.Bitis;
                izinhareketiResponse.Duration = item.Sure;

                izinHarekelteriResponseList.Add(izinhareketiResponse);

            }
            return izinHarekelteriResponseList;
        }

        public async Task<bool> UpdateIzinHareketi(IzinHareketi izinHareketi)
        {

            _dataContext.IzinHareketleri.Update(izinHareketi);
            var updated = await _dataContext.SaveChangesAsync();
            return updated > 0;

        }

        public async Task<bool> DeleteIzinHareketi(Guid izinHateketiId)
        {
             var izinHareketi =  await GetIzinHareketiById(izinHateketiId);
            if (izinHareketi == null)
                return false;

           // _dataContext.IzinHareketleri.Remove(izinHareketi);
            var deleted = await _dataContext.SaveChangesAsync();

            return deleted>0;

        }

        public async Task<bool> CreateIzinHareketi(IzinHareketi izinHareketi)
        {
            await _dataContext.IzinHareketleri.AddAsync(izinHareketi);
            var created = await _dataContext.SaveChangesAsync();

            return created > 0;

        }

    
    }
}

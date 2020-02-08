using IzinYonetim.Contracts;
using IzinYonetim.Contracts.V1.Requests;
using IzinYonetim.Contracts.V1.Responses;
using IzinYonetim.Domain;
using IzinYonetim.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IzinYonetim.Controllers
{

    public class IzinIslemleriController:Controller
    {
        private IIzinHareketiServices _izinHareketiService;

        public IzinIslemleriController(IIzinHareketiServices izinhareketleriService)
        {
            _izinHareketiService = izinhareketleriService;
        }

        [HttpGet(ApiRoutes.IzinHareketleri.GetAll)]
        public async Task<IActionResult> GetAll()
        {
            //return Ok(new IzinHareketiResponse()
            //{
            //    Id = Guid.NewGuid(),
            //    Name = "AAAA"
            //});

            return Ok(await _izinHareketiService.GetAllIzinHareketi());
        }

        //Todo Zayıf nokta Get([FromRoute] Guid izinHareketiId) izinHareketiId Route tanımlamasındaki "/IzinHareketi/{izinHareketiId}"; ile aynı oşmalı. 
        //Arkadaslara bunu nasıl giderebiliriz konusalım.
        [HttpGet(ApiRoutes.IzinHareketleri.Get)]
        public async Task<IActionResult> Get([FromRoute] Guid izinHareketiId)
        {
            IzinHareketiResponse izinhareketiResp = await _izinHareketiService.GetIzinHareketiById(izinHareketiId);
            if (izinhareketiResp == null)
                return NotFound();

            return Ok(izinhareketiResp);
        }
        [HttpPost(ApiRoutes.IzinHareketleri.Create)]
        public async Task<IActionResult> Create([FromBody] IzinHareketiCreateRequest  izinhareketleriRequest)
        {
            IzinHareketi izinHareketi = new IzinHareketi { ID=izinhareketleriRequest.Id,
                IzinOrtakSatirlarID = Guid.NewGuid(),
                Alacak = izinhareketleriRequest.Alacak

            };
            if (izinHareketi.ID == Guid.Empty)
                izinHareketi.ID = Guid.NewGuid();

            await _izinHareketiService.CreateIzinHareketi(izinHareketi);


            var baseUrl = $" {HttpContext.Request.Scheme}://{HttpContext.Request.Host.ToUriComponent()}";
            var locationUri = baseUrl + "/" + ApiRoutes.IzinHareketleri.Get.Replace("{izinHareketiId}", izinHareketi.ID.ToString());

            IzinHareketiResponse izinHareketiResponse = new IzinHareketiResponse { Id = izinHareketi.ID, Name = izinHareketi.Personel.Adi, Surname = izinHareketi.Personel.Soyadi };

            return Created(locationUri, izinHareketiResponse);
        }

        [HttpPut(ApiRoutes.IzinHareketleri.Update)]
        public async Task<IActionResult> Update([FromRoute] Guid izinHareketiId,[FromBody] IzinHareketiUpdateRequest izinhareketiUpdateRequest)
        {
            //IzinHareketi izinhareketi = new IzinHareketi()
            //{
            //    Id = izinhareketiUpdateRequest.Id,
            //    Name = izinhareketiUpdateRequest.Name,
            //    Surname = izinhareketiUpdateRequest.Surname
            //};

            //var updated = await _izinHareketiService.UpdateIzinHareketi(izinhareketi);

            //if (updated)
            //    return Ok(izinhareketi);

            return NotFound();


        }

        public async Task<IActionResult> Delete(Guid id)
        {
            bool silindi= await _izinHareketiService.DeleteIzinHareketi(id);
            if (silindi == true)
                //return Ok(silinenKayit)  Bu secenekte kullanılabilir. Senaryoya gore kara vermek lazım.
                return NoContent();

            return NotFound();
        }

    }
}

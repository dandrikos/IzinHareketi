using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IzinYonetim.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("IzinTipleri")]
    public partial class IzinTipleri
    {
        public Guid ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Kod { get; set; }

        [Required]
        [StringLength(50)]
        public string Tanim { get; set; }

        public bool Dusecek { get; set; }

        public string SureDilimi { get; set; }



        public decimal? GiristeMaximumDeger { get; set; }
        public decimal? AylikMaximumKullanim { get; set; }

        public decimal? YillikMaximumKullanim { get; set; }

        public decimal? OnDeger { get; set; }

        public bool IKOnaylamasiGerekir { get; set; }
        public bool YoneticiOnaylamasiGerekir { get; set; }

        public bool AlacakIzniIcinKullanilabilir { get; set; }
        public bool NormalIzniIcinKullanilabilir { get; set; }

        public bool ResmiTatilCakismaKontroluYapilacak { get; set; }

        public bool Pasif { get; set; }


        public string VardiyaTipKodu { get; set; }

        public bool CakismaKontroluYapilmayacak { get; set; }

        public bool TipiHaftaTatili { get; set; }

        public Guid? KurumParametresiID { get; set; }

        public decimal Carpan { get; set; }

        public bool TipiYillikIzin { get; set; }

        public bool TipiResmiTatil { get; set; }
    }
}

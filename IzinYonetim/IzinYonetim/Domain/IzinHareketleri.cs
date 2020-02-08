using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IzinYonetim.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("IzinHareketleri")]
    public partial class IzinHareketi
    {
        //public IzinHareketleri()
        //{
        //    PersonelVardiya = new HashSet<PersonelVardiya>();
        //}

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }

        public Guid IzinOrtakSatirlarID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IzinOlusmaSiraNo { get; set; }

        public string IzinFormuBelgeNo { get; set; }

        //Personelin Alacagı olup olmadıgını gosteriyor....
        public bool Alacak { get; set; }

        public Guid PersonelID { get; set; }

        public Guid IzinTipleriID { get; set; }

        public DateTime Baslangic { get; set; }

        public DateTime Bitis { get; set; }

        public string SureDilimi { get; set; }

        public decimal Sure { get; set; }

        [StringLength(350)]
        public string Aciklama { get; set; }

        public bool IKOnayladi { get; set; }
        public DateTime? IKOnaylamaTarihi { get; set; }
        public Guid? OnaylayanIKSorumlusuID { get; set; }


        public bool YoneticiOnayladi { get; set; }
        public DateTime? YoneticiOnaylamaTarihi { get; set; }
        public Guid? OnaylayanYoneticiID { get; set; }

        public bool RetEdildi { get; set; }
        public DateTime? RetEdilmeTarihi { get; set; }
        public Guid? RetEdenKullaniciID { get; set; }


        public bool IzinFormuImzalandimi { get; set; }

        public DateTime? IzinFormuImzalanmaTarihi { get; set; }

        [StringLength(250)]
        public string Adres { get; set; }

        public virtual Personel Personel { get; set; }
        public virtual IzinTipleri IzinTipleri { get; set; }

        [ForeignKey("OnaylayanYoneticiID")]
        public virtual User OnaylayanYonetici { get; set; }

        [ForeignKey("OnaylayanIKSorumlusuID")]
        public virtual User OnaylayanIKSorumlusu { get; set; }

        //public virtual ICollection<PersonelVardiya> PersonelVardiya { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] RowVersion { get; set; }
        public DateTime CreateDate { get; set; }
        public Guid CreatedByUserID { get; set; }
        public DateTime UpdateDate { get; set; }
        public Guid UpdatedByUserID { get; set; }

    }
}

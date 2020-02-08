using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IzinYonetim.Domain
{


    [Table("Personel")]
    public partial class Personel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]

        [Key] [DatabaseGenerated(DatabaseGeneratedOption.Identity)] public Guid ID { get; set; }

        public Guid? EskiID { get; set; }
        public Guid BordroTipiID { get; set; }

        [Required]
        [StringLength(50)]
        public string SicilNo { get; set; }

        [StringLength(250)]
        public string FotoAdresi { get; set; }

        [StringLength(50)]
        public string SosyalSigortaNo { get; set; }

        [StringLength(50)]
        public string SigortaKimlikNo { get; set; }


        [StringLength(50)]
        public string IhtiyatSandigiNo { get; set; }

        public Guid ProfileID { get; set; }

        [Required]
        public string Adi { get; set; }

        [Required]
        public string Soyadi { get; set; }

        [NotMapped]
        public string AdiSoyadi
        {
            get { return this.Adi + " " + this.Soyadi; }
            //  set { }
        }



        //[NotMapped]
        [StringLength(50)]
        public string BordroKod { get; set; }

        [StringLength(50)]
        public string Gorevi { get; set; }

        [Column(TypeName = "date")]
        public DateTime IseBaslamaTarihi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FiiliGirisTarihi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? GrubaIlkResmiGirisTarihi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FiiliAyrilisTarihi { get; set; }


        [Column(TypeName = "date")]
        public DateTime? IstenAyrilisTarihi { get; set; }

        public Guid? IstenAyrilisNedenleriID { get; set; }

        [StringLength(250)]
        public string AyrilisNedeniAciklama { get; set; }

        [StringLength(50)]
        public string AyrilmaNedeni { get; set; }

        [Column(TypeName = "date")]
        public DateTime? KKTCGirisTarihi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CalismaIzniBaslangicTarihi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CalismaIzniBitisTarihi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CalismaIzniBasvuruTarihi { get; set; }

        public int? CalismaIzniSure { get; set; }


        [StringLength(50)]
        public string OncekiCalistigiYer { get; set; }

        public Guid IsyeriID { get; set; }

        public Guid BolumID { get; set; }

        public Guid BirimID { get; set; }

        public Guid? MaasSkalaID { get; set; }

        [Required]
        [StringLength(10)]
        public string MaasTipi { get; set; }

        public decimal MaasTutar { get; set; }

        [NotMapped]
        public decimal? MaasX { get; set; }

        public byte[] MaasButceX { get; set; }


        public decimal? MaasDoviz { get; set; }

        public Guid? DovizTipId { get; set; }

        public int MaasSayisi { get; set; }

        [Required]
        [StringLength(50)]
        public string OdemeSekli { get; set; }

        public decimal DevirKumulatifVergiMatrahi { get; set; }
        //public int DevirKumulatifVergiMatrahiAySayisi { get; set; }

        public bool TopluUcretAyarlamayaDahil { get; set; }

        public bool GelirVergisindenMuaf { get; set; }

        public bool DamgaVergisindenMuaf { get; set; }

        public Guid? BankaID { get; set; }

        public Guid? BankaSubeID { get; set; }

        [StringLength(50)]
        public string BankaHesapNo { get; set; }

        [StringLength(50)]
        public string BankaIBAN { get; set; }

        [StringLength(50)]
        public string YetkiKodu { get; set; }

        public int CocukSayisi { get; set; }

        [StringLength(50)]
        public string Unvan { get; set; }

        public Guid? EngelliTanimiID { get; set; }

        public int PersonelTipPuani { get; set; }

        [Required]
        [StringLength(50)]
        public string MedeniHali { get; set; }

        public bool EsiCalisiyorMu { get; set; }

        public bool SosyalSigortaIlkGirisMi { get; set; }

        public decimal? IhtiyatSandigiIsciKesintiOrani { get; set; }

        public decimal? IhtiyatSandigiIsverenKesintiOrani { get; set; }

        public bool TPSDahil { get; set; }

        public bool VergiAylikHesaplansin { get; set; }

        public int? IsverenBasamak { get; set; }

        public Guid UyrukUlkeID { get; set; }

        public bool? IzniYonticiOnaylayacak { get; set; }

        public string VardiyaSiraNo { get; set; }

        //public virtual Banka Banka { get; set; }

        //public virtual BankaSube BankaSube { get; set; }

        //public virtual Birim Birim { get; set; }

        //public virtual Bolum Bolum { get; set; }





        //public virtual DovizTip DovizTip { get; set; }

        //public virtual EngelliTanimi EngelliTanimi { get; set; }

        //public virtual Isyeri Isyeri { get; set; }

        //public virtual Profile Profile { get; set; }

        //public virtual UyrukUlke UyrukUlke { get; set; }

        //public virtual MaasSkala MaasSkala { get; set; }

        public Guid? KaynakPersonelID { get; set; }
        public bool? KKTCVatandasMuafiyeti { get; set; }

        //-----------------------------Bas

        [StringLength(50)]
        public string VergiKimlikNo { get; set; }


        public Guid? OncekiBolumID { get; set; }

        public Guid? OncekiBirimID { get; set; }

        public string KadroDurumu { get; set; }


        [StringLength(50)]
        public string GercekMeslegi { get; set; }

        public int? ExternalRecordRef { get; set; }

        public Int16? ExternalOlusturanKullanici { get; set; }
        public DateTime? ExternalOlusturmaTarih { get; set; }
        public Int16? ExternalOlusturmaSaat { get; set; }
        public Int16? ExternalOlusturmaDakika { get; set; }
        public Int16? ExternalOlusturmaSaniye { get; set; }

        public Int16? ExternalSonGunclleyenKullanici { get; set; }
        public DateTime? ExternalSonGuncellemeTarih { get; set; }
        public Int16? ExternalSonGuncellemeSaat { get; set; }
        public Int16? ExternalSonGuncellemeDakika { get; set; }
        public Int16? ExternalSonGuncellemeSaniye { get; set; }

        public string PDKSSicilNo { get; set; }

        public bool? DuzensizVardiya { get; set; } = false;

        public string VardiyaKod { get; set; }
        public string HaftaTatiliGunu1 { get; set; }
        public string HaftaTatiliGunu2 { get; set; }

        public bool Deneme30GunIKOnay { get; set; } = false;
        public bool Deneme60GunIKOnay { get; set; } = false;
        public bool Deneme90GunIKOnay { get; set; } = false;

        public bool Deneme30GunManagerOnay { get; set; } = false;
        public bool Deneme60GunManagerOnay { get; set; } = false;
        public bool Deneme90GunManagerOnay { get; set; } = false;

        public string BildirimYapilacakEmailler { get; set; }

        public string ExternalSicilNo { get; set; }
        public Guid? YoneticisiID { get; set; }

        public virtual Personel Yoneticisi { get; set; }


        //************************Son

    }
}


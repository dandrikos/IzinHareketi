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


    [Table("User")]
    public partial class User
    {


        [Key] [DatabaseGenerated(DatabaseGeneratedOption.Identity)] public Guid ID { get; set; }

        [Required]
        [StringLength(10)]
        public string Initials { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(50)]
        public string Culture { get; set; }

        [Required]
        [StringLength(50)]
        public string LoginName { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        public DateTime? LoginValidFrom { get; set; }

        public DateTime? LoginValidTo { get; set; }

        public bool? IsFullTime { get; set; }

        public DateTime? AccountDisabledFrom { get; set; }

        public DateTime? AccountDisabledTo { get; set; }

        [StringLength(4000)]
        public string AccountDisableReason { get; set; }

        public bool IsActive { get; set; }

        [StringLength(50)]
        public string DateCulture { get; set; }

        public bool? IsPasswordEncoded { get; set; }

        public Guid? UserRoleID { get; set; }

        [StringLength(50)]
        public string IDCardNumber { get; set; }

        //public Guid AllowedFirmID { get; set; }

        public Guid? DefaultIsyeriID { get; set; }

        public string Department { get; set; }


        public string Email { get; set; }


    }
}

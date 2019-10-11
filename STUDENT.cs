namespace DormitoryManageSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("STUDENT")]
    public partial class STUDENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public STUDENT()
        {
            RENTs = new HashSet<RENT>();
        }

        [StringLength(20)]
        public string STUDENTID { get; set; }

        [StringLength(50)]
        public string STUDENTNAME { get; set; }

        public int? GENDER { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DOB { get; set; }

        [StringLength(20)]
        public string CMND { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATECMND { get; set; }

        [StringLength(200)]
        public string ISSUEDBY { get; set; }

        [StringLength(100)]
        public string RELIGION { get; set; }

        [StringLength(100)]
        public string FOLK { get; set; }

        [StringLength(100)]
        public string NATION { get; set; }

        public int? STUDENTYEAR { get; set; }

        [StringLength(200)]
        public string STUDYAT { get; set; }

        [StringLength(50)]
        public string DEPARTMENT { get; set; }

        [StringLength(200)]
        public string PHONENUMBER { get; set; }

        [StringLength(200)]
        public string ADDRESSS { get; set; }

        [StringLength(100)]
        public string EMAIL { get; set; }

        [StringLength(100)]
        public string PHOTO { get; set; }
        public int? STATUSS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RENT> RENTs { get; set; }
    }
}

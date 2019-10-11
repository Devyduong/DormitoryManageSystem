namespace DormitoryManageSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOMEFLEET")]
    public partial class HOMEFLEET
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOMEFLEET()
        {
            ROOMs = new HashSet<ROOM>();
        }

        [Key]
        public int HFID { get; set; }

        [StringLength(50)]
        public string HFNAME { get; set; }

        public int? NUMBEROFROOM { get; set; }

        public int? STATUSS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROOM> ROOMs { get; set; }
    }
}

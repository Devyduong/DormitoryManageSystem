namespace DormitoryManageSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ROOM")]
    public partial class ROOM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ROOM()
        {
            RENTs = new HashSet<RENT>();
        }

        public int ROOMID { get; set; }

        [StringLength(100)]
        public string ROOMNAME { get; set; }

        public int? HOMEFLEET { get; set; }

        public int? FORGENDER { get; set; }

        public int? BEDNUMBER { get; set; }

        public int? BEDEMPTY { get; set; }

        [StringLength(200)]
        public string INCLUDED { get; set; }

        public int? STATUSS { get; set; }

        public virtual HOMEFLEET HOMEFLEET1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RENT> RENTs { get; set; }
    }
}

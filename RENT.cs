namespace DormitoryManageSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RENT")]
    public partial class RENT
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string RENTER { get; set; }

        public int? ROOM { get; set; }

        [StringLength(50)]
        public string THELEASE { get; set; }

        public double? TOTALFEE { get; set; }

        public double? PAID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CREATEDATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? STARTDATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ENDDATE { get; set; }

        public int? STATUSS { get; set; }

        public virtual STUDENT STUDENT { get; set; }

        public virtual ROOM ROOM1 { get; set; }
    }
}

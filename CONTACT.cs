namespace DormitoryManageSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONTACT")]
    public partial class CONTACT
    {
        [Key]
        public int CID { get; set; }

        [StringLength(50)]
        public string SENDER { get; set; }

        [StringLength(200)]
        public string TITLE { get; set; }

        [Column(TypeName = "ntext")]
        public string CONTENT { get; set; }

        public int? STATUSS { get; set; }
    }
}

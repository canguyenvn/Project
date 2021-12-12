namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Quotation_Detail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Q_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Q_Title { get; set; }

        public int Q_User_Create_ID { get; set; }

        [StringLength(500)]
        public string Q_Delivery_place { get; set; }

        [StringLength(100)]
        public string Q_Pickup_method { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Q_Create_Date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Q_Deadline_Date { get; set; }

        [Required]
        [StringLength(50)]
        public string Q_Date_of_Expiry { get; set; }

        [StringLength(50)]
        public string Q_Tax { get; set; }

        [StringLength(500)]
        public string Q_Remarks { get; set; }
    }
}

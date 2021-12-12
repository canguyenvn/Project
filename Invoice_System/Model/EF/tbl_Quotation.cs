namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Quotation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Q_ID { get; set; }

        [Required]
        [StringLength(10)]
        public string Q_Number { get; set; }

        [Required]
        [StringLength(50)]
        public string Customer_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Q_Amount { get; set; }
    }
}

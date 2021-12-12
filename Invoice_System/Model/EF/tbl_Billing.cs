namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Billing
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Billing_ID { get; set; }

        [StringLength(10)]
        public string Billing_Number { get; set; }

        public int Customer_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Billing_Amount { get; set; }
    }
}

namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Billing_Detail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Billing_ID { get; set; }

        [StringLength(150)]
        public string Billing_Line_Type { get; set; }

        [StringLength(500)]
        public string Billing_Description_Generally { get; set; }

        public int? Billing_Qty { get; set; }

        [StringLength(500)]
        public string Billing_Description_Type { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Billing_UnitPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Billing_Price { get; set; }

        [StringLength(500)]
        public string Billing_Heading { get; set; }

        [StringLength(500)]
        public string Billing_Text { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Billing_Discount { get; set; }
    }
}

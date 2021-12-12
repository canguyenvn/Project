namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Order_ID { get; set; }

        public int Customer_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Order_Amount { get; set; }

        public DateTime Order_Date { get; set; }
    }
}

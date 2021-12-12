namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_User_Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int User_ID { get; set; }

        [StringLength(150)]
        public string User_Address { get; set; }

        [StringLength(150)]
        public string User_City_Address { get; set; }

        public int? User_Postal_Code { get; set; }

        [StringLength(150)]
        public string User_Building_Address { get; set; }
    }
}

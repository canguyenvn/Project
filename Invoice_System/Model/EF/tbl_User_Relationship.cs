namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_User_Relationship
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int User_Relationship_ID { get; set; }

        public int User_ID { get; set; }

        public int User_Mode_ID { get; set; }

        public virtual tbl_Mode tbl_Mode { get; set; }

        public virtual tbl_User tbl_User { get; set; }
    }
}

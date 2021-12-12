namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Notice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Notice_ID { get; set; }

        public int Notice_Author_ID { get; set; }

        [Required]
        [StringLength(200)]
        public string Notice_Title { get; set; }

        [StringLength(100)]
        public string Notice_Author { get; set; }

        [StringLength(500)]
        public string Notice_Content { get; set; }

        [StringLength(200)]
        public string Notice_Attachment_File { get; set; }
    }
}

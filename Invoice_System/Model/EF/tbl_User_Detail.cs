namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_User_Detail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int User_Detail_ID { get; set; }

        public int User_Mode_ID { get; set; }

        [StringLength(100)]
        public string User_Name_Kana { get; set; }

        [StringLength(50)]
        public string User_Shortcut { get; set; }

        public int? User_Bussiness_Type { get; set; }

        [StringLength(10)]
        public string User_Honorific_Title { get; set; }

        [StringLength(100)]
        public string User_Department { get; set; }

        [StringLength(100)]
        public string User_Person_Incharge { get; set; }

        [Required]
        [StringLength(50)]
        public string User_Division { get; set; }

        [StringLength(15)]
        public string User_Phone_Number { get; set; }

        [StringLength(100)]
        public string User_Email { get; set; }

        public int? User_Prefectures { get; set; }

        [StringLength(50)]
        public string User_Payment_Terms { get; set; }

        [StringLength(50)]
        public string User_Tax { get; set; }

        public int? User_Invoice_Sending_Method { get; set; }

        public int? User_E_Seal { get; set; }

        [StringLength(500)]
        public string User_Memo { get; set; }

        public virtual tbl_Mode tbl_Mode { get; set; }
    }
}

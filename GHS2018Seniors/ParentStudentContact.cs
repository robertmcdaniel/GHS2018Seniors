namespace GHS2018Seniors
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ParentStudentContact
    {
        [Key]
        public int ContactId { get; set; }

        [Required]
        [StringLength(100)]
        public string ContactFName { get; set; }

        [StringLength(100)]
        public string ContactLName { get; set; }

        [StringLength(250)]
        public string EmailAddress { get; set; }

        [StringLength(250)]
        public string HomeWorkNumber { get; set; }

        [StringLength(250)]
        public string CellNumber { get; set; }

        [Required]
        [StringLength(100)]
        public string StudentFName { get; set; }

        [StringLength(100)]
        public string StudentLName { get; set; }

        [StringLength(250)]
        public string StudentEmailAddress { get; set; }

        [StringLength(250)]
        public string StudentCellNumber { get; set; }

        public bool? HelpWithFloat { get; set; }

        public bool? HelpWithSkit { get; set; }

        public bool? HelpWithFood { get; set; }
    }
}

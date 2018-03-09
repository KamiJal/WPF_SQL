namespace ADONET
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Manufacturer")]
    public partial class Manufacturer
    {
        [Key]
        public int intManufacturerID { get; set; }

        [StringLength(50)]
        public string strName { get; set; }

        [StringLength(50)]
        public string strManufacturerChecklistId { get; set; }

        [StringLength(50)]
        public string ManufacturerDescription { get; set; }
    }
}

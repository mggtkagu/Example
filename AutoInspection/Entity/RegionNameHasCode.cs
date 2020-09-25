namespace AutoInspection.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RegionNameHasCode")]
    public partial class RegionNameHasCode
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodeId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RegionNameId { get; set; }

        [Column("ISO3166-2")]
        [StringLength(20)]
        public string ISO3166_2 { get; set; }

        public virtual Code Code { get; set; }

        public virtual Region_Name Region_Name { get; set; }
    }
}

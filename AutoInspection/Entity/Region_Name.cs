namespace AutoInspection.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Region_Name
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Region_Name()
        {
            Region = new HashSet<Region>();
            RegionNameHasCode = new HashSet<RegionNameHasCode>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string RegionNameEn { get; set; }

        [Required]
        [StringLength(255)]
        public string RegionNameRu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Region> Region { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegionNameHasCode> RegionNameHasCode { get; set; }
    }
}

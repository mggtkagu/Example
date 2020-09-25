namespace AutoInspection.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Region")]
    public partial class Region
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Region()
        {
            Right_znak = new HashSet<Right_znak>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string SubjectCode { get; set; }

        [Required]
        [StringLength(50)]
        public string OKATOCode { get; set; }

        public int RegionNameId { get; set; }

        public virtual Region_Name Region_Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Right_znak> Right_znak { get; set; }
    }
}

namespace WebApplication1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Proveedor")]
    public partial class Proveedor
    {
        public int ID { get; set; }

        public int? cuenta { get; set; }

        [Required]
        [StringLength(50)]
        public string rsocial { get; set; }

        [Required]
        [StringLength(25)]
        public string resum { get; set; }

        [Required]
        [StringLength(50)]
        public string localidad { get; set; }

        [Required]
        [StringLength(50)]
        public string codpostal { get; set; }

        [Required]
        [StringLength(50)]
        public string provin { get; set; }

        [Required]
        [StringLength(20)]
        public string cuit { get; set; }

        public int? tipoiva { get; set; }

        [Required]
        [StringLength(14)]
        public string contab { get; set; }

        [Required]
        [StringLength(14)]
        public string contab1 { get; set; }

        [Required]
        [StringLength(50)]
        public string calle { get; set; }

        public int? nro { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fechaingerso { get; set; }
    }
}

namespace WebApplication1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TIPOIVA")]
    public partial class TIPOIVA
    {
        public int ID { get; set; }

        [Column("tipoiva")]
        public int tipoiva1 { get; set; }

        [Required]
        [StringLength(16)]
        public string descrip { get; set; }

        [Required]
        [StringLength(5)]
        public string abrevia { get; set; }

        public decimal porcen1 { get; set; }

        public decimal porcen2 { get; set; }

        [Required]
        [StringLength(10)]
        public string cuenta1 { get; set; }

        [Required]
        [StringLength(10)]
        public string cuenta2 { get; set; }

        [Required]
        [StringLength(1)]
        public string abc { get; set; }
    }
}

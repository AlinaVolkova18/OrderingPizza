namespace DAL.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Composition_string
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Composition_string_id { get; set; }

        public decimal? Count { get; set; }

        public int? Pizza_id { get; set; }

        public int Ingredient_id { get; set; }

        public virtual Ingredient Ingredient { get; set; }

        public virtual Pizza Pizza { get; set; }
    }
}

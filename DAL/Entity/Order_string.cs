namespace DAL.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order_string
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Order_string_id { get; set; }

        public decimal? Count { get; set; }

        public decimal? Cost { get; set; }

        public int? Pizza_id { get; set; }

        public int? Order_id { get; set; }

        public virtual Order Order { get; set; }

        public virtual Pizza Pizza { get; set; }
    }
}

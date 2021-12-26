namespace DAL.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Order_id { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(50)]
        public string List { get; set; }

        [StringLength(50)]
        public string Date_Time { get; set; }

        [StringLength(50)]
        public string Data { get; set; }

        public int? User_id { get; set; }

        public int? Status_id { get; set; }

        public virtual Admin Admin { get; set; }

        public virtual Client Client { get; set; }

        public virtual Order_string Order_string { get; set; }

        public virtual Status Status { get; set; }
    }
}

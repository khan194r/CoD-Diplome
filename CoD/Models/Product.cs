namespace CoD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            OrderProduct = new HashSet<OrderProduct>();
        }

        [Key]
        public int Product_ID { get; set; }

        [Required]
        [StringLength(70)]
        public string Product_Name { get; set; }

        public int CategoryID { get; set; }

        [Required]
        [StringLength(50)]
        public string Product_Manufacture { get; set; }

        public int Quantity_in_stock { get; set; }

        public int Product_Cost { get; set; }

        public int Product_Discount_Percent { get; set; }

        public string Product_Description { get; set; }

        public bool Product_Recipe { get; set; }
        public string Product_Recipe_Str
        {
            get
            {
                if (Product_Recipe)
                {
                    return "Да";
                }
                else
                {
                    return "Нет";
                }
            }
        }

        [Column(TypeName = "image")]
        public byte[] Product_Photo { get; set; }

        public virtual Category Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderProduct> OrderProduct { get; set; }
    }
}

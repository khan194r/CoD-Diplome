namespace CoD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Order = new HashSet<Order>();
        }

        [Key]
        public int User_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string User_LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string User_Name { get; set; }

        [StringLength(50)]
        public string User_MiddleName { get; set; }

        [Required]
        [StringLength(50)]
        public string User_Login { get; set; }

        [Required]
        [StringLength(50)]
        public string User_Password { get; set; }

        [Column(TypeName = "date")]
        public DateTime User_DateBirthDay { get; set; }

        public int RoleID { get; set; }

        [Required]
        [StringLength(50)]
        public string User_Phone { get; set; }

        [StringLength(50)]
        public string User_Email { get; set; }

        public int User_DiscountBonus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }

        public virtual Role Role { get; set; }
    }
}

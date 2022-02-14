using InsuranceSystem.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace InsuranceSystem.Entity.Models
{
    public partial class Customer : EntityBase
    {
        //public Customer()
        //{
        //    Orders = new HashSet<Order>();
        //}

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int CustomerId { get; set; }

        [MaxLength(40)]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [MaxLength(40)]
        [Required(ErrorMessage = "Surname is required")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Identity is required")]
        public string IdentityNo { get; set; }

        [Required(ErrorMessage = "Birth date is required")]
        public DateTime BirthDate { get; set; }

        [MaxLength(100)]
        //[RegularExpression(@" ^ ([\w\.\-] +)@([\w\-] +)((\.(\w){2, 3})+)$", ErrorMessage = "Please type a valid email address.")]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        //[RegularExpression(@"^(05(\d{9}))$", ErrorMessage = "Please type a valid phone number.")] //05xxxxxxxxx telefon numarasi kontrolu
        [Required(ErrorMessage = "Phone is required")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public string Gender { get; set; }

        [MinLength(20)]
        [MaxLength(250)]
        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }
        [Required(ErrorMessage = "City is required")]
        public int CityId { get; set; }
        [Required(ErrorMessage = "Region is required")]
        public int RegionId { get; set; }
        [Required(ErrorMessage = "Height is required")]
        public int Height { get; set; }
        [Required(ErrorMessage = "Weight is required")]
        public int Weight { get; set; }

        public virtual City City { get; set; }
        public virtual Region Region { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}

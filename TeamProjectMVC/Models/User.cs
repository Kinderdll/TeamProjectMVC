using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TeamProjectMVC.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }

        [Required(ErrorMessage = "A first name is required")]
        [StringLength(45)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "A last name is required")]
        [StringLength(45)]
        public string LastName { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Telephone { get; set; }

        [Required(ErrorMessage = "An email address is required")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public enum CustomerCategory { Individual = 1, Company = 2 } 
        public CustomerCategory Category { get; set; }

        public string CompanyName { get; set; }
        public string TaxOffice { get; set; }
        public int TRN { get; set; }
    }
    


   
    //public class Individual
    //{
    //    [ForeignKey("User")]
    //    public int ID { get; set; }
    //}
    //public class Company
    //{
    //    public int C_ID { get; set; }
    //    public string CompanyName { get; set; }
    //    public int TRN { get; set; }
    //    public string TaxOffice { get; set; }
    //}
}
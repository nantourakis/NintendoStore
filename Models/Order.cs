using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NintendoStore.Models
{
    public class Order
    {
        //info about the user
        // Dont Bind order id since the user wont be typing this in
        [BindNever]
        public int OrderID { get; set; }

        //bind data to include validation for the Form
        [Required(ErrorMessage = "Please enter your first name")]
        [Display(Name = "First Name")]
        [StringLength(25)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name")]
        [Display(Name = "Last Name")]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your address")]
        [Display(Name = "Street Address")]
        [StringLength(25)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter your City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter your state")]
        [StringLength(2, MinimumLength = 2)]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter your Zip Code")]
        [Display(Name = "Zip Code")]
        [StringLength(5, MinimumLength = 5)]
        public string Zipcode { get; set; }

        [Required(ErrorMessage = "Please enter your Phone Number")]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }

        //related to the order
        public List<OrderDetail> OrderDetails { get; set; }

        [BindNever]
        [Column(TypeName = "decimal(18,2)")]
        public decimal OrderTotal { get; set; }

        [BindNever]
        public DateTime OrderPlaced { get; set; }


    }
}

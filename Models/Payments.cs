using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Payment_Sytem.Models
{
    public class Payments
    {

        public int Id { get; set; }
        [Required ]
       
        [RegularExpression("([a-zA-Z0-9 .&'-]+)", ErrorMessage = "Invalid First Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter Your valid surname")]
        [StringLength(100)]
        [DataType(DataType.Text)]
        public string SurName { get; set; }
        public string Department { get; set; }
  
        public DateTime Date_of_payment_requested { get; set; }
        [Required]
      
        public string Date_Invoice { get; set; }
        [Required(ErrorMessage ="enter the benefiacy's Name")]
        public string Payment_For { get; set; }
        public string Description_of_payment { get; set; }
        //[RegularExpression(" ^[0-9]+$", ErrorMessage = "Enter Account number in digits")]
        [Required(ErrorMessage ="account number required")]
        public int Account_Number { get; set; }
        [Required (ErrorMessage ="Name of authoring Manager required")]
        public string Manager_Name { get; set; }
        [Required(ErrorMessage = "Manager's signature required")]
        public string Manager_Signature { get; set; }
        [NotMapped]
        [Display(Name = " Unload your invoice in PDF formate")]
        public IFormFile InvoicePdf { get; set; }
        public string  InvoicePdfUrl { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebApp.Models
{
    public class OrderHeader
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public double OrderTotalOriginal { get; set; }
        [Required]
        [DisplayFormat(DataFormatString ="{0:C}")]
        [Display(Name = "Order Total")]
        public double OrderTotal { get; set; }

        [Required]
        [Display(Name ="Delivery Time")]
        public DateTime DeliveryTime { get; set; }

        [Required]
        [NotMapped]
        public DateTime DeliveryDate { get; set; }
        [Display(Name ="Coupon Code")]
        public string CouponCode { get; set; }
        public string CouponCodeDiscount{ get; set; }
        public string Status { get; set; }
        public string PaymentStatus { get; set; }
        public string Comment { get; set; }

        [Display(Name = "Pickup Name")]
        public string PickupName { get; set; }

        [Display(Name = "Pickup Phonenumber")]
        public string Phonenumber { get; set; }

        [Display(Name = "Transcaction Ref")]
        public string TransactionRef { get; set; }



    }
}

using System.ComponentModel.DataAnnotations;

namespace HotelBookingAPI.DTOs.PaymentDTOs
{
    public class ProcessPaymentDTO
    {
        [Required]
        public int ReservationID{get; set; }
        
        [Required]
        [Range(0.01,Double.MaxValue, ErrorMessage = "Total amount must be greater than zero")]
        public decimal TotalAmount { get; set; } // Total amount to be paid 
        
        [Required]
        [StringLength(50)]
        public string PaymentMethod { get; set; } // e.g., "Credit Card", "Debit Card", "Net Banking"
    }
}

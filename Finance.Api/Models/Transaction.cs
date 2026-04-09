using System.ComponentModel.DataAnnotations;
using System;

namespace Finance.Api.Models
{
    public class Transaction
    {
        public int Id {get; set; }

        [Required]
        public string Description { get; set; } = string.Empty;

        [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than zero.")]
        public decimal Amount { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        public string Category { get; set; } = string.Empty;

        public string UserId { get; set; } = string.Empty;

    }
}

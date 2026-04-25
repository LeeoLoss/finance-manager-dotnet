using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Finance.Api.Models
{
    public class Transaction
    {
        public string UserId { get; set; } = string.Empty;

        public int Id {get; set; }

        [Required]
        public string Description { get; set; } = string.Empty;

        [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than zero.")]
        public decimal Amount { get; set; }

        [Column("TransactionDate")]
        public DateTime Data { get; set; } = DateTime.Now;

        public string TransactionType { get; set; } = string.Empty;
    }
}

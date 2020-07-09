using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.Data.Entities
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string FirstName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string LastName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(60)")]
        public string Email { get; set; }
        [Required]
        [Column(TypeName = "char(1)")]
        public string Gender { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string ContatctNo { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(60)")]
        public string Address_Line1 { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(60)")]
        public string Address_Line2 { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(60)")]
        public string State { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(60)")]
        public string PostalCode { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Password { get; set; }
    }
}

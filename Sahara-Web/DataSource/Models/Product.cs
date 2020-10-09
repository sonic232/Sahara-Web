using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaharaWeb.DataSource.Models
{
    public class Product
    {
        /// <summary>
        /// Unique identifier
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Name for Product
        /// </summary>
        [MaxLength(200)]
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Price of Product. Note this would normally also come with something like what currency it is under. It is kept as Price for simplicity
        /// </summary>
        [Required]
        public decimal Price { get; set; }
        /// <summary>
        /// Additional details about product
        /// </summary>
        [MaxLength(5000)]
        public string Description { get; set; }
        /// <summary>
        /// Date the record was created
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        /// <summary>
        /// The last date this product was modified
        /// </summary>
        public DateTime? LastModified { get; set; }


        /// <summary>
        /// Foreign Key for Category
        /// </summary>
        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }
        /// <summary>
        /// The Category this product belongs to
        /// </summary>
        public Category Category { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaharaWeb.DataSource.Models
{
    /// <summary>
    /// Defines the various categories that can exist for products to be listed under
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Unique identifier
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public readonly int Id;
        /// <summary>
        /// The name of the category
        /// </summary>
        [MaxLength(200)]
        [Required]
        public string Name;
        /// <summary>
        /// Describe what constitutes items in this category
        /// </summary>
        [MaxLength(5000)]
        public string Description;
        /// <summary>
        /// Date the record was created
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        /// <summary>
        /// Date the category description was last modified
        /// </summary>
        public DateTime? LastModified { get; set; }

        /// <summary>
        /// The products which have been assigned this category
        /// </summary>
        public ICollection<Product> Products { get; set; }
    }
}

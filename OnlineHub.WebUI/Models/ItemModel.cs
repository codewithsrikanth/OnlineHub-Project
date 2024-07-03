using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OnlineHub.WebUI.Models
{
    public class ItemModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public IFormFile File { get; set; }
        [Required]
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public string ImageUrl { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public int ItemTypeId { get; set; }
    }
}

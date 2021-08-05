using System.ComponentModel.DataAnnotations;

namespace Community_API.DTO.Models
{
    public class CommunityDTO
    {
        public int CommunityId { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [StringLength(100, ErrorMessage = "Only 100 characters accepted")]
        public string CommunityName { get; set; }
    }
}